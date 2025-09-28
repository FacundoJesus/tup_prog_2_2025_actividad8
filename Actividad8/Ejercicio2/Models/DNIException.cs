using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class DNIException:ApplicationException
    {
        public DNIException():base("DNI NO VÁLIDO") { }
        public DNIException(string message):base(message) { }
        public DNIException(string msg, Exception innerException) : base(msg, innerException) { }
    }
}
