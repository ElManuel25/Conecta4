using Conecta4.Aplicacion;
using Conecta4.Dominio;
using Conecta4.Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conecta4
{
    public partial class VentanaPrincipal : Form
    {
        Controller Controller { get; set; }
        public VentanaPrincipal(string colorJugador1, string colorJugador2)
        {
            InitializeComponent();
            InicializarTablero(6, 7);

            Controller = new Controller(colorJugador1, colorJugador2);

        }

        private void InicializarTablero(int filas, int columnas)
        {
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Button boton = new Button
                    {
                        Dock = DockStyle.Fill
                    };
                    boton.Click += ClickFila;
                    boton.Name = "Boton_" + columna+ "_" + fila;
                    tableLayoutPanelTablero.Controls.Add(boton, columna, fila);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private Button EncontrarBoton(int columna, int fila)
        {

            return (Button)tableLayoutPanelTablero.Controls.Find("Boton_" + fila + "_" + columna, true)[0];

        }
        private void splitContainerInstruccionesEInfo_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickFila(object sender, EventArgs e)
        {
            
            Button boton = (Button) sender;    
            string columnaSeleccionada = boton.Name.Split('_')[1];
            try
            {
                Casilla casillaElegida = Controller.PonerColor(Int16.Parse( columnaSeleccionada));
                Button botonElegido = EncontrarBoton(casillaElegida.Fila, casillaElegida.Columna);
                botonElegido.BackColor = Color.FromName(casillaElegida.ValorColor);
                botonElegido.Enabled = false;
                if (!Controller.SePuedeSeguirJugando())
                {
                    MessageBox.Show("No se puede seguir jugando");
                }
                
            }
            catch (ExcepcionTableroGanado exTableroGanado)
            {
                MostrarDialogoJugarDeNuevo(exTableroGanado.Message);
            }
            catch (ExcepcionTableroInvalido exTableroInvalido)
            {
                MostrarDialogoJugarDeNuevo(exTableroInvalido.Message);
            }
           
        }
        private void MostrarDialogoJugarDeNuevo(string mensaje)
        {
            var result = MessageBox.Show(mensaje);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

      
    }

}
