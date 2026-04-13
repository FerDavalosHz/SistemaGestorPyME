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
    public partial class FrmCategoria : Form
    {
        ManejadorCategoria mc;
        int fila = 0;
        int columna = 0;

        public static Categoria categoria = new Categoria(0, "", "");

        public FrmCategoria()
        {
            InitializeComponent();
            mc = new ManejadorCategoria();
            mc.Mostrar("SELECT * FROM tbl_categorias", DtgDatos, "tbl_categorias");
            timerBusque = new Timer();
            timerBusque.Interval = 500;
            timerBusque.Tick += timerBusque_Tick;

            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
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


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = $"SELECT id_categoria, nombre, descripcion FROM tbl_categorias " +
                              $"WHERE nombre LIKE '%{TxtBuscar.Text}%'";

            mc.Mostrar(consulta, DtgDatos, "tbl_categorias");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            categoria.IdCategoria = 0;
            categoria.Nombre = "";
            categoria.Descripcion = "";

            FrmAgregarCategoria iu = new FrmAgregarCategoria();
            iu.ShowDialog();

            CargarDatos();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                categoria.IdCategoria = int.Parse(DtgDatos.Rows[fila].Cells["id_categoria"].Value.ToString());
                categoria.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
                categoria.Descripcion = DtgDatos.Rows[fila].Cells["descripcion"].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }

            switch (columna)
            {
                case 3:
                    {
                        FrmAgregarCategoria iu = new FrmAgregarCategoria();
                        iu.ShowDialog();
                        iu.Focus();
                        DtgDatos.Columns.Clear();
                    }
                    break;

                case 4:
                    {
                        mc.Borrar(categoria);
                        DtgDatos.Columns.Clear();
                    }
                    break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;

            this.Close();
            FrmVentas fv = new FrmVentas();
            fv.ShowDialog();
            fv.Focus();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;

            this.Close();
            FrmInventario fi = new FrmInventario();
            fi.ShowDialog();
            fi.Focus();
        }

    
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;

            this.Close();
            FrmProducto fp = new FrmProducto();
            fp.ShowDialog();
            fp.Focus();
        }


        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;

            this.Close();
            FrmProveedor fpr = new FrmProveedor();
            fpr.ShowDialog();
            fpr.Focus();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if (!TienePermisoAdmin()) return;

            this.Close();
            FrmUsuarios fu = new FrmUsuarios();
            fu.ShowDialog();
            fu.Focus();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            timerBusque.Stop();
            timerBusque.Start();
        }

        private void timerBusque_Tick(object sender, EventArgs e)
        {
            timerBusque.Stop();

            string consulta = $"SELECT id_categoria, nombre, descripcion FROM tbl_categorias WHERE nombre LIKE '%{TxtBuscar.Text}%'";

            mc.Mostrar(consulta, DtgDatos, "tbl_categorias");
        }

        private void DtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                categoria.IdCategoria = int.Parse(DtgDatos.Rows[e.RowIndex].Cells["id_categoria"].Value.ToString());
                categoria.Nombre = DtgDatos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                categoria.Descripcion = DtgDatos.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            }
            catch { return; }

            string nombreColumna = DtgDatos.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "btnModificar")
            {
                FrmAgregarCategoria iu = new FrmAgregarCategoria();
                iu.ShowDialog();

                CargarDatos();
            }
            else if (nombreColumna == "btnEliminar")
            {
                mc.Borrar(categoria);

                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            // Si tienes texto en buscar, respétalo, si no, carga todo
            string sql = string.IsNullOrWhiteSpace(TxtBuscar.Text)
                ? "SELECT * FROM tbl_categorias"
                : $"SELECT id_categoria, nombre, descripcion FROM tbl_categorias WHERE nombre LIKE '%{TxtBuscar.Text}%'";

            mc.Mostrar(sql, DtgDatos, "tbl_categorias");
        }
    }
}
