using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;
using SistemaGestorPyME;
namespace Taller_Kike
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin ml;
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
            ml = new ManejadorLogin();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ml.validar(TxtUsuario, TxtClave))
            {
                MessageBox.Show($"Bienvenido al sistema {Sesion.Nombre}..");
                FrmMenu ag = new FrmMenu();
                ag.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de credenciales..");
                contador++;
                if (contador >= 2)
                {
                    MessageBox.Show(
                        "Sus credenciales se han bloquedado, espere 3 segundos");
                    TxtUsuario.Enabled = false;
                    TxtClave.Enabled = false;
                    Thread.Sleep(2000);//dormir el hilo primcpal
                    //Despues de cierto tiempo habilitarlos
                    MessageBox.Show("Ahora puede continuar...");
                    TxtUsuario.Enabled = true;
                    TxtClave.Enabled = true;
                    contador = 0;
                }
            }
        }
    }
}
