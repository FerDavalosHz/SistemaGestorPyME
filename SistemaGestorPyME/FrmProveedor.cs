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
                              $"WHERE nombre LIKE '%{TxtBuscar.Text.Trim()}%'"; 

            mp.Mostrar(consulta, DtgDatos, "tbl_proveedores"); 
        }

   
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Reiniciar el proveedor estático para un nuevo registro
            proveedor = new Proveedor(0, "", "", "", "", "activo");

            // Abre el formulario de agregar/modificar
            FrmAgregarProveedor iu = new FrmAgregarProveedor(2); // Asume que existe FrmAgregarProveedor
            iu.ShowDialog();

            // Recargar datos al cerrar el formulario de agregar/modificar
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
    }
}