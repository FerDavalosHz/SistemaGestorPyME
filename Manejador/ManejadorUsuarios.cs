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
        Base b = new Base("localhost", "root", "1234", "gestorpyme");

        public void Guardar(Usuario u)
        {
            int estadoActivo = u.Activo ? 1 : 0;

            b.Comando($@"
        INSERT INTO tbl_usuarios (id_usuario, nombre, usuario, contrasena, activo, rango)
        VALUES (
            NULL,
            '{u.Nombre}',
            '{u.UsuarioNombre}',
            SHA1('{u.Contrasena}'),
            {estadoActivo}, 
            '{u.Rango}'
        )");

            MessageBox.Show("Usuario registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Modificar(Usuario u)
        {
            string sql;
            int estadoActivo = u.Activo ? 1 : 0;

            if (string.IsNullOrWhiteSpace(u.Contrasena))
            {
                sql = $@"UPDATE tbl_usuarios SET 
                        nombre = '{u.Nombre}', 
                        usuario = '{u.UsuarioNombre}', 
                        activo = {estadoActivo}, 
                        rango = '{u.Rango}' 
                        WHERE id_usuario = {u.IdUsuario}";
            }
            else
            {
                sql = $@"UPDATE tbl_usuarios SET 
                        nombre = '{u.Nombre}', 
                        usuario = '{u.UsuarioNombre}', 
                        contrasena = SHA1('{u.Contrasena}'), 
                        activo = {estadoActivo}, 
                        rango = '{u.Rango}' 
                        WHERE id_usuario = {u.IdUsuario}";
            }

            b.Comando(sql);
            MessageBox.Show("Usuario modificado con éxito.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Borrar(Usuario u)
        {
            var rs = MessageBox.Show($"¿Eliminar a {u.Nombre}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                // Aquí podrías cambiar a una baja lógica (update activo=0) si prefieres no borrarlo físicamente
                b.Comando($"DELETE FROM tbl_usuarios WHERE id_usuario={u.IdUsuario}");
                MessageBox.Show("Usuario eliminado con éxito.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            if (tabla.Columns.Contains("id_usuario")) tabla.Columns["id_usuario"].Visible = false;
            if (tabla.Columns.Contains("contrasena")) tabla.Columns["contrasena"].Visible = false;

            tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(7, Boton("Borrar", Color.Red));

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.AutoResizeRows();
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
