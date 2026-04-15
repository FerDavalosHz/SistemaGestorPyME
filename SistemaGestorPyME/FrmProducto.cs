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
using Taller_Kike;

namespace SistemaGestorPyME
{
    public partial class FrmProducto : Form
    {
        ManejadorProducto mp;
        int fila = 0;
        int columna = 0;

        // Se mantiene el objeto estático con el nuevo orden del constructor
        public static Producto producto = new Producto(0, "", "", "", 0, 0, false, 0);

        private Timer timerBusqueda;

        public FrmProducto()
        {
            InitializeComponent();
            mp = new ManejadorProducto();

            // Consulta inicial incluyendo codigo_barras
            string consultaInicial = "SELECT p.id_producto, p.codigo_barras, p.nombre, p.descripcion, p.precio_venta_actual, p.stock_minimo, p.activo, cat.nombre AS Categoria, p.id_categoria FROM tbl_productos p INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria";

            mp.Mostrar(consultaInicial, DtgDatos, "tbl_productos");

            timerBusqueda = new Timer();
            timerBusqueda.Interval = 600;
            timerBusqueda.Tick += TimerBusqueda_Tick;

            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private bool TienePermisoAdmin()
        {
            if (!Sesion.Rango.Equals("Administrador"))
            {
                MessageBox.Show($"{Sesion.Nombre} no tiene permiso de hacer eso. Inicie sesión como administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            timerBusqueda.Start();
        }

        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            timerBusqueda.Stop();

            // Búsqueda por Nombre o por Código de Barras
            string consulta = "SELECT p.id_producto, p.codigo_barras, p.nombre, p.descripcion, p.precio_venta_actual, p.stock_minimo, p.activo, cat.nombre AS Categoria, p.id_categoria " +
                            "FROM tbl_productos p " +
                            "INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria " +
                            $"WHERE p.activo = 1 AND (p.nombre LIKE '%{TxtBuscar.Text}%' OR p.codigo_barras LIKE '%{TxtBuscar.Text}%')";

            mp.Mostrar(consulta, DtgDatos, "tbl_productos");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            producto.IdProducto = 0;
            producto.CodigoBarras = "";
            producto.Nombre = "";
            producto.Descripcion = "";
            producto.PrecioVentaActual = 0;
            producto.StockMinimo = 0;
            producto.Activo = true;
            producto.IdCategoria = 0;

            FrmAgregarProducto iu = new FrmAgregarProducto();
            iu.ShowDialog();

            DtgDatos.Columns.Clear();
            TimerBusqueda_Tick(null, null);
        }

        private void LlenarProductoDesdeFila(int indexFila)
        {
            producto.IdProducto = int.Parse(DtgDatos.Rows[indexFila].Cells["id_producto"].Value.ToString());
            producto.CodigoBarras = DtgDatos.Rows[indexFila].Cells["codigo_barras"].Value.ToString();
            producto.Nombre = DtgDatos.Rows[indexFila].Cells["nombre"].Value.ToString();
            producto.Descripcion = DtgDatos.Rows[indexFila].Cells["descripcion"].Value.ToString();
            producto.PrecioVentaActual = decimal.Parse(DtgDatos.Rows[indexFila].Cells["precio_venta_actual"].Value.ToString());
            producto.StockMinimo = int.Parse(DtgDatos.Rows[indexFila].Cells["stock_minimo"].Value.ToString());
            producto.Activo = bool.Parse(DtgDatos.Rows[indexFila].Cells["activo"].Value.ToString());
            producto.IdCategoria = int.Parse(DtgDatos.Rows[indexFila].Cells["id_categoria"].Value.ToString());
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LlenarProductoDesdeFila(e.RowIndex);

            string nombreColumna = DtgDatos.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "btnModificar")
            {
                FrmAgregarProducto iu = new FrmAgregarProducto();
                iu.ShowDialog();
                DtgDatos.Columns.Clear();
                TimerBusqueda_Tick(null, null);
            }
            else if (nombreColumna == "btnEliminar")
            {
                mp.Borrar(producto);
                DtgDatos.Columns.Clear();
                TimerBusqueda_Tick(null, null);
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        // --- SECCIÓN DE NAVEGACIÓN RESTAURADA ---

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;
            this.Close();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;
            this.Close();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            // Ya estamos en productos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;
            this.Close();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se puede dejar vacío si usas CellClick para los botones
        }
    }
}