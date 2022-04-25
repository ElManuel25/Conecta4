using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Validador que verifica si el tableroi ya está lleno y no se puede seguir jugando
    /// </summary>
    public class ValidadorTableroLleno: IValidadorDeTablero
    {
        public ValidadorTableroLleno(Tablero tablero) : base(tablero)
        {
        }

        public override bool Validar()
        {
            for (int i = 0; i < Tablero.NumeroFilas; i++)
            {

                for (int j = 0; j < Tablero.NumeroColumnas; j++)
                {
                    if (Tablero.Casillas[i, j].EstaOcupada()) 
                        return true;
                }
            }
            return false;
        }
    }
}
