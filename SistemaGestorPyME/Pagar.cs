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

        decimal TotalVenta = 0;

        public Pagar(decimal total, List<(int, string, string, decimal, int, int)> productos)
        {
            InitializeComponent();
            TotalVenta = total;
            LblTotal.Text = total.ToString("0.00");
            Mv = new ManejadorVentas();
            Productos = productos;
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            TxtPagar.Focus();
        }

        private void TxtPagar_TextChanged(object sender, EventArgs e)
        {
            ValidarEfectivo();
        }

        private void ValidarEfectivo()
        {
            if (!decimal.TryParse(TxtPagar.Text, out decimal pagar))
            {
                LblCambio.Text = "";
                BtnPagar.Enabled = false;
                return;
            }

            if (pagar < TotalVenta)
            {
                LblCambio.Text = "Pago insuficiente";
                BtnPagar.Enabled = false;
            }
            else
            {
                LblCambio.Text = (pagar - TotalVenta).ToString("0.00");
                BtnPagar.Enabled = true;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            string metodo = ObtenerMetodoPago();
            Mv.CrearVentaCompleta(metodo, FrmVentas.ProductosSeleccionados);
            FrmVentas.Estado = 1;
            Close();
        }

        private string ObtenerMetodoPago()
        {
            if (checkBox1.Checked) return "Efectivo";
            if (checkBox2.Checked) return "Tarjeta";
            if (checkBox3.Checked) return "Transferencia";
            return "Efectivo";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SeleccionarSolo(checkBox2);
                new Tarjeta().ShowDialog();
                ActualizarMetodoPago("Tarjeta");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SeleccionarSolo(checkBox3);
                new Transferencia().ShowDialog();
                ActualizarMetodoPago("Transferencia");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SeleccionarSolo(checkBox1);
                ActualizarMetodoPago("Efectivo");
                ValidarEfectivo();
            }
        }

        private void ActualizarMetodoPago(string metodo)
        {
            if (metodo == "Efectivo")
            {
                label3.Visible = true;
                LblCambio.Visible = true;
                TxtPagar.Enabled = true;
                label3.Text = "Cantidad:";
            }
            else
            {
                TxtPagar.Enabled = false;
                LblCambio.Visible = false;
                label3.Visible = true;

                if (metodo == "Tarjeta")
                    label3.Text = "PAGADO CON TARJETA";
                else if (metodo == "Transferencia")
                    label3.Text = "PAGADO CON TRANSFERENCIA";

                BtnPagar.Enabled = true;
            }
        }

        private void SeleccionarSolo(CheckBox seleccionada)
        {
            checkBox1.CheckedChanged -= checkBox1_CheckedChanged;
            checkBox2.CheckedChanged -= checkBox2_CheckedChanged;
            checkBox3.CheckedChanged -= checkBox3_CheckedChanged;

            checkBox1.Checked = (seleccionada == checkBox1);
            checkBox2.Checked = (seleccionada == checkBox2);
            checkBox3.Checked = (seleccionada == checkBox3);

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
        }
    }
}
