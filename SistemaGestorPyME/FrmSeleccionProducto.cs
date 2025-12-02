using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Manejador;

namespace SistemaGestorPyME
{
    public partial class FrmSeleccionProducto : Form
    {
        ManejadorVentas Mv;
        private Timer timerBusqueda;

        public (int idProducto, string nombre, string categoria,
                string codigoLote, decimal precio, int stock, DateTime fechaVencimiento)?
        ProductoSeleccionado
        { get; private set; }

        public FrmSeleccionProducto()
        {
            InitializeComponent();

            Mv = new ManejadorVentas();

            timerBusqueda = new Timer();
            timerBusqueda.Interval = 500;
            timerBusqueda.Tick += TimerBusqueda_Tick;

            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            timerBusqueda.Start();
        }

        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            Mv.Mostrar(TxtBuscar.Text, DtgDatos, "tbl_lotes");
            PintarFilasSinStock();
            DtgDatos.ClearSelection();
        }

        private void FrmSeleccionProducto_Load(object sender, EventArgs e)
        {
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;

            Mv.Mostrar(TxtBuscar.Text, DtgDatos, "tbl_lotes");
            PintarFilasSinStock();
            DtgDatos.ClearSelection();
            Color morado = ColorTranslator.FromHtml("#7F66B6");

            DtgDatos.EnableHeadersVisualStyles = false; 
            DtgDatos.ColumnHeadersDefaultCellStyle.BackColor = morado;
            DtgDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DtgDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DtgDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DtgDatos.ColumnHeadersHeight = 35;
        }

        private void PintarFilasSinStock()
        {
            foreach (DataGridViewRow row in DtgDatos.Rows)
            {
                if (row.Cells["cantidad_disponible"].Value == null)
                    continue;

                int stock = Convert.ToInt32(row.Cells["cantidad_disponible"].Value);

                if (stock == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(0xE2, 0xD9, 0xF6);

                   
                

                 
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DtgDatos.Rows[e.RowIndex];
            LblSeleccion.Text = fila.Cells["NombreProducto"].Value.ToString();
            TxtCantidad.Focus();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = DtgDatos.CurrentRow;

            int idProducto = Convert.ToInt32(fila.Cells["id_producto"].Value);
            string nombre = fila.Cells["NombreProducto"].Value.ToString();
            string categoria = fila.Cells["Categoria"].Value.ToString();
            decimal precio = Convert.ToDecimal(fila.Cells["precio_venta_actual"].Value);
            int stock = Convert.ToInt32(fila.Cells["cantidad_disponible"].Value);

            var existente = FrmVentas.ProductosSeleccionados
                .FirstOrDefault(x => x.idProducto == idProducto);

            if (existente.idProducto != 0)
            {
                int nuevaCantidad = existente.cantidad + cantidad;

                if (nuevaCantidad > stock)
                {
                    MessageBox.Show("La cantidad total supera el stock disponible.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FrmVentas.ProductosSeleccionados =
                    FrmVentas.ProductosSeleccionados
                        .Select(x =>
                            x.idProducto == idProducto
                            ? (x.idProducto, x.nombre, x.categoria, x.precio, x.stock, nuevaCantidad)
                            : x
                        ).ToList();

                MessageBox.Show($"Cantidad actualizada para '{nombre}'.", "Actualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
                return;
            }

            if (cantidad > stock)
            {
                MessageBox.Show("Stock insuficiente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmVentas.ProductosSeleccionados.Add((
                idProducto,
                nombre,
                categoria,
                precio,
                stock,
                cantidad
            ));

            MessageBox.Show($"Producto '{nombre}' agregado.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void TxtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;
            BtnAgregar.PerformClick();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
