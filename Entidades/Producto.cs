using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto(int idProducto, string nombre, string descripcion, decimal precioVentaActual, int stockMinimo, bool activo, int idCategoria)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioVentaActual = precioVentaActual;
            StockMinimo = stockMinimo;
            Activo = activo;
            IdCategoria = idCategoria;
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVentaActual { get; set; }
        public int StockMinimo { get; set; }
        public bool Activo { get; set; }
        public int IdCategoria { get; set; }
    }

}
