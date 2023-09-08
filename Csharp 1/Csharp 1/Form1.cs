using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            




            string saludito1 = "Saluditos " + txt_name.Text + ", maldita puta.";
            lbl_text.Text = saludito1;
            //practica "rapida"

            /*
             try
             {
                 string reception = ",Welcome to the training of c#";
                 string text1 = "Hello! " + txt_name.Text + reception;
                 lbl_text.Text = text1;
             }
             catch (Exception x)
             {
                 MessageBox.Show("Error en el tamaño del numero" + x);
             }
            */
            //Como hacer una bienvenida y como determinar el orden de las variables al ejecutarse de manera conjunta

            /*
            try
            {
                byte textodeltextbox = Convert.ToByte(txt_name.Text);
                lbl_text.Text = textodeltextbox.ToString();
            }
            catch (OverflowException x)
            //El tipo de error que puede haber
            {
                MessageBox.Show("Error en el tamaño del numero" + x);//La caja que muestra el error
            }
            catch (FormatException xx)
            {
                MessageBox.Show("Error en el formato:" + xx);
            }
            */
            //Como mostrar una caja de error

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
            {



            }

            private void lbl_text1(object sender, EventArgs e)
            {


            }
    }
}
