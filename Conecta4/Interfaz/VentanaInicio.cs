using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conecta4.Interfaz
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            string colorJugador1;
            string colorJugador2;
            if(radioButtonAzul.Checked || radioButtonRojo.Checked)
            { 
                if(radioButtonRojo.Checked)
                {
                    colorJugador1 = radioButtonRojo.ForeColor.Name;
                    colorJugador2 = radioButtonAzul.ForeColor.Name;
                }
                else 
                {
                    colorJugador1 = radioButtonAzul.ForeColor.Name;
                    colorJugador2 = radioButtonRojo.ForeColor.Name;
                }
               
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(colorJugador1, colorJugador2);

                ventanaPrincipal.Show();
                ventanaPrincipal.FormClosed += FormClosed;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un color para poder jugar");
            }                
        }

        private void FormClosed(object sender, EventArgs e)
        {
            const string message = "Desea jugar de nuevo?";

            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                this.Close(); 
            }
        }

            
    }
}
