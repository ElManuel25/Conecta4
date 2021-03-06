using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Implementa el Validador para hacer las validaciones de casilla
    /// </summary>
    public abstract class IValidadorDeCasillas: IValidador
    {   
        public Tablero Tablero { get; set; }
        public Casilla Casilla { get; set; }
        public abstract bool Validar();

        public IValidadorDeCasillas(Tablero tablero)
        {
            Tablero = tablero;
        }
    }
}
