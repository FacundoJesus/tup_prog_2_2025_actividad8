using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public interface IExportable
    {
        public void Importar(string cadena);
        public string Exportar();
    }
}
