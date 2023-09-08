using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp5
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int[] Vector1 = { 123, 456, 678, 90 };

            foreach (var number1 in Vector1) 
            //foreach esta recorriendo cada espacio del vector, ademas lo mide y le asigna un representante de variable
            {
                //MessageBox.Show(number1.ToString());

            }

            //ARRAYLIST

            ArrayList list1 = new ArrayList();  
            //arraylist es un tipo de arreglo no muy usado en el cual se pueden combinar distintos tipos de valores, ya sean integer, string, etc
            list1.Add(999);
            list1.Add("coca cola");
            list1.Add(6969);
            list1.Add("espuma");

            foreach (var fact in list1)
            {
                //MessageBox.Show(fact.ToString());

            }

            List<int> list2 = new List<int>();
            //como un arraylist pero tipado de manera fija con el tipo que elijamos de valor
            list2.Add(60);
            list2.Add(10);
            list2.Add(3 );

            foreach (var fact in list2)
            {
                //MessageBox.Show(fact.ToString());

            }

            //MessageBox.Show(list2[1].ToString());




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
