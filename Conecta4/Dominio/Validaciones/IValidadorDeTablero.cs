using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Implementa el Validador para hacer las validaciones de tablero
    /// </summary>
    public abstract class IValidadorDeTablero: IValidador
    {
        public Tablero Tablero { get; set; }
        public abstract bool Validar();
        
        public IValidadorDeTablero(Tablero tablero)
        {
            this.Tablero = tablero;
        }
    }
}
