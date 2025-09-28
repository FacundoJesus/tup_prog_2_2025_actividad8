using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Persona:IComparable,IExportable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni {  get; set; }

        private double deuda = 0;
        public double Deuda { 
            get
            {
                return deuda;
            }
            set 
            {
                deuda += value;
            }
        }

        public Persona() { }

        public int CompareTo(object obj)
        {
            Persona nuevaPersona = obj as Persona;
            if (nuevaPersona != null) {
                return this.Dni.CompareTo(nuevaPersona.Dni);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} DNI: {this.Dni} - Deuda: {this.Deuda:c2} ";
        }

        public void Importar(string linea)
        {
            linea.Trim();
            string[] splitResult = linea.Split(';');
            
            string nombre = splitResult[0];
            string apellido = splitResult[1];
            string dni = splitResult[2];
            string deuda = splitResult[3];

            this.Nombre = nombre;
            this.Apellido = apellido;
            if (dni.Length < 1 || dni.Length > 8)
            {
                throw new DNIException();
            }
            this.Dni = Convert.ToInt32(dni);
            this.Deuda = Convert.ToInt32(deuda);
        }

        public string Exportar()
        {
            return $"{this.Nombre};{this.Apellido};{this.Dni};{this.Deuda}";
        }

    }
}
