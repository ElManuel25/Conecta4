using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Validador que verifica si se ganó con un 4 en línea en una diagonal
    /// </summary>
    public class ValidadorDiagonalesDerechas: IValidadorDeCasillas
    {
        public ValidadorDiagonalesDerechas(Tablero tablero) : base(tablero)
        {
        }

        int CeldasRecorridas { get; set; }

        private int ContarCeldasDiagonalesDerechas(Casilla casilla, string valorAComparar)
        {
            if (CeldasRecorridas >= 4)
                return 0;
            else
                CeldasRecorridas++;
            if (casilla.ValorColor == valorAComparar)
                /// Llamado recursivo de la función con la celda que esta abajo a la derecha
                return 1 + ContarCeldasDiagonalesDerechas(Tablero.Casillas[casilla.Fila -1, casilla.Columna + 1], valorAComparar);
            return 0;
        }

        public override bool Validar()
        {
            this.CeldasRecorridas = 0;
            ///Se restringen las celdas para analizar las diagonales a la izquierda
            ///En un tablero de 7 columnas por 6 filas solamente las celdas que se encuentran
            ///entre las filas 3, 4, 5 (empezando desde abajo) y las columnas 0, 1, 2, 3 tienen la
            ///posibilidad de formar 4 celdas iguales seguidas
            if (Casilla.Columna <= 3  && Casilla.Fila >= 3)

                if (ContarCeldasDiagonalesDerechas(Casilla, Casilla.ValorColor) == Tablero.CeldasEnLinea)
                    return true;
            return false;
        }
    }
}
