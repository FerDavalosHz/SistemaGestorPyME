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

namespace SistemaGestorPyME
{
    public partial class FrmAgregarProducto : Form
    {
        ManejadorProducto mp;

        public FrmAgregarProducto()
        {
            InitializeComponent();
            mp = new ManejadorProducto();

            CargarCategoriasEnComboBox();

            if (FrmProducto.producto.IdProducto > 0)
            {
                TxtNombre.Text = FrmProducto.producto.Nombre;
                TxtDescripcion.Text = FrmProducto.producto.Descripcion;
                TxtPrecio.Text = FrmProducto.producto.PrecioVentaActual.ToString();
                TxtStock.Text = FrmProducto.producto.StockMinimo.ToString();
                CbEstado.Checked = FrmProducto.producto.Activo;
                CmbCategoria.SelectedValue = FrmProducto.producto.IdCategoria;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
        string.IsNullOrWhiteSpace(TxtDescripcion.Text) ||
        string.IsNullOrWhiteSpace(TxtPrecio.Text))
            {
                MessageBox.Show("Error: Nombre, Descripción y Precio no pueden estar vacíos.");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(TxtPrecio.Text, out precio))
            {
                MessageBox.Show("Error: El precio debe ser un número decimal válido.");
                return;
            }

            int stock;
            if (!int.TryParse(TxtStock.Text, out stock))
            {
                MessageBox.Show("Error: Ingresa un stock valido.");
                return;
            }

            int idCategoria;
            if (CmbCategoria.SelectedValue == null || !int.TryParse(CmbCategoria.SelectedValue.ToString(), out idCategoria))
            {
                MessageBox.Show("Error: Debe seleccionar una categoría válida.");
                return;
            }

            Producto productoParaGuardar = new Producto(
                FrmProducto.producto.IdProducto,
                TxtNombre.Text,
                TxtDescripcion.Text,
                precio,
                stock,
                CbEstado.Checked,
                idCategoria
            );

            if (FrmProducto.producto.IdProducto == 0)
            {
                mp.Guardar(productoParaGuardar);
            }
            else
            {
                mp.Modificar(productoParaGuardar);
            }

            Close();
        }

        private void CargarCategoriasEnComboBox()
        {
            try
            {
                DataTable dtCategorias = mp.ObtenerCategorias();

                CmbCategoria.DataSource = dtCategorias;

                CmbCategoria.DisplayMember = "nombre";

                CmbCategoria.ValueMember = "id_categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                TxtNombre.Focus(); 
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Agrega una descripción.");
                TxtDescripcion.Focus();
                return;
            }

            decimal precio;
            if (!decimal.TryParse(TxtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese el Precio.");
                TxtPrecio.Focus();
                return;
            }

            int stock;
            if (!int.TryParse(TxtStock.Text, out stock))
            {
                MessageBox.Show("Ponga el stock del producto");
                TxtStock.Focus();
                return;
            }

            int idCategoria;
            if (CmbCategoria.SelectedValue == null || !int.TryParse(CmbCategoria.SelectedValue.ToString(), out idCategoria))
            {
                MessageBox.Show("Elige una categoría para el producto.");
                CmbCategoria.Focus();
                return;
            }


            Producto productoParaGuardar = new Producto(
                FrmProducto.producto.IdProducto,
                TxtNombre.Text,
                TxtDescripcion.Text,
                precio,
                stock,
                CbEstado.Checked, 
                idCategoria
            );

            if (FrmProducto.producto.IdProducto == 0)
            {
                mp.Guardar(productoParaGuardar);
            }
            else
            {
                mp.Modificar(productoParaGuardar);
            }

            Close();

        }
    }
}