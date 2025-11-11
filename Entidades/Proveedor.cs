using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        public Proveedor(int idProveedor, string nombre, string telefono, string correo, string direccion, string activo)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Activo = activo;
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Activo { get; set; }
    }
}
