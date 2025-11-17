using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
namespace SistemaGestorPyME
{
    public partial class Pagar : Form
    {

        ManejadorVentas Mv;
        public Pagar(decimal pago)
        {
            InitializeComponent();
            LblTotal.Text = pago.ToString("0.00");
            Mv = new ManejadorVentas();
        }

        private void TxtPagar_TextChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal.TryParse(LblTotal.Text, out total);

         
            decimal pagar = 0;
            decimal.TryParse(TxtPagar.Text, out pagar);

          
            if (string.IsNullOrWhiteSpace(TxtPagar.Text))
            {
                LblCambio.Text = "";
                return;
            }

            if (pagar < total)
            {
                LblCambio.Text = "Pago insuficiente";
                BtnPagar.Enabled = false;
            }
            else
            {
                decimal cambio = pagar - total;
                LblCambio.Text = cambio.ToString("0.00");
                BtnPagar.Enabled = true;
            }
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            TxtPagar.Focus();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            Mv.CrearVentaCompleta(3, "Efectivo", FrmVentas.ProductosSeleccionados);
        }
    }
}
