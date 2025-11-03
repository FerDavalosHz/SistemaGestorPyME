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

    }
}
