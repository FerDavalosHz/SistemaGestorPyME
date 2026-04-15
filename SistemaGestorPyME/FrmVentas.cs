using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Manejador;
using Taller_Kike;

namespace SistemaGestorPyME
{
    public partial class FrmVentas : Form
    {
        public static int Estado = 0;
        ManejadorProducto Mp;

        // Lista de productos seleccionados para la venta actual
        public static List<(int idProducto, string nombre, string categoria,
                            decimal precio, int stock, int cantidad)>
        ProductosSeleccionados = new List<(int, string, string, decimal, int, int)>();

        public FrmVentas()
        {
            InitializeComponent();
            Mp = new ManejadorProducto();
        }

        private bool TienePermisoAdmin()
        {
            if (!Sesion.Rango.Equals("Administrador"))
            {
                MessageBox.Show(
                    $"{Sesion.Nombre} no tiene permiso de hacer eso. Inicie sesión como administrador.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }

        // --- LÓGICA DEL ESCÁNER Y FOCO ---

        private void FrmVentas_Load(object sender, EventArgs e)
        {
           
            this.Activated += (s, ev) => TxtScanner.Focus();
           // CargarProductosSeleccionados();
        }

        private void TxtScanner_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigo = TxtScanner.Text.Trim();

                if (!string.IsNullOrEmpty(codigo))
                {
                    var prod = Mp.ObtenerPorCodigo(codigo);

                    if (prod != null)
                    {
                        var existente = ProductosSeleccionados.FirstOrDefault(x => x.idProducto == prod.IdProducto);

                        if (existente.idProducto != 0)
                        {
                            int index = ProductosSeleccionados.IndexOf(existente);
                            var actualizado = existente;
                            actualizado.cantidad += 1;
                            ProductosSeleccionados[index] = actualizado;
                        }
                        else
                        {
                            // Agregamos nuevo producto (ajusta "General" si traes la categoría de la BD)
                            ProductosSeleccionados.Add((prod.IdProducto, prod.Nombre, "General", prod.PrecioVentaActual, 100, 1));
                        }

                        CargarProductosSeleccionados();
                        ActualizarTotal();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    TxtScanner.Clear();
                    TxtScanner.Focus();
                }
                e.Handled = true;
            }
        }

        // --- GESTIÓN DE LA VENTA ---

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmSeleccionProducto frm = new FrmSeleccionProducto();
            frm.ShowDialog();
            CargarProductosSeleccionados();
            ActualizarTotal();
            TxtScanner.Focus(); // Recuperamos foco tras selección manual
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
            var lista = FrmVentas.ProductosSeleccionados.OrderBy(x => x.nombre).ToList();

            foreach (var p in lista)
            {
                decimal subtotal = p.precio * p.cantidad;
                DtgProductos.Rows.Add(p.idProducto, p.nombre, p.cantidad, p.precio.ToString("0.00"), subtotal.ToString("0.00"));
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
                MessageBox.Show("Selecciona un producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = DtgProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);

            ProductosSeleccionados.RemoveAll(x => x.idProducto == idProducto);
            CargarProductosSeleccionados();
            ActualizarTotal();
            TxtScanner.Focus();
            // Eliminado el Close() de aquí para que no se cierre la venta
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (ProductosSeleccionados.Count == 0) return;

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
            TxtScanner.Focus();
        }

      
        private void pPagarTotal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
          
        }
        private void BtnCerrar_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnCancelarVenta_Click(object sender, EventArgs e) { ProductosSeleccionados.Clear(); this.Close(); }

        private void BtnInicio_Click(object sender, EventArgs e) { ProductosSeleccionados.Clear(); this.Close();  this.Close(); }

        private void BtnInicio_Click_1(object sender, EventArgs e) { ProductosSeleccionados.Clear(); this.Close();  this.Close(); }

        private void BtnInventario_Click_1(object sender, EventArgs e) { ProductosSeleccionados.Clear(); this.Close();  this.Close(); }

        private void BtnProductos_Click(object sender, EventArgs e) { if (TienePermisoAdmin()) ProductosSeleccionados.Clear(); this.Close();  this.Close(); }

        private void BtnCategorias_Click(object sender, EventArgs e) { if (TienePermisoAdmin()) ProductosSeleccionados.Clear(); this.Close(); this.Close(); }

        private void BtnProveedores_Click(object sender, EventArgs e) { if (TienePermisoAdmin()) ProductosSeleccionados.Clear(); this.Close(); this.Close(); }

        private void BtnUsuarios_Click(object sender, EventArgs e) { if (TienePermisoAdmin()) ProductosSeleccionados.Clear(); this.Close();  this.Close(); }

        private void BtnSalir_Click(object sender, EventArgs e) { Application.Exit(); }

        // Eventos de estética
        private void BtnPagar_MouseEnter(object sender, EventArgs e) { pictureBox1.BackColor = Color.FromArgb(120, 140, 170); }
        private void BtnPagar_MouseLeave(object sender, EventArgs e) { pictureBox1.BackColor = Color.FromArgb(135, 158, 196); }
    }
}