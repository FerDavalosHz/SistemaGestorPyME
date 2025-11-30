using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            ME = new ManejadorExcel();
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
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mu.Mostrar(
                  $"SELECT * FROM tbl_usuarios WHERE activo = 1 AND nombre LIKE '%{TxtUsuario.Text}%'",
                  DtgDatos
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
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInventario Fi = new FrmInventario();
            Fi.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmVentas Fv = new FrmVentas();
            Fv.Show();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ME.ExportarReporteVentasACsv();
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

                if (cellValue.Equals("Modificar", StringComparison.OrdinalIgnoreCase))
                {
                    using (FrmDatosUsuarios du = new FrmDatosUsuarios())
                    {
                        du.ShowDialog();
                    }
                    DtgDatos.Columns.Clear();
                }
                else if (cellValue.Equals("Borrar", StringComparison.OrdinalIgnoreCase))
                {
                    mu.Borrar(usuario);
                    DtgDatos.Columns.Clear();
                }

                return;
            }

        }
    }
}
