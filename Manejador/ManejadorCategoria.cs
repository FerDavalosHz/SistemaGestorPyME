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
        Base b = new Base("localhost", "root", "", "GestorPyme");

        public void Guardar(Categoria categoria)
        {
            b.Comando($"insert into tbl_categorias(nombre, descripcion) " +
                      $"values('{categoria.Nombre}', '{categoria.Descripcion}')");

            MessageBox.Show("Categoria registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Borrar(Categoria categoria)
        {
            var rs = MessageBox.Show(
                $"¿Estás seguro de eliminar la categoría {categoria.Nombre}? Esto dejará los productos sin categoría.",
                "¡Atención!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                // Primero dejar productos sin categoría
                b.Comando($"UPDATE tbl_productos SET id_categoria = NULL WHERE id_categoria = {categoria.IdCategoria}");

                // Luego borrar la categoría
                b.Comando($"DELETE FROM tbl_categorias WHERE id_categoria = {categoria.IdCategoria}");

                MessageBox.Show("Categoría eliminada los productos relacionados quedaron sin categoría.",
                                "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(Categoria categoria)
        {
            b.Comando($"update tbl_categorias set " +
                      $"nombre='{categoria.Nombre}', " +
                      $"descripcion='{categoria.Descripcion}' " +
                      $"where id_categoria={categoria.IdCategoria}");

            MessageBox.Show("Categoria modificada con éxito.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

         
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
