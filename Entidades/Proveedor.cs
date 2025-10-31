using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        public Proveedor(int idProveedor, string nombre, string contacto, string telefono, string correo, string direccion, bool activo)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Activo = activo;
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
