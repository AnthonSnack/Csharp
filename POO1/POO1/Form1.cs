using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos1;//con eso invocamos a la lista para usar sus propiedades y metodos



namespace POO1
{
    public partial class Form1 : Form
    {

        Cellfoun Movistar = new Cellfoun();//se creo el objeto dentro de este archivo
        //es como una palabra clave por la cual prodemos invocar a los objetos a traves de las clase especificada 
        Cellfoun Claro = new Cellfoun("samsung");//una forma de activar el segundo constructor, osea un argumento
        Cellfoun DatosDelCellfoun = new Cellfoun("Huawei", "Blanco", "Volador");

        

        Calculeadora OperacionBasica = new Calculeadora();
        

        List<string> MensajesDataBase = new List<string>();




        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MensajesDataBase.Add("Mensajes:");
            ListBox_ListBoxMensajes.DataSource = null; 
            ListBox_ListBoxMensajes.DataSource = MensajesDataBase;
        }

        private void Btn1_Llamar_Click(object sender, EventArgs e)
        {
            //Claro.Llamar();

            //estoy llamando al objeto sin inicializarlo antes pq estoy usando una formula estatica la cual no cmabiara
            //tambien puede ser aplicado a variables
        }

        private void Btn1_Sumar_Click(object sender, EventArgs e)
        {
            try 
            {
                int n1 = int.Parse(TxtBox1_Entrada1.Text);
                int n2 = int.Parse(TxtBox2_Entrada2.Text);
                string ResultadoSuma = OperacionBasica.Sumar(n1, n2).ToString();
                //MessageBox.Show("El resultado de la suma es: "+ ResultadoSuma);
                Lbl1_Resultado1.Text = "= " + ResultadoSuma;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
                return;
            }
        }

        private void Btn3_Info_Click(object sender, EventArgs e)
        {
            DatosDelCellfoun.MandarInfo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_EnviarMensaje_Click(object sender, EventArgs e)
        {
            var DatosMensajeIn = Movistar.EnviarYAlmacenarMensaje(TxtBox_MensajeIn.Text, TxtBox_AutorIn.Text);
            
            if (DatosMensajeIn.Item1 == 0 || string.IsNullOrEmpty(DatosMensajeIn.Item2) || string.IsNullOrEmpty(DatosMensajeIn.Item3))
            {
                MessageBox.Show("Inserte un texto valido");
            }
            else
            {
                MensajesDataBase.Add("-Mensaje"+ DatosMensajeIn.Item1.ToString() + " -Autor: " + DatosMensajeIn.Item3 + " -Mensaje: " + DatosMensajeIn.Item2);
            }
            
            ListBox_ListBoxMensajes.DataSource = null;
            ListBox_ListBoxMensajes.DataSource = MensajesDataBase;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                int indice = int.Parse(TxtBox_EntradaMensajeIndex.Text);
                if (indice is int)
                {
                    var DataAMostrar = MensajesDataBase[indice];

                    Lbl_ShowMensaje.Text = DataAMostrar;
                    return;
                }
                else;
                {
                    MessageBox.Show("Numero incorrecto o inexistente");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Numero Incorrecto o Inexistente");
                return;
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
