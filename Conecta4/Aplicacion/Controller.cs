using Conecta4.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Aplicacion
{
    /// <summary>
    /// Esta clase actúa como puente entre la interfaz grafica y el dominio para desacoplar 
    /// ambas partes del código
    /// </summary>
    public class Controller
    {
        public Juego juego { get; set; }

        public Controller(string colorJugador1, string colorJugador2)
        {
            juego = new Juego(colorJugador1, colorJugador2);
        }

        /// <summary>
        /// Método que recibe una columna donde el jugador quiere poner la ficha para hacer la jugada
        /// </summary>
        /// <param name="columna"></param>
        /// <returns></returns>
        public Casilla PonerColor(int columna)
        {
            return juego.HacerJugada(columna);
        }

        public bool SePuedeSeguirJugando()
        {
            return juego.EstaActivo();
        }
    }
}
