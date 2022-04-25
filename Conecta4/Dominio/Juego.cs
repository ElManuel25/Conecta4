using Conecta4.Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio
{
    /// <summary>
    /// Esta clase contiene al juego y posee un tablero que puede variar
    /// </summary>
    public class Juego
    {
        public Tablero Tablero { get; set; }
        /// <summary>
        /// Referencia al jugador que debe realizar el movimiento en un momento en concreto en la ejecución
        /// </summary>
        public string jugadorActual { get; set; }

        public static bool juegoTerminado = false;
        public string ColorJugador1 { get; set; }
        public string ColorJugador2 { get; set; }
        


        public Juego()
        {
            this.Tablero = new Tablero4EnLinea();
            this.Tablero.CrearTablero();


        }

        public Juego(string colorJugador1, string colorJugador2): this()
        {
            ColorJugador1 = colorJugador1;
            ColorJugador2 = colorJugador2;
            jugadorActual = ColorJugador1;
        }
        
        /// <summary>
        /// Método para saber si todavia se continúa jugando despues de cada jugada
        /// Pueede parar si alguién ganó o si se llenó el tablero sin ganador
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExcepcionTableroGanado"></exception>
        /// <exception cref="ExcepcionTableroInvalido"></exception>
        public bool EstaActivo()
        {
            if (this.Tablero.HayGanador())
            {
                juegoTerminado = true;
                throw new ExcepcionTableroGanado(jugadorActual);                               
            }
            ///En cada jugada se verifica si el tablero está lleno y se para el juego si lo está          
            else
            {
                if (!this.Tablero.EsValido())
                {
                    juegoTerminado = false;
                    throw new ExcepcionTableroInvalido("Juego terminado. No hubo ganador");
                    
                }

            }
            jugadorActual = JugadorQueSigue();
            return true;
            
        }




        /// <summary>
        /// Metodo para definir el jugador que debe hacer el siguiente movimiento
        /// </summary>
        /// <returns>El jugador siguiente</returns>
        public string JugadorQueSigue()
        {
            if (jugadorActual == ColorJugador1)
                return ColorJugador2;
            else
                return ColorJugador1;
        }

        /// <summary>
        /// Método en donde está la lógica de cada uno de los movimientos
        /// </summary>
        public Casilla HacerJugada(int columnaElegida)
        {
       
            try
            {
                ///La ficha se coloca en la columna recibida si se cumplen las validaciones
                ///de la clase tablero
                Casilla casillaAsignada = this.Tablero.ColocarFichas(columnaElegida, jugadorActual);
               
                /////En cada jugada se verifica si hay ganador y se termina el juego si lo hay                               
                return casillaAsignada;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);
                throw ex;
            }
           

        }
    }
}
