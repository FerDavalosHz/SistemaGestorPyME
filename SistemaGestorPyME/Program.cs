using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorPyME
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmHistorialAlertas());
=======
            Application.Run(new FrmInventario());
>>>>>>> Agregue el FrmInventario y lo acomode para que al compilar se viera bien, aún falta que me digan si así lo dejo porque hay cosas que no me convencen. Tambien le di doble click a todos los botones tanto de este forms como el de Historial alerta y el de login.
        }
    }
}
