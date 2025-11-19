using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorVentas
    {
        Base b = new Base("localhost", "root", "", "GestorPyme");


        public void Mostrar(string filtro, DataGridView tabla, string datos)
        {
            string consulta =
        "SELECT " +
    "p.id_producto, " +
    "p.nombre AS NombreProducto, " +
    "cat.nombre AS Categoria, " +
    "p.precio_venta_actual, " +
    "COALESCE(inv.stock_actual, 0) AS cantidad_disponible " +
    "FROM tbl_productos p " +
    "INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria " +
    "LEFT JOIN ( " +
    "    SELECT id_producto, SUM(stock_actual) AS stock_actual " +
    "    FROM tbl_inventario_general " +
    "    GROUP BY id_producto " +
    ") inv ON p.id_producto = inv.id_producto " +
    "WHERE p.activo = 1 AND " +
    $"(p.nombre LIKE '%{filtro}%' OR cat.nombre LIKE '%{filtro}%') " +
    "ORDER BY p.nombre ASC";


            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["id_producto"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public int CrearVentaCompleta(
 
    string metodoPago,
    List<(int idProducto, string nombre, string categoria,
         decimal precio, int stock, int cantidad)> ProductosSeleccionados)
        {
            b.Comando("START TRANSACTION");

            try
            {
                string insertarVenta =
                    $"INSERT INTO tbl_ventas (id_usuario, fecha, total, metodo_pago) " +
                    $"VALUES ({Sesion.id}, NOW(), 0, '{metodoPago}')";
                b.Comando(insertarVenta);

                var tabla = b.Consultar("SELECT LAST_INSERT_ID()", "venta").Tables[0];
                int idVenta = Convert.ToInt32(tabla.Rows[0][0]);

                decimal totalVenta = 0;

                foreach (var p in ProductosSeleccionados)
                {
                    decimal subtotal = p.precio * p.cantidad;
                    totalVenta += subtotal;

                    string insertarDetalle =
                        "INSERT INTO tbl_detalle_venta " +
                        "(id_venta, id_producto, cantidad, precio_unitario, subtotal) VALUES (" +
                        $"{idVenta}, {p.idProducto}, {p.cantidad}, {p.precio.ToString().Replace(",", ".")}, {subtotal.ToString().Replace(",", ".")})";
                    b.Comando(insertarDetalle);

       
         
              
                    string actualizarInventario =
                        $"UPDATE tbl_inventario_general " +
                        $"SET stock_actual = stock_actual - {p.cantidad} " +
                        $"WHERE id_producto = {p.idProducto}";
                    b.Comando(actualizarInventario);
                }


                string actualizarTotal =
                    $"UPDATE tbl_ventas SET total = {totalVenta.ToString().Replace(",", ".")} WHERE id_venta = {idVenta}";
                b.Comando(actualizarTotal);

                b.Comando("COMMIT");

                return idVenta;
            }
            catch
            {
                b.Comando("ROLLBACK");
                throw;
            }
        }

    }
}