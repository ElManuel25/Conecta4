using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Excepciones
{
    public class ExcepcionTableroGanado: Exception
    {
        public string Jugador { get; set; }

        public ExcepcionTableroGanado(string jugador) :base("El tablero ha sido ganado por: "+ jugador)
        {
            Jugador = jugador;
        }
    }
}
