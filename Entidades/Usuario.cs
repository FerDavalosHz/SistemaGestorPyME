using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Entidades
    {
        public class Usuario
        {
            public Usuario(int idUsuario, string nombre, string usuarioNombre,
                           string contrasena, bool activo, string rango)
            {
                IdUsuario = idUsuario;
                Nombre = nombre;
                UsuarioNombre = usuarioNombre;
                Contrasena = contrasena;
                Activo = activo;
                Rango = rango;
            }

            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string UsuarioNombre { get; set; }
            public string Contrasena { get; set; }
            public bool Activo { get; set; }
            public string Rango { get; set; }
        }
    }


