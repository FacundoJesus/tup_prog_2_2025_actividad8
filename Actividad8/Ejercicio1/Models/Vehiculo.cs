using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Vehiculo:IExportable
    {
        public string Patente {  get; set; }
        public double Importe { get; set; }

        public Vehiculo() { }   

        public override string ToString() {
            return $"Patente: {Patente} - Importe:{Importe:c2}\r\n";
        }

        public void Importar(string cadena)
        {
            cadena = cadena.Trim();
            string[] separator = cadena.Split(';');
            string patente = separator[0];
            double importe = Convert.ToDouble(separator[1]);

            if (patente.Length == 6 || patente.Length == 7)
            {
                this.Patente = patente;
            }
            else
            {
                throw new PatenteException();
            }
            this.Importe = importe;
        }

        public string Exportar()
        {
            return $"{Patente};{Importe}";
        }
    }
}
