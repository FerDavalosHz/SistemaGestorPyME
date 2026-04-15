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
        Base b = new Base("localhost", "root", "", "gestorpyme");

        public void Guardar(Producto producto)
        {
            int activoValue = producto.Activo ? 1 : 0;
            // Se agrega 'codigo_barras' a la consulta
            b.Comando($"insert into tbl_productos(codigo_barras, nombre, descripcion, precio_venta_actual, stock_minimo, activo, id_categoria) " +
                      $"values('{producto.CodigoBarras}', '{producto.Nombre}', '{producto.Descripcion}', {producto.PrecioVentaActual}, {producto.StockMinimo}, {activoValue}, {producto.IdCategoria})");

            MessageBox.Show("Producto registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(Producto producto)
        {
            var rs = MessageBox.Show($"Estas seguro de eliminar {producto.Nombre}", "!Atencion¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_productos where id_producto={producto.IdProducto}");
                MessageBox.Show("Producto eliminado con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(Producto producto)
        {
            int activoValue = producto.Activo ? 1 : 0;
            // Se agrega la actualización del 'codigo_barras'
            b.Comando($"update tbl_productos set " +
                      $"codigo_barras='{producto.CodigoBarras}', " +
                      $"nombre='{producto.Nombre}', " +
                      $"descripcion='{producto.Descripcion}', " +
                      $"precio_venta_actual={producto.PrecioVentaActual}, " +
                      $"stock_minimo={producto.StockMinimo}, " +
                      $"activo={activoValue}, " +
                      $"id_categoria={producto.IdCategoria} " +
                      $"where id_producto={producto.IdProducto}");

            MessageBox.Show("Producto modificado con éxito.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            // Ocultamos el ID pero dejamos visible el Código de Barras
            if (tabla.Columns.Contains("id_producto")) tabla.Columns["id_producto"].Visible = false;
            if (tabla.Columns.Contains("id_categoria")) tabla.Columns["id_categoria"].Visible = false;

            // Ajuste de los índices de los botones (ahora hay una columna más, movemos a 8 y 9)
            tabla.Columns.Insert(tabla.ColumnCount, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(tabla.ColumnCount, Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
        }

        DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.Name = "btn" + titulo;
            return btn;
        }

        public DataTable ObtenerCategorias()
        {
            return b.Consultar("SELECT id_categoria, nombre FROM tbl_categorias ORDER BY nombre", "tbl_categorias").Tables[0];
        }

        public void MostrarParaEntrada(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            if (tabla.Columns.Contains("id_producto")) tabla.Columns["id_producto"].Visible = false;
            if (tabla.Columns.Contains("id_categoria")) tabla.Columns["id_categoria"].Visible = false;
            if (tabla.Columns.Contains("activo")) tabla.Columns["activo"].Visible = false;
            tabla.AutoResizeColumns();
        }

        public DataTable ObtenerProveedores()
        {
            return b.Consultar("SELECT id_proveedor, nombre FROM tbl_proveedores WHERE activo = 1", "tbl_proveedores").Tables[0];
        }

        public void RegistrarEntrada(int idProducto, int cantidad, decimal precioCompra, int idProveedor, string nota, string fechaCaducidad)
        {
            string fechaSql = string.IsNullOrEmpty(fechaCaducidad) ? "NULL" : $"'{fechaCaducidad}'";

            string sql = $"INSERT INTO tbl_historial_entradas " +
                         $"(id_producto, cantidad_agregada, precio_compra, id_usuario, id_proveedor, nota, fecha_caducidad) " +
                         $"VALUES " +
                         $"({idProducto}, {cantidad}, {precioCompra}, 1, {idProveedor}, '{nota}', {fechaSql})";

            b.Comando(sql);
        }


        public Producto ObtenerPorCodigo(string codigo)
        {
            // Buscamos el producto y su categoría mediante un JOIN
            string sql = $"SELECT p.id_producto, p.codigo_barras, p.nombre, p.descripcion, " +
                         $"p.precio_venta_actual, p.stock_minimo, p.activo, p.id_categoria " +
                         $"FROM tbl_productos p WHERE p.codigo_barras = '{codigo}' AND p.activo = 1";

            DataSet ds = b.Consultar(sql, "tbl_productos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                return new Producto(
                    Convert.ToInt32(row["id_producto"]),
                    row["codigo_barras"].ToString(),
                    row["nombre"].ToString(),
                    row["descripcion"].ToString(),
                    Convert.ToDecimal(row["precio_venta_actual"]),
                    Convert.ToInt32(row["stock_minimo"]),
                    Convert.ToBoolean(row["activo"]),
                    Convert.ToInt32(row["id_categoria"])
                );
            }
            return null;
        }

    }
}