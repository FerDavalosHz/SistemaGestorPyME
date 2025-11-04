using AccesoDatos;
using Entidades; // Asegúrate que la entidad Categoria está aquí
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
    public class ManejadorCategoria
    {
        Base b = new Base("localhost", "root", "1234", "GestorPyme");

        public void Guardar(Categoria categoria)
        {
            b.Comando($"insert into tbl_categorias(nombre, descripcion) " +
                      $"values('{categoria.Nombre}', '{categoria.Descripcion}')");
        }

        public void Borrar(Categoria categoria)
        {
            var rs = MessageBox.Show($"Estas seguro de eliminar {categoria.Nombre}", "!Atencion¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from tbl_categorias where id_categoria={categoria.IdCategoria}");
            }
        }

        public void Modificar(Categoria categoria)
        {
            b.Comando($"update tbl_categorias set " +
                      $"nombre='{categoria.Nombre}', " +
                      $"descripcion='{categoria.Descripcion}' " +
                      $"where id_categoria={categoria.IdCategoria}");
        }

        // 6. Adaptamos el método Mostrar
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            // Ocultamos la PK de 'tbl_categorias'
            if (tabla.Columns.Contains("id_categoria"))
            {
                tabla.Columns["id_categoria"].Visible = false;
            }

            tabla.Columns.Insert(3, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));

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
    }
}
