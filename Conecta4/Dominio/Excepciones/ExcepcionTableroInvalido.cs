using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Excepciones
{
    public class ExcepcionTableroInvalido: Exception
    {
        public ExcepcionTableroInvalido(string message) : base(message) { }
       
    }
    
}
