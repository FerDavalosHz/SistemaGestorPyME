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
        int fila = 0; int columna = 0;

        public static Categoria categoria = new Categoria(0, "", ""); 

        public FrmCategoria()
        {
            InitializeComponent();
            mc = new ManejadorCategoria(); 
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
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                categoria.IdCategoria = int.Parse(DtgDatos.Rows[fila].Cells["id_categoria"].Value.ToString());
                categoria.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
                categoria.Descripcion = DtgDatos.Rows[fila].Cells["descripcion"].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }

            switch (columna)
            {
                case 3: 
                    {
                        FrmAgregarCategoria iu = new FrmAgregarCategoria(); 
                        iu.ShowDialog();
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
            fila = e.RowIndex; columna = e.ColumnIndex;
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
            this.Close();
            FrmVentas fv = new FrmVentas();
            fv.ShowDialog();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInventario fi = new FrmInventario();
            fi.ShowDialog();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto fp = new FrmProducto();
            fp.ShowDialog();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProveedor fpr = new FrmProveedor();
            fpr.ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUsuarios fu = new FrmUsuarios();
            fu.ShowDialog();
        }
    }
}
