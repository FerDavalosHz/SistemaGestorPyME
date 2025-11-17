using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorVentas
    {


        Base b = new Base("localhost", "root", "", "GestorPyme");
        public void Mostrar(string producto, DataGridView tabla, string datos)
        {

            string consulta =
   "SELECT " +
   "p.id_producto, " +
   "l.id_lote, " +
   "p.nombre AS NombreProducto, " +
   "cat.nombre AS Categoria, " +
   "l.codigo_lote, " +
   "p.precio_venta_actual, " +
   "l.cantidad_disponible AS Stock, " +
   "l.fecha_vencimiento " +
   "FROM tbl_productos p " +
   "INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria " +
   "INNER JOIN tbl_lotes l ON p.id_producto = l.id_producto " +
   "WHERE p.activo = 1 " +
   "AND l.fecha_vencimiento > CURDATE() " +        
   "AND (p.nombre LIKE '%" + producto + "%' " +      
   "OR cat.nombre LIKE '%" + producto + "%') " +     
   "ORDER BY l.fecha_vencimiento ASC;";

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            tabla.Columns["id_producto"].Visible = false;
            tabla.Columns["id_lote"].Visible = false;
            tabla.Columns["codigo_lote"].Visible = false;
        //    tabla.Columns["Stock"].Visible = false;



            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public int CrearVentaCompleta(int idUsuario, string metodoPago, List<(int idProducto, int idLote, string nombre, string categoria, string codigoLote, decimal precio, int stock, int cantidad, DateTime fechaVencimiento)> ProductosSeleccionados)
        {
          
            string insertarVenta =
                $"INSERT INTO tbl_ventas (id_usuario, fecha, total, metodo_pago) " +
                $"VALUES ({idUsuario}, NOW(), 0, '{metodoPago}')";

            b.Comando(insertarVenta);

       
            string consultaId = "SELECT MAX(id_venta) FROM tbl_ventas";
            var tabla = b.Consultar(consultaId, "venta").Tables[0];
            int idVenta = Convert.ToInt32(tabla.Rows[0][0]);

            decimal totalVenta = 0;

            
            foreach (var p in ProductosSeleccionados)
            {
                decimal subtotal = p.precio * p.cantidad;
                totalVenta += subtotal;

                string insertarDetalle =
                    "INSERT INTO tbl_detalle_venta " +
                    "(id_venta, id_producto, id_lote, cantidad, precio_unitario, subtotal) VALUES (" +
                    $"{idVenta}, {p.idProducto}, {p.idLote}, {p.cantidad}, {p.precio}, {subtotal})";

                b.Comando(insertarDetalle);

               
                string actualizarLote =
                    $"UPDATE tbl_lotes " +
                    $"SET cantidad_disponible = cantidad_disponible - {p.cantidad} " +
                    $"WHERE id_lote = {p.idLote}";

                b.Comando(actualizarLote);
            }

            string actualizarTotal =
                $"UPDATE tbl_ventas SET total = {totalVenta} WHERE id_venta = {idVenta}";

            b.Comando(actualizarTotal);

            return idVenta;
        }

    }
}
