using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter Escritor = new StreamWriter("Test.txt");//creando el objeto para escribir mediante una secuencia de codigo
            Escritor.WriteLine("Hola mundo");
            Escritor.Close(); //es necesario para asegurarse de cerrar el archivo para evitar fallos

            StreamWriter AddText = File.AppendText("Test.txt");//"StreamWriter" sirve para poder agregar texto
            AddText.WriteLine("Nueva linea agregada");
            AddText.Close();
            

            MessageBox.Show("Listo");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader Lector = new StreamReader("Test.txt"); //esto es un objeto el cual sirve para poder leer una secuencia de codigo
            //MessageBox.Show(Lector.ReadLine());
            MessageBox.Show(Lector.ReadToEnd());


            Lector.Close();



        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            try
            {
                //El openfiledialog es un item invisible del forms que se puede usar para explorar en busca de archivos
                openFileDialog1.Title = "Busca tu archivo";//estableciendo el titulo de la ventana del openfiledialog
                openFileDialog1.ShowDialog(); //ejecutando el openfiledialog

                string TextOFD = openFileDialog1.FileName;// hago esto para poder guardar el nombre del archivo a utilizar en un string
                                                          // y asi en caso de reutilizar el nombre del archivo a usar que sea mas practico

                if (File.Exists(openFileDialog1.FileName))// aca lo que hago es que utilizo un control para verificar si un archivo existe
                                                          // y especifico los datos del archivo entre los parentesis
                                                          // especifico que el archivo sera el seleccionado en el openfiledialog y pongo un metodo para que use el nombre de ese archivo
                {
                    TextReader Lector = new StreamReader(TextOFD);
                    RTxtBox_1.Text = Lector.ReadToEnd(); //que no se me olvide usar el controlador text para acceder especificamente al texto del item
                    Lector.Close();
                }

                TxtBox_Direccion.Text = TextOFD;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abir el archivo");
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)//verifica ya se encontro un archivo (se activa al presionar aceptar)
                {
                    if (File.Exists(saveFileDialog1.FileName))//comprueba la existencia del archivo
                    {
                        string TxtFile = saveFileDialog1.FileName;

                        StreamWriter Guardador = File.CreateText(TxtFile);//creo un archivo de texto con el contenido del archivo de texto que estoy usando
                                                                          //
                        Guardador.Write(TxtFile);
                        Guardador.Flush();
                        Guardador.Close();

                    }
                    else
                    {
                        string TxtFile = saveFileDialog1.FileName;
                         
                        StreamWriter Guardador = File.CreateText(TxtFile);
                        Guardador.Write(TxtFile);
                        Guardador.Flush();
                        Guardador.Close();
                    }
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
