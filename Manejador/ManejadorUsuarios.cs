using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "", "gestorpyme");

        public void Guardar(Usuario u)
        {
            b.Comando($@"
        INSERT INTO tbl_usuarios
        VALUES (
            NULL,
            '{u.Nombre}',
            '{u.UsuarioNombre}',
            SHA1('{u.Contrasena}'),
            {u.Activo},
            '{u.Rango}'
        )");
        }

        public void Modificar(Usuario u)
        {
            string sql;

              if (string.IsNullOrWhiteSpace(u.Contrasena))
            {
                sql = $@"
            UPDATE tbl_usuarios SET
                nombre = '{u.Nombre}',
                usuario = '{u.UsuarioNombre}',
                activo = {u.Activo},
                rango = '{u.Rango}'
            WHERE id_usuario = {u.IdUsuario}";
            }
            else
            {
                  sql = $@"
            UPDATE tbl_usuarios SET
                nombre = '{u.Nombre}',
                usuario = '{u.UsuarioNombre}',
                contrasena = SHA1('{u.Contrasena}'),
                activo = {u.Activo},
                rango = '{u.Rango}'
            WHERE id_usuario = {u.IdUsuario}";
            }

            b.Comando(sql);
        }

        public void Borrar(Usuario u)
        {
            var rs = MessageBox.Show($"¿Eliminar a {u.Nombre}?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"DELETE FROM tbl_usuarios WHERE id_usuario={u.IdUsuario}");
            }
        }

        public void Mostrar(string consulta, DataGridView tabla)
        {
            tabla.Columns.Clear();

            tabla.DataSource = b.Consultar(consulta, "tbl_usuarios").Tables[0];

            tabla.Columns["id_usuario"].Visible = false;
            tabla.Columns["contrasena"].Visible = false;

            tabla.Columns.Insert(7, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(8, Boton("Borrar", Color.Red));

            tabla.AutoResizeColumns();
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            return new DataGridViewButtonColumn
            {
                Text = titulo,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup,
                DefaultCellStyle = { BackColor = fondo, ForeColor = Color.White }
            };
        }
    }

}
