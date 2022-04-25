using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta4.Dominio.Validaciones
{
    /// <summary>
    /// Abstracción de un validador
    /// </summary>
    public interface IValidador
    {
        bool Validar();
    }
}
