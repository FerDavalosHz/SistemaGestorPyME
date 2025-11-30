using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Taller_Kike;

namespace SistemaGestorPyME
{
    public partial class FrmVentas : Form
    {

        public static int Estado = 0;


        public static List<(int idProducto, string nombre, string categoria,
                            decimal precio, int stock, int cantidad)>
        ProductosSeleccionados = new List<(int, string, string, decimal, int, int)>();

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmSeleccionProducto frm = new FrmSeleccionProducto();
            frm.ShowDialog();
            CargarProductosSeleccionados();
            ActualizarTotal();
        }

        private void CargarProductosSeleccionados()
        {
            if (DtgProductos.Columns.Count == 0)
            {
                DtgProductos.Columns.Add("idProducto", "ID Producto");
                DtgProductos.Columns["idProducto"].Visible = false;
                DtgProductos.Columns.Add("nombre", "Producto");
                DtgProductos.Columns.Add("cantidad", "Cantidad");
                DtgProductos.Columns.Add("precio", "Precio Unitario");
                DtgProductos.Columns.Add("subtotal", "Subtotal");
            }

            DtgProductos.Rows.Clear();


            var lista = FrmVentas.ProductosSeleccionados
                .OrderBy(x => x.nombre)
                .ToList();

            foreach (var p in lista)
            {
                decimal subtotal = p.precio * p.cantidad;
                DtgProductos.Rows.Add(
                    p.idProducto,
                    p.nombre,
                    p.cantidad,
                    p.precio.ToString("0.00"),
                    subtotal.ToString("0.00")
                );
            }

            DtgProductos.ClearSelection();
        }

        private void ActualizarTotal()
        {
            decimal total = ProductosSeleccionados.Sum(x => x.precio * x.cantidad);
            LblPagar.Text = $"$ {total:0.00}";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (DtgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = DtgProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);

            ProductosSeleccionados.RemoveAll(x => x.idProducto == idProducto);
            DtgProductos.Rows.Remove(fila);
            ActualizarTotal();
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {

            decimal total = ProductosSeleccionados.Sum(x => x.precio * x.cantidad);
            Pagar p = new Pagar(total, ProductosSeleccionados);
            p.ShowDialog();

            if (Estado == 1)
            {
                ProductosSeleccionados.Clear();
                DtgProductos.Rows.Clear();
                ActualizarTotal();
                Estado = 0;

            }
        }

        private void BtnPagar_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(120, 140, 170);
        }

        private void BtnPagar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(135, 158, 196);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
         
           
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInicio_Click_1(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void BtnInventario_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmInventario fi = new FrmInventario();
            fi.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto fp = new FrmProducto();
            fp.Show();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategoria fc = new FrmCategoria();
            fc.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProveedor fpr = new FrmProveedor();
            fpr.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUsuarios fu = new FrmUsuarios();
            fu.Show();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {

        }

        private void pPagarTotal_Paint(object sender, PaintEventArgs e)
        {

        }

   
    }
}