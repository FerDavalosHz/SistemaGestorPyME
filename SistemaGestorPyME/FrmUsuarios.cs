using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Entidades;
using Manejador;
using SistemaGestorPyME;

namespace Taller_Kike
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        ManejadorExcel ME;

          public static Usuario usuario = new Usuario(0, "", "", "", false, "");

        int fila = 0, columna = 0;
        private Timer timerBusqueda;


        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            ME = new ManejadorExcel();
            mu.Mostrar("SELECT * FROM tbl_usuarios", DtgDatos, "tbl_usuarios");
            timerBusque = new Timer();
            timerBusque.Interval = 500;
            timerBusque.Tick += timerBusque_Tick;

            TxtUsuario.TextChanged += TxtUsuario_TextChanged;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            usuario.IdUsuario = 0;
            usuario.Nombre = "";
            usuario.UsuarioNombre = "";
            usuario.Contrasena = "";
            usuario.Activo = false;
            usuario.Rango = "";

            using (FrmDatosUsuarios du = new FrmDatosUsuarios())
            {
                du.ShowDialog();
            }

            DtgDatos.Columns.Clear();
            mu.Mostrar("SELECT * FROM tbl_usuarios", DtgDatos, "tbl_usuarios");
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mu.Mostrar($"SELECT * FROM tbl_usuarios WHERE activo = 1 AND nombre LIKE '%{TxtUsuario.Text}%'",DtgDatos,"tbl_usuarios"
              );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProveedor Fp = new FrmProveedor();
            Fp.Show();
            Fp.Focus();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto frm = new FrmProducto();
            frm.Show();
            frm.Focus();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInventario Fi = new FrmInventario();
            Fi.Show();
            Fi.Focus();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmVentas Fv = new FrmVentas();
            Fv.Show();
            Fv.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategoria fc = new FrmCategoria();
            fc.Show();
            fc.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ME.ExportarReporteVentasACsv();

            string ruta = @"C:\Users\fermm\Documents\LECTURADEDATOSGESTORPYME.xlsm";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("El archivo no existe en la ruta especificada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            timerBusque.Stop();
            timerBusque.Start();
        }

        private void timerBusque_Tick(object sender, EventArgs e)
        {
            timerBusque.Stop();

            string consulta = $"SELECT * FROM tbl_usuarios WHERE nombre LIKE '%{TxtUsuario.Text}%' OR usuario LIKE '%{TxtUsuario.Text}%'";

            mu.Mostrar(consulta, DtgDatos, "tbl_usuarios");
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            try
            {
                var row = DtgDatos.Rows[e.RowIndex];

                usuario.IdUsuario = row.Cells["id_usuario"] != null && row.Cells["id_usuario"].Value != null
                    ? Convert.ToInt32(row.Cells["id_usuario"].Value)
                    : 0;

                usuario.Nombre = row.Cells["nombre"]?.Value?.ToString() ?? "";
                usuario.UsuarioNombre = row.Cells["usuario"]?.Value?.ToString() ?? "";
                usuario.Contrasena = row.Cells["contrasena"]?.Value?.ToString() ?? "";
                usuario.Activo = row.Cells["activo"] != null && row.Cells["activo"].Value != null
                    ? Convert.ToBoolean(row.Cells["activo"].Value)
                    : false;
                usuario.Rango = row.Cells["rango"]?.Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer fila: " + ex.Message);
                return;
            }

            if (DtgDatos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var cellValue = DtgDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";

               
                if (usuario.UsuarioNombre.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El usuario 'admin' no puede ser modificado ni eliminado.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

          
                if (cellValue.Equals("Modificar", StringComparison.OrdinalIgnoreCase))
                {
                    using (FrmDatosUsuarios du = new FrmDatosUsuarios())
                    {
                        du.ShowDialog();
                    }
                    DtgDatos.Columns.Clear();
                    mu.Mostrar("SELECT * FROM tbl_usuarios", DtgDatos, "tbl_usuarios");
                }
                else if (cellValue.Equals("Borrar", StringComparison.OrdinalIgnoreCase))
                {
                    mu.Borrar(usuario);
                    DtgDatos.Columns.Clear();
                    mu.Mostrar("SELECT * FROM tbl_usuarios", DtgDatos, "tbl_usuarios");
                }

                return;
            }
        }

    }
}
