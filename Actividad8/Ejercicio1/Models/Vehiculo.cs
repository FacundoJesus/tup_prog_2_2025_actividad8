using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Vehiculo:IExportable,IComparable
    {
        public string Patente {  get; set; }

        private double importeAcumulado = 0;
        public double Importe { 
            get
            {
                return importeAcumulado;
            }
            set 
            {
                importeAcumulado += value;
            }
        }

        public Vehiculo() { }   

        public override string ToString() {
            return $"Patente: {Patente} - Importe:{Importe:c2}\r\n";
        }

        public void Importar(string cadena)
        {
            cadena = cadena.Trim();
            string[] splitResult = cadena.Split(';');
            string patente = splitResult[0];
            double importe = Convert.ToDouble(splitResult[1]);

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

        public int CompareTo(object obj)
        {
            Vehiculo nuevoVehiculo = obj as Vehiculo;
            if(nuevoVehiculo != null){
                return this.Patente.CompareTo(nuevoVehiculo.Patente);
            }
            return -1;
        }
    }
}
