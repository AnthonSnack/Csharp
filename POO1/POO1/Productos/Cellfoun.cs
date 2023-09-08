using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos1//el espacio donde habitaran las clases del objeto
{

    public class Cellfoun//la esturctura de la clase
    {//donde albergan las propiedades(valores que se usaran y manejaran en los metodos)
     //y metodos(funciones hechas a base de codigo el cual puede ser reutilizado llamando al metodo de la clase) 
        private string Marca = "Samsung";
        private string Color;
        private string Tipo;



        public Cellfoun() //es un metodo el cual se debe llamar igual a la lista y es el primero en ejecutarse
        {
            Marca = "Apol";
            Color = "red";
            Tipo = "martillo";
        }

        public Cellfoun(string M)//se puede poner diferentes constructores de clases que puedan ser ejecutador al usarse un argumento como este
        {
            Marca = M;
            Color = "red";
            Tipo = "martillo";
        }
        public Cellfoun(string M, string C, string T)
        {
            Marca = M;
            Color = C;
            Tipo = T;
        }

        public void Llamar()//metodos, osea funciones hechas a base de codigo que puede ser reutilizado metodo
        {//a travez de la clase

            System.Windows.Forms.MessageBox.Show("Hola a todos! "+ Marca);
        }
        public void MandarInfo()
        {
            System.Windows.Forms.MessageBox.Show("La informacion del dispositivo es: "+ Marca+ ", "+ Color+ ", "+ Tipo);
        }

        public int Indice = 1;
        public (int,string,string)EnviarYAlmacenarMensaje(string MensajeIn, string AutorIn)
        {//Los primeros parentesis son lo que devolvera el metodo, y lo segundo son los datos que entraran

            string MensajeData1 = MensajeIn;
            string AutorData1 = AutorIn;
            //manera mas eficiente de leer si el valor indicado entre parentesis y mandado esta vacio o nulo
            if (string.IsNullOrEmpty(MensajeData1) || string.IsNullOrEmpty(AutorData1))
            {
                //MessageBox.Show("Inserte un texto valido");
                return (0, string.Empty, string.Empty);
            }
            else
            {
                int IndiceOut = Indice;
                Indice++;//con esto hago que crezca el valor "indice" el cual hara que el numero de los indices se vaya definiendo
                         //y tenga una salida cuyo resultado usare para mostrar el indice
                return (IndiceOut, MensajeData1, AutorData1);//asi se hace que el metodo devuelva valores los cuales seran usados a posteriori
            }
        }
        public string LeerMensaje(string MensajeIn, string AutorIn)
        {
            string Mensaje = MensajeIn;
            string Autor = AutorIn;
            


            string FinalMandarMensaje = "El mensaje es: " + Mensaje + ", Enviado por: " + Autor;
            return FinalMandarMensaje;
        }

    }
    public class Calculeadora
    {
        public int Sumar(int a, int b)
        {       //esto de "int" antes de "Sumar"; es para que "Sumar" devuelva un valor al final de cumplir su codigo
                //para definir cual va a ser el valor que se le va a asignar a "Sumar" 
                //se escribe "return" mas el valor como se muestra a continuacion

            int resultadoint = a + b;
            string resultadostr = resultadoint.ToString();

            //System.Windows.Forms.MessageBox.Show("El resultado de la suma es: "+ resultadostr);
            return resultadoint;
        }
    }
}
