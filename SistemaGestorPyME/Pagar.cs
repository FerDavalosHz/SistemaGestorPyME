using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Manejador;

namespace SistemaGestorPyME
{
    public partial class Pagar : Form
    {
        ManejadorVentas Mv;
        List<(int idProducto, string nombre, string categoria,
              decimal precio, int stock, int cantidad)> Productos;

        public Pagar(decimal total, List<(int, string, string, decimal, int, int)> productos)
        {
            InitializeComponent();
            LblTotal.Text = total.ToString("0.00");
            Mv = new ManejadorVentas();
            Productos = productos;
        }

        private void TxtPagar_TextChanged(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(LblTotal.Text);
            decimal pagar;

            if (!decimal.TryParse(TxtPagar.Text, out pagar))
            {
                LblCambio.Text = "";
                BtnPagar.Enabled = false;
                return;
            }

            if (pagar < total)
            {
                LblCambio.Text = "Pago insuficiente";
                BtnPagar.Enabled = false;
            }
            else
            {
                LblCambio.Text = (pagar - total).ToString("0.00");
                BtnPagar.Enabled = true;
            }
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            TxtPagar.Focus();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            Mv.CrearVentaCompleta( "Efectivo", FrmVentas.ProductosSeleccionados);
            Close();
        }
    }
}