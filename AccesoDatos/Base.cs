using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Base
    {

        MySqlConnection conn;
        public Base(string servidor, string usuario, string password, string bd)
        {
            conn = new MySqlConnection($"server={servidor}; user ={usuario}; password={password}; database={bd};");
        }

        public void Comando(string Cadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Cadena, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                conn.Close();
                if (ex.Number == 1451)
                {
                    MessageBox.Show("No se puede eliminar este registro porque está relacionado con un registro, intente cancelar o eliminar el registro con el que esta ligado primero.", "Error de restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object ComandoEscalar(string Cadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Cadena, conn);
                conn.Open();
                object resultado = cmd.ExecuteScalar();
                conn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        }

        public DataSet Consultar(string consulta, string tabla)
        {

            DataSet ds = new DataSet();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);
                conn.Open();
                da.Fill(ds, tabla);
                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return ds;




        }


    }
}
