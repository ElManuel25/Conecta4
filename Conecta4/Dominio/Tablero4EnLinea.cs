using Conecta4.Dominio.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio
{
    /// <summary>
    /// Subclase de Tablero para crear especificamente un tablero para un 4 en línea
    /// </summary>
    public class Tablero4EnLinea : Tablero
    {
        public Tablero4EnLinea(): base(7, 6)
        {
            this.CeldasEnLinea = 4;
            
        }
        public Tablero4EnLinea(int numeroColumnas, int numeroFilas) : base(numeroColumnas, numeroFilas) 
        {
            this.CeldasEnLinea = 4;
            

        }
      
        public override void AsignarValidadores()
        {
            Validadores = new List<IValidador>();
            ValidadoresCasilla = new List<IValidador>();
            ValidadoresCasilla.Add(new ValidadorColumna(this));
            ValidadoresCasilla.Add(new ValidadorFila(this));
            ValidadoresCasilla.Add(new ValidadorDiagonalesDerechas(this));
            ValidadoresCasilla.Add(new ValidadorDiagonalesIzquierdas(this));
            Validadores.Add(new ValidadorTableroLleno(this));
        }
    }
}
