using Ejercicio1.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private void btnListar_Click(object sender, EventArgs e)
        {
            /*
            string path = "vehiculos.csv";

            string[] lineas = File.ReadAllLines(path);
            
            foreach (string linea in lineas)
            {
                string[] s = linea.Split(';');

                tbResultado.Text += s[0] + " " + s[1] + "\r\n";
            }*/

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string nombre = ofd.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(nombre, FileMode.Open, FileAccess.Read);

                    sr = new StreamReader(fs); //Flujo binario

                    sr.ReadLine(); //Saltea la linea 1 (patente;importe)
                    
                    while (!sr.EndOfStream)
                    {
                        string cadena = sr.ReadLine();

                        Vehiculo nuevoVehiculo = new Vehiculo();
                        nuevoVehiculo.Importar(cadena);

                        listaVehiculos.Sort();
                        int idx = listaVehiculos.BinarySearch(nuevoVehiculo);
                        if (idx > -1)
                        {
                            listaVehiculos[idx].Importe = nuevoVehiculo.Importe;
                        }
                        else
                        {
                            listaVehiculos.Add(nuevoVehiculo);
                        }

                    }

                    foreach (Vehiculo v in listaVehiculos)
                    {
                        tbResultado.Text += v.ToString();
                    }
                    

                }
                catch (PatenteException p)
                {
                    MessageBox.Show(p.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }


            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //Ventana q abre para descargar/guardar
            sfd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

            if(sfd.ShowDialog() == DialogResult.OK)
            {

                string nombre = sfd.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write); //Si esto ocurre.. abro el archivo
                    sw = new StreamWriter(fs); // Creamos adaptador para escribir 

                    sw.WriteLine("patente;importe");
                    foreach (Vehiculo v in listaVehiculos)
                    {
                        string cadena = v.Exportar();
                        sw.WriteLine(cadena);
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
