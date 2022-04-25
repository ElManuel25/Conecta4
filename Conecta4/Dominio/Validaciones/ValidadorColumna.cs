using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Validador que verifica si se ganó con un 4 en línea en una columna
    /// </summary>
    public class ValidadorColumna: IValidadorDeCasillas
    {
        public ValidadorColumna(Tablero tablero) : base(tablero)
        {
        }

        public override bool Validar()
        {

            int contadorCeldasSeguidas = 0;
            if (Tablero.NumeroFilas - Casilla.Fila <= (Tablero.CeldasEnLinea - 1))
                return false;
            for (int i = Casilla.Fila; i < Tablero.NumeroFilas; i++)
            {
                if (Tablero.Casillas[i, Casilla.Columna].ValorColor == Casilla.ValorColor)
                    contadorCeldasSeguidas++;
                else
                    return false;
                if (contadorCeldasSeguidas == 4)
                    return true;
            }
            return false;

        }
    }
}
