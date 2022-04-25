using Conecta4.Dominio.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio
{
    /// <summary>
    /// Esta clase contiene el tablero que es un arreglo bidimensional y los metodos que lo controlan
    /// </summary>
    public class Tablero
    {

        public int NumeroColumnas { get; set; }
        public int NumeroFilas { get; set; }
      
        public Casilla[,] Casillas { get; set; } 
        /// <summary>
        /// En un 4 en línea las celdas en línea para ganar son 4
        /// </summary>
        public int CeldasEnLinea { get; set; }

        public List<IValidador> Validadores { get; set; }
        public List<IValidador> ValidadoresCasilla { get; set; }

        public Tablero(int numeroColumnas, int numeroFilas)
        {
            NumeroColumnas = numeroColumnas;
            NumeroFilas = numeroFilas;
            Casillas = new Casilla[NumeroFilas, NumeroColumnas];
        }

        /// <summary>
        /// Toma los validadores y los añade a una lista para comprobarlos uno por uno después
        /// </summary>
        public virtual void AsignarValidadores()
        {
            Validadores = new List<IValidador>();
            ValidadoresCasilla = new List<IValidador>();
        }

        /// <summary>
        /// Método que crea un arreglo de casillas tomando como fila 0 la mas abajo y le asigna los 
        /// validadores a cada casilla
        /// </summary>                                                                           
        public  void CrearTablero()
        {
            AsignarValidadores();
            for (int fila = NumeroFilas -1 ; fila >= 0; fila--)
            {

                for (int columna = 0; columna < NumeroColumnas; columna++)
                {
                    Casillas[fila, columna] = new Casilla(fila, columna, ValidadoresCasilla);
                }
            }
            
        }

        
        


        /// <summary>
        /// Metodo para saber si en la fila de la columna seleccionada
        /// se puede poner una ficha o si está llena.
        /// </summary>
        /// <param name="columna"></param>
        /// <returns>El numero de la fila, -1 si está llena</returns>
        public int ObtenerFilaDisponible(int columna)
        {
            for (int fila = NumeroFilas - 1; fila >= 0; fila--)
            {
                if (!Casillas[fila, columna].EstaOcupada())
                    return fila;
            }
            return -1;
        }

        /// <summary>
        ///  /// Método para colocar las fichas (A para amarillo, R para rojo)
        /// </summary>
        /// <param name="columna">Columna en la que se quiere soltar la ficha</param>
        /// <param name="letraFicha">'R' o 'A'</param>
        /// <exception cref="Exception"></exception>
        public Casilla ColocarFichas(int columna, string color)

        {
            if (columna >= 0 && columna <= NumeroColumnas) /// Comprueba si la columna indicada por el ususario está en el rango.
            {
                int filaParaColocarFicha = ObtenerFilaDisponible(columna);

                if (filaParaColocarFicha == -1) /// Si la fila está llena tira una excepción y vuelve a pedir por una columna.
                    throw new Exception("Fila no disponible");
                else
                {
                    Casillas[filaParaColocarFicha, columna].ValorColor = color; /// Coloca la ficha en el espacio señalado.
                }
                return Casillas[filaParaColocarFicha, columna];

            }
            else
                throw new Exception("Columna fuera de rango"); /// Lanza una expeción si la columna no está en rango.

        }

       
       

        

        
        /// <summary>
        /// Método para verifficar si hay ganador.
        /// Primero valida la columna, luego la fila, luego las diagonales.
        /// Si no hay ganador, continúa el juego.
        /// </summary>
        /// <returns>True si hay ganador, False si no lo hay</returns>
        public bool HayGanador()

        {
            for (int i = 0; i < NumeroFilas; i++)
            {

                for (int j = 0; j < NumeroColumnas; j++)
                {
                    if (Casillas[i, j].EstaOcupada())
                    {
                        if(Casillas[i, j].EsValida())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool EsValido()
        {     
            foreach (IValidadorDeTablero validador in Validadores)
            {
                validador.Tablero = this;
                if (!validador.Validar())
                    return false;
            }
            return true;
        }

    }
}
