using Entidades;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorPyME
{
    public partial class FrmAgregarCategoria : Form
    {
        ManejadorCategoria mc;
        public FrmAgregarCategoria()
        {
            InitializeComponent();
            mc = new ManejadorCategoria();
            if (FrmCategoria.categoria.IdCategoria > 0)
            {
                TxtNombre.Text = FrmCategoria.categoria.Nombre;
                TxtDescripcion.Text = FrmCategoria.categoria.Descripcion;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                TxtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Agrega una descripción.");
                TxtDescripcion.Focus();
                return;
            }


            Categoria categoriaParaGuardar = new Categoria(
                FrmCategoria.categoria.IdCategoria,
                TxtNombre.Text,
                TxtDescripcion.Text
            );

            if (FrmCategoria.categoria.IdCategoria == 0)
            {
                mc.Guardar(categoriaParaGuardar);
            }
            else
            {
                mc.Modificar(categoriaParaGuardar);
            }

            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
