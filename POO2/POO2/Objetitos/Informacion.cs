using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informacion
{
    public class Operaciones
    {
        public static int Nomber1 = 50;
        //al poner "static" estoy dando a entender que estan variable va a tener una valor estatico
        //el cual no podra ser cambiado
        public int Nomber2 = 100;

        public static int Suma (int n1, int n2)
        {
            return n1 + n2;
        }
    }
    public class Persona
    {
        private string Nombre;
        private string Pais;
        private string ID;
        
        //esto que que hace es establecer una variable la cual pueda devolver otras funciones mas alla del valor asignado
        //e incluso funcionar a base de otras variables
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        //public int ID1 { get => ID; set => ID = value; }
        //public string Pais1 { get => Pais; set => Pais = value; }

        public string Pais1
        { //esto lo que hace es que al regresar el valor, antes de este se le va a sumar un texto
            get { return "Yo resido en: " +  Pais; }
            set { Pais = value;  }//value es el valor que se ingresara cuando se use la variable
                                  //la verdad da igual sino la usas, a menos que sea para que funcione en conjunto con otra variable
        }

        public string ID1 { set { } get { return ", Y mi numero de identidad es: " + ID; } }

    }
}
