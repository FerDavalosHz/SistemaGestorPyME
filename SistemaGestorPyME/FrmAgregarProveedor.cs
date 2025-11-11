using System;
using System.Windows.Forms;
using System.Drawing;
using Entidades;
using Manejador;
using Entidades;
using SistemaGestorPyme;

namespace SistemaGestorPyME
{
    public partial class FrmAgregarProveedor : Form
    {

        ManejadorProveedor mp;
        public FrmAgregarProveedor(int accion)
        {
            InitializeComponent(); 
            mp = new ManejadorProveedor();

            if (accion == 1)
            {

                TxtNombre.Text = FrmProveedor.proveedor.Nombre;
                TxtTelefono.Text = FrmProveedor.proveedor.Telefono;
                TxtCorreo.Text = FrmProveedor.proveedor.Correo;
                TxtDireccion.Text = FrmProveedor.proveedor.Direccion;
            }
            else { 
            Limipiar();

            }

            


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre del proveedor no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(CmbEstado.Text)) {

                MessageBox.Show("Indique el estado del proveedor.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbEstado.Focus();
                return;

            }


              string estatus = CmbEstado.Text == "Activo" ? "activo" : "inactivo";

            Proveedor proveedorParaGuardar = new Proveedor(
                FrmProveedor.proveedor.IdProveedor, // 0 para nuevo, >0 para modificar
                TxtNombre.Text.Trim(),
                TxtTelefono.Text.Trim(),
                TxtCorreo.Text.Trim(),
                TxtDireccion.Text.Trim(), estatus

            );

           
            if (proveedorParaGuardar.IdProveedor == 0)
            {
                mp.Guardar(proveedorParaGuardar);
            }
            else
            {
                mp.Modificar(proveedorParaGuardar);
            }


            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            Close();
     
        }


        void Limipiar()
        {
            
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();
        }
    }
}