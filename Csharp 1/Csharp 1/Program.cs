using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 






        [STAThread]
        static void Main()
        {

            //Variables y tipos de datos

            string nombre = "Eduardo"; //tipo de texto

            int num1 = 450; //entero 
            uint num2 = 500; //entero solo positivo
            float num3 = 35.5f; //flotante
            double num4 = 45.50; //decimales
            decimal num5 = 7488892.29380202m; //numero mucho mas grande
            byte num6 = 255; //solo llega a 255

            bool acceso = true; //false



            DateTime fecha = DateTime.Today; //fecha

            int num7, num8, num9, num10;
            num7 = 12; num8 = 15; num9 = 18; num9 = 121; num10 = 124;

            const string dato = "puto el que lo lea";
            //dato = "ya no soy eduardo";



            MessageBox.Show(dato);

            string pene = "hola mundo";


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //ejecuta el form principal
        }
    }
}
