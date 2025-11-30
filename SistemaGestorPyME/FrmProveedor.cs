using Entidades;
using Manejador;
using SistemaGestorPyme;
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
    public partial class FrmProveedor : Form
    {
        ManejadorProveedor mp;
        int fila = 0;
        int columna = 0;


        public static Proveedor proveedor = new Proveedor(0, "", "", "", "", "");

        public FrmProveedor()
        {
            InitializeComponent();
            mp = new ManejadorProveedor();
           
        }


        private void CargarDatos()
        {
            string consulta = "SELECT id_proveedor, nombre, telefono, correo, direccion, activo " +
                              "FROM tbl_proveedores " +
                              $"WHERE activo = 1 AND nombre LIKE '%{TxtBuscar.Text.Trim()}%'";

            mp.Mostrar(consulta, DtgDatos, "tbl_proveedores");
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
       
            proveedor = new Proveedor(0, "", "", "", "", "activo");


            FrmAgregarProveedor iu = new FrmAgregarProveedor(2); // Asume que existe FrmAgregarProveedor
            iu.ShowDialog();

            CargarDatos();
        }

      

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex < 0) return;
           
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (e.RowIndex < 0 || (e.ColumnIndex != 6 && e.ColumnIndex != 7))
                return;

            proveedor.IdProveedor = int.Parse(DtgDatos.Rows[fila].Cells["id_proveedor"].Value.ToString());
            proveedor.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
            proveedor.Telefono = DtgDatos.Rows[fila].Cells["telefono"].Value.ToString();
            proveedor.Correo = DtgDatos.Rows[fila].Cells["correo"].Value.ToString();
            proveedor.Direccion = DtgDatos.Rows[fila].Cells["direccion"].Value.ToString();
            proveedor.Activo = DtgDatos.Rows[fila].Cells["activo"].Value.ToString();
         

       
            switch (columna)
            {
                case 6: 
                    {
                        FrmAgregarProveedor iu = new FrmAgregarProveedor(1);
                        iu.ShowDialog();
                     
                        DtgDatos.Columns.Clear();
                        CargarDatos(); 
                    }
                    break;

                case 7: 
                    {
                        mp.Borrar(proveedor); 
                                              
                        DtgDatos.Columns.Clear();
                        CargarDatos(); 
                    }
                    break;
            
        }
    }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmAgregarProveedor iu = new FrmAgregarProveedor(3);
            iu.ShowDialog();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUsuarios fu = new FrmUsuarios();
            fu.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto fp = new FrmProducto();
            fp.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategoria fc = new FrmCategoria();
            fc.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }
    }
}