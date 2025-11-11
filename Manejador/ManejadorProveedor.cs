using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;
 // Asegúrate de usar el namespace correcto

namespace SistemaGestorPyme
{
    public class ManejadorProveedor
    {


        Base b = new Base("localhost", "root", "", "GestorPyme");

        public void Guardar(Proveedor proveedor)
        {
        

            b.Comando($"insert into tbl_proveedores(nombre, telefono, correo, direccion, activo) " +
                      $"values('{proveedor.Nombre}', '{proveedor.Telefono}', '{proveedor.Correo}', '{proveedor.Direccion}', '{proveedor.Activo}')");

            MessageBox.Show("Proveedor registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(Proveedor proveedor)
        {
            var rs = MessageBox.Show($"¿Estás seguro de **dar de baja** el proveedor: {proveedor.Nombre}?",
                                     "!Atención¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Cambio a Warning ya que es una baja lógica
            if (rs == DialogResult.Yes)
            {
  
                b.Comando($"update tbl_proveedores set activo= 'inactivo' where id_proveedor={proveedor.IdProveedor}");

                MessageBox.Show("Proveedor dado de baja con éxito (marcado como inactivo).", "Baja Lógica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(Proveedor proveedor)
        {

            b.Comando($"update tbl_proveedores set " +
                      $"nombre='{proveedor.Nombre}', " +
                      $"telefono='{proveedor.Telefono}', " +
                      $"correo='{proveedor.Correo}', " +
                      $"direccion='{proveedor.Direccion}', " +
                      $"activo='{proveedor.Activo}' " +
                      $"where id_proveedor={proveedor.IdProveedor}");

            MessageBox.Show("Proveedor modificado con éxito.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            
                tabla.Columns["id_proveedor"].Visible = false;
           
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