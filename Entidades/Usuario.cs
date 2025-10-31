using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public Usuario(int idUsuario, string nombre, string usuarioNombre, string contrasena, int idRol, bool activo)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            UsuarioNombre = usuarioNombre;
            Contrasena = contrasena;
            IdRol = idRol;
            Activo = activo;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }
    }
}
