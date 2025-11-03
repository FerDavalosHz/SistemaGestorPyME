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

namespace SistemaGestorPyME
{
    public partial class FrmProducto : Form
    {
        ManejadorProducto mp;
        int fila = 0; int columna = 0;
        public static Producto producto = new Producto(0, "", "", 0, 0, false, 0);

        public FrmProducto()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            string consulta = "SELECT " +
                "p.id_producto, " +
                "p.nombre, " +
                "p.descripcion, " +
                "p.precio_venta_actual, " +
                "p.stock_minimo, " +
                "p.activo, " +
                "cat.nombre AS Categoria, " + 
                "p.id_categoria " +            
            "FROM tbl_productos p " +
            "INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria " +
            $"WHERE p.nombre LIKE '%{TxtBuscar.Text}%'"; 

            mp.Mostrar(consulta, DtgDatos, "tbl_productos");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            producto.IdProducto = 0;
            producto.Nombre = "";
            producto.Descripcion = "";
            producto.PrecioVentaActual = 0;
            producto.StockMinimo = 0;
            producto.Activo = true;
            producto.IdCategoria = 0; 

            FrmAgregarProducto iu = new FrmAgregarProducto();
            iu.ShowDialog();

            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
           producto.IdProducto = int.Parse(DtgDatos.Rows[fila].Cells["id_producto"].Value.ToString());
           producto.Nombre = DtgDatos.Rows[fila].Cells["nombre"].Value.ToString();
           producto.Descripcion = DtgDatos.Rows[fila].Cells["descripcion"].Value.ToString();
           producto.PrecioVentaActual = decimal.Parse(DtgDatos.Rows[fila].Cells["precio_venta_actual"].Value.ToString());
           producto.StockMinimo = int.Parse(DtgDatos.Rows[fila].Cells["stock_minimo"].Value.ToString());
           producto.Activo = bool.Parse(DtgDatos.Rows[fila].Cells["activo"].Value.ToString());
           producto.IdCategoria = int.Parse(DtgDatos.Rows[fila].Cells["id_categoria"].Value.ToString());

            switch (columna)
            {
                case 7: 
                    {
                        FrmAgregarProducto iu = new FrmAgregarProducto();
                        iu.ShowDialog();

                        DtgDatos.Columns.Clear();
                    }
                    break;

                case 8: 
                    {
                        mp.Borrar(producto);

                        DtgDatos.Columns.Clear();
                    }
                    break;
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }
    }
}
