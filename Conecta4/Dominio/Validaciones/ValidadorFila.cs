using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Validador que verifica si se ganó con un 4 en línea en una fila
    /// </summary>
    public class ValidadorFila: IValidadorDeCasillas
    {
        public ValidadorFila(Tablero tablero) : base(tablero)
        {
        }

        public override bool Validar()
        {
            

            {
                int contadorCeldasSeguidas = 0;
                if (Tablero.NumeroColumnas - Casilla.Columna <= (Tablero.CeldasEnLinea - 1))
                    return false;
                for (int i = Casilla.Columna; i < Tablero.NumeroColumnas; i++)
                {
                    if (Tablero.Casillas[Casilla.Fila, i].ValorColor == Casilla.ValorColor)
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
}
