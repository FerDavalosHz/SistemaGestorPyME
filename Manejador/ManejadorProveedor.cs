using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace SistemaGestorPyme
{
    public class ManejadorProveedor
    {
        Base b = new Base("localhost", "root", "1234", "GestorPyme");

        public void Guardar(Proveedor proveedor)
        {
            // CORRECCIÓN: Comparamos el texto. 
            // Si dice "Activo", guardamos un 1. Si dice cualquier otra cosa, guardamos un 0.
            int estado = (proveedor.Activo == "Activo") ? 1 : 0;

            b.Comando($"insert into tbl_proveedores(nombre, telefono, correo, direccion, activo) " +
                      $"values('{proveedor.Nombre}', '{proveedor.Telefono}', '{proveedor.Correo}', '{proveedor.Direccion}', {estado})");

            MessageBox.Show("Proveedor registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(Proveedor proveedor)
        {
            var rs = MessageBox.Show($"¿Estás seguro de **dar de baja** el proveedor: {proveedor.Nombre}?",
                                     "!Atención¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                // Aquí mandamos directo el 0 porque es una baja
                b.Comando($"update tbl_proveedores set activo = 0 where id_proveedor={proveedor.IdProveedor}");

                MessageBox.Show("Proveedor dado de baja con éxito (marcado como inactivo).", "Baja Lógica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(Proveedor proveedor)
        {
            // CORRECCIÓN: Misma lógica que en Guardar
            int estado = (proveedor.Activo == "Activo") ? 1 : 0;

            b.Comando($"update tbl_proveedores set " +
                      $"nombre='{proveedor.Nombre}', " +
                      $"telefono='{proveedor.Telefono}', " +
                      $"correo='{proveedor.Correo}', " +
                      $"direccion='{proveedor.Direccion}', " +
                      $"activo={estado} " +
                      $"where id_proveedor={proveedor.IdProveedor}");

            MessageBox.Show("Proveedor modificado con éxito.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            if (tabla.Columns.Contains("id_proveedor"))
            {
                tabla.Columns["id_proveedor"].Visible = false;
            }

            tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(7, Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        private DataGridViewButtonColumn Boton(string titulo, Color fondo)
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