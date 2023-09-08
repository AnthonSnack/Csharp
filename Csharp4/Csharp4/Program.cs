using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //VECTORES

            /*
            int num = 0;
            int[] numbers = new int[5];//esto ultimo es el indice
            //puede almacenar muchas variables y acceder a ellas mediante un indice el cual tambien puede tener un limite establecido
            numbers[0] = 12345;
            numbers[1] = 54321;
            numbers[2] = 666;
            numbers[3] = 777;
            numbers[4] = 1312;

            MessageBox.Show(numbers.Length.ToString());//recordar pasar esto a tostring para que pase de un valor integer a texto

            for (int n1 = 0; n1 < numbers.Length; n1++)//length es para representar el tamaño del vector
            {
                n1 =
                MessageBox.Show(numbers[n1].ToString());//con esto podemos hacer que recorra el vector y su contenido
                
            }
            */

            /*
            string[] text1 = new string[5];
            text1[0] = "hola";
            text1[1] = "estoy aprendiendo a programar";
            text1[2] = "equis d";
            text1[3] = "puto el que lo lea";
            text1[4] = "xau";

            for (int o = 0; o < text1.Length; o++)
            {
                MessageBox.Show(text1[o].ToString());
            }

            string[] text2 = new string[10];

            for (int u = 0; u < text2.Length; u++)
            {
                text2[u] = "Los numeros son: " + u.ToString();
            }

            for (int u = 0; u < text2.Length; u++)
            {
                MessageBox.Show(text2[u].ToString());
            }
            */

            //MATRICES

            /*
            int[,] morenumbers = new int[3, 5];
            //la matriz es similar al vector solo que esta no es lineal, sino que puede buscar la variante asignada en un espacio de filas y cloumnas como en excel
            morenumbers[0,0] = 11;
            morenumbers[0,1] = 12;
            morenumbers[0,2] = 13;
            morenumbers[0,3] = 14;
            morenumbers[0,4] = 15;

            for (int n2 = 0; n2 < 5; n2++)
            {
                MessageBox.Show(morenumbers[0,n2].ToString());
            }
            */

            int[,] numberfilling2 = new int[5, 5];

            for (int filas = 0;  filas < numberfilling2.GetLength(0); filas++)
            {

                for (int columnas = 0; columnas < numberfilling2.GetLength(1); columnas++)
                {
                    numberfilling2[filas,columnas] = 100 * (filas + 1)*(columnas + 2);

                    MessageBox.Show("Ubicacion de matriz: " + filas + "," + columnas + " Valor: " + numberfilling2[filas, columnas].ToString() + ".");

                }
            }



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
