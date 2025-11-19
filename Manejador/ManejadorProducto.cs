using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorProducto
    {
        Base b = new Base("localhost", "root", "1234", "GestorPyme");

        public void Guardar(Producto producto)
        {
            int activoValue = producto.Activo ? 1 : 0;

            b.Comando($"insert into tbl_productos(nombre, descripcion, precio_venta_actual, stock_minimo, activo, id_categoria) " +
                      $"values('{producto.Nombre}', '{producto.Descripcion}', {producto.PrecioVentaActual}, {producto.StockMinimo}, {activoValue}, {producto.IdCategoria})");
        }

        public void Borrar(Producto producto)
        {
            var rs = MessageBox.Show($"Estas seguro de eliminar {producto.Nombre}", "!Atencion¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_productos where id_producto={producto.IdProducto}");
            }
        }

        public void Modificar(Producto producto)
        {
            int activoValue = producto.Activo ? 1 : 0;

            b.Comando($"update tbl_productos set " +
                      $"nombre='{producto.Nombre}', " +
                      $"descripcion='{producto.Descripcion}', " +
                      $"precio_venta_actual={producto.PrecioVentaActual}, " +
                      $"stock_minimo={producto.StockMinimo}, " +
                      $"activo={activoValue}, " +
                      $"id_categoria={producto.IdCategoria} " +
                      $"where id_producto={producto.IdProducto}");
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["id_producto"].Visible = false;
            if (tabla.Columns.Contains("id_categoria"))
            {
                tabla.Columns["id_categoria"].Visible = false;
            }
            if (tabla.Columns.Contains("Categoria"))
            {
                tabla.Columns["Categoria"].HeaderText = "Categoría";
            }
            tabla.Columns.Insert(7, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(8, Boton("Eliminar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }

        public DataTable ObtenerCategorias()
        {
            string consulta = "SELECT id_categoria, nombre FROM tbl_categorias ORDER BY nombre";

            return b.Consultar(consulta, "tbl_categorias").Tables[0];
        }
        public void MostrarParaEntrada(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            tabla.Columns["id_producto"].Visible = false;
            if (tabla.Columns.Contains("id_categoria")) tabla.Columns["id_categoria"].Visible = false;
            if (tabla.Columns.Contains("activo")) tabla.Columns["activo"].Visible = false;

            tabla.AutoResizeColumns();
        }
        public void MostrarHistorialEntradas(DataGridView tabla)
        {
            tabla.Columns.Clear();
            string consulta = "SELECT h.id_entrada, p.nombre, h.cantidad_agregada, h.fecha_registro " +
                              "FROM tbl_historial_entradas h " +
                              "INNER JOIN tbl_productos p ON h.id_producto = p.id_producto " +
                              "ORDER BY h.fecha_registro DESC";

            tabla.DataSource = b.Consultar(consulta, "tbl_historial_entradas").Tables[0];
            tabla.AutoResizeColumns();
        }
        public DataTable ObtenerProveedores()
        {
            return b.Consultar("SELECT id_proveedor, nombre FROM tbl_proveedores WHERE activo = 1", "tbl_proveedores").Tables[0];
        }

        public void RegistrarEntrada(int idProducto, int cantidad, decimal precioCompra, int idProveedor, string nota)
        {
            string sql = $"INSERT INTO tbl_historial_entradas " +
                         $"(id_producto, cantidad_agregada, precio_compra, id_usuario, id_proveedor, nota) " +
                         $"VALUES " +
                         $"({idProducto}, {cantidad}, {precioCompra}, 1, {idProveedor}, '{nota}')";

            b.Comando(sql);
        }

    }
}
