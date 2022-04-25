using Conecta4.Dominio.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio
{
    public class Casilla
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public string ValorColor { get; set; }

        public List<IValidador> Validadores { get; set; }

        public Casilla(int fila, int columna, List<IValidador> validadores)
        {
            Fila = fila;
            Columna = columna;
            ValorColor = "";
            Validadores = validadores;
        }

        /// <summary>
        /// Metodo que verifica si ya está pintada la casilla
        /// </summary>
        /// <returns></returns>
        public bool EstaOcupada()
        {
            return ValorColor != "";
        }

        /// <summary>
        /// Método que comprueba los validadores
        /// </summary>
        /// <returns></returns>
        public bool EsValida ()
        {
            if(EstaOcupada())
            {
                foreach(IValidadorDeCasillas validador in Validadores)
                {
                    validador.Casilla = this;
                    if(validador.Validar())
                        return true;
                }
                
            }
            return false;


        }
            
    }
}
