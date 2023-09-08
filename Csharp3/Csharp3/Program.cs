using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string varx = "";
            int x = 0;
            /*
            while (x < 10)//mientras se cumplan las condiciones del "while" seguira haciendo una y otra vez el codigo sin detenerse hasta que deje de cumplir la condicion
            {
                varx += x.ToString() + "-";

                 
                x++;
            }
            */

            do//en cambio este hace directamente la operacion aunque sea una vez siempre y cuando se cumpla la condicion
            {
                varx += x.ToString() + "-";


                x++;
            } while (x <10);

            MessageBox.Show(varx.ToString());




            /*
            string varx = "";//asi se saca el integer de for como texto
            for (int i = 0; i < 10; i++)
            {
                varx += i.ToString();//por aca sale el valor del "integer" del "for"

                if (i == 5)//con esto se detiene al for antes de tiempo si se cumple la condicion
                {
                    continue;//aca se puede terminar el proceso con "break", y con ello los procesos posteriores al "if", pero si se usa "continue" va a continuar con el proceso de nuevo pero terminando en "if" e ignorando los procesos posteriores a este al volver a comenzar
                }
                varx += "-";//el "+=" es para que registre el valor en la variable pero sin reemplazarla, sino que la suma
            }
            MessageBox.Show(varx);
            */



            /*
            int varx = 0;//para sacar el valor del integer del for hay que sacar el valor por otra variable
            for (int i = 0; i < 10; i++)
            {
                int varx = i;
                MessageBox.Show(i.ToString());
            }
            MessageBox.Show(varx.ToString());
            */




            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
