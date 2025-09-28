using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> listPersonas = new List<Persona>();

        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = null;
                StreamReader sr = null;
                string nombre = ofd.FileName;
                try
                {
                    fs = new FileStream(nombre, FileMode.Open, FileAccess.Read);//Acceder al archivo
                    sr = new StreamReader(fs); //Leer el archivo

                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();

                        Persona nuevaPersona = new Persona();
                        nuevaPersona.Importar(linea);
                        listPersonas.Sort();
                        int idx = listPersonas.BinarySearch(nuevaPersona);
                        if (idx > -1)
                        {
                            listPersonas[idx].Deuda = nuevaPersona.Deuda;
                        }
                        else
                        {
                            listPersonas.Add(nuevaPersona);
                        }

                        ActualizarLista();

                    }
                }
                catch (DNIException dniExcep)
                {
                    MessageBox.Show(dniExcep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

            if(sfd.ShowDialog()==DialogResult.OK) {

                FileStream fs = null;
                StreamWriter sw = null;
                string nombre = sfd.FileName;

                try
                {
                    fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("nombre;apellido;dni;deuda");
                    foreach(Persona p in listPersonas)
                    {
                        string linea = p.Exportar();
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close(); //Cierro 1º el StreamWriter
                    if (fs != null) fs.Close(); //Cierro el 
                }

            }
        }

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Persona p in listPersonas)
            {
                listBox1.Items.Add(p);
            }

        }
    }
}
