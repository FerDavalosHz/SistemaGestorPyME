using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorLogin
    {
        Base b = new Base("localhost", "root", "", "gestorpyme");

        public bool validar(TextBox usuario, TextBox clave)
        {
            DataTable dt = b.Consultar(
                $"CALL validar_usuario('{usuario.Text}', '{clave.Text}')",
                "usuarios"
            ).Tables[0];

            DataRow dr = dt.Rows[0];

            if (dr["rs"].ToString() == "Ac3ptad0")
            {
                Sesion.UsuarioNombre = dr["usuario"].ToString();
                Sesion.Nombre = dr["nombre"].ToString();
                Sesion.Rango = dr["rango"].ToString();
                Sesion.Activo = bool.Parse(dr["activo"].ToString());
                Sesion.id = Convert.ToInt32(dr["id_usuario"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}