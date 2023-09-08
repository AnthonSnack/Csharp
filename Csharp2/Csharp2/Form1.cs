using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2
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

        private void btn_ok1_Click(object sender, EventArgs e) //evento del boton ok1
        {
            string var_user = txt_user.Text;
            string var_password = txt_password.Text;

            switch (var_user)//Parecido al "if" pero diferente
            {
                case "Pepe":
                    MessageBox.Show("Escribiste Pepe, puedes pasar ");

                    switch (var_password)//un switch anidado que se activa despues de pasar otro como si fuera un filtro, como los "if", pero procura proporcionar bien donde pones los "break"
                    {
                        case "1234":
                            MessageBox.Show("Correcto");
                            break;

                        default:
                            MessageBox.Show("Contraseña incorrecta");
                            break;
                    }
                    break;

                case "Pili":
                    MessageBox.Show("Eres Pili, adelante");

                    switch (var_password)
                    {
                        case "4321":
                            MessageBox.Show("Correcto");
                            break;

                        default:
                            MessageBox.Show("Contraseña incorrecta");
                            break;
                    }
                    break;

                default:
                    MessageBox.Show("Opcion invalida");
                    break;
            }

            /*
            try
            {
                if (var_user == "Pepe")
                {
                    MessageBox.Show("Right name.");
                    if (Convert.ToInt32(var_password) < 99)
                    {
                        MessageBox.Show("Your number is minor than 100");
                    }
                    else if (Convert.ToInt32(var_password) > 101)
                    {
                        MessageBox.Show("Your number is bigger than 100");
                    }
                    else
                    {
                        MessageBox.Show("Your number is 100, welcome");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong name, try again.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error:: " + x);
            }
            */

            /*
            try
            {
                if (var_user == "Pepe")
                {
                    MessageBox.Show("Right name.");
                    if (Convert.ToInt32(var_password) + 50 == 100)//lo que pasa aca es que el resultado del var_password va a ser convertido a un valor int32 y luego se va a sumar con un "+ 50", si hace que el resultado sea 100 entonces Pepe accedera
                    {
                        MessageBox.Show("Right password, welcome " + var_user + ".");
                    }
                    else
                    {
                        MessageBox.Show("Wrong password, try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong name, try again.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error:: " + x);
            }
            */


            /*
            try
            {
                if (var_user != "Pepe" || Convert.ToInt32(var_password) >= 100) //sirve para ejecutarse en caso que se cumplan sus condiciones
                //el segundo "=" es para que en vez de asignar a "Pepe" con la variable "txt_user", pregunte/vea/verifique si en ese textbox dice pepe
                //"!=" es el opuesto a "==" 
                //"&" es literalmente "y"
                //"||" es literalmente "o"
                {
                    MessageBox.Show("Right!, you can enter");
                }
                else //sino en cambio puede ocurrir esto
                {
                    MessageBox.Show("Nu uh, try again");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error::" + x);
            }
                */










        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
