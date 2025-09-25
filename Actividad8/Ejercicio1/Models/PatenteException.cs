using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatenteException:ApplicationException
    {
        public PatenteException():base("Patente Inválida") { }

        public PatenteException(string message):base(message) { }

        public PatenteException(string msg, Exception innerException) : base(msg, innerException) { }
    }
}
