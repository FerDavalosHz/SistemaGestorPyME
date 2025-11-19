using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace SistemaGestorPyME
{
    public partial class FrmQuitarInventario : Form
    {

        private int idProducto;
        private ManejadorInventario mi;

        public FrmQuitarInventario(int id, string nombre)
        {
            InitializeComponent();
            idProducto = id;
            LblNombreProducto.Text = nombre;
            mi = new ManejadorInventario();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa un valor numérico válido mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                mi.ReducirStock(idProducto, cantidad);

                MessageBox.Show("Inventario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
