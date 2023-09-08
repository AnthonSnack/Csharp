using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Csharp5
{
    public partial class Form1 : Form
    {
        List<string> NameListData = new List<string>();


        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1ok_Click(object sender, EventArgs e)
        {
            string name;
            //lo que pasa aca es que el resultado del TxtBox1Names rebota para hacerse una variable
            //y luego rebota de ahi para añadirse a la NameList
            //la cual funciona de fuente para la ListBox1Names
            name = TxtBox_Names.Text;
            NameListData.Add(name);
            
            ListBox_Names.DataSource = null;
            ListBox_Names.DataSource = NameListData;

            //debo recordar ordenar mi codigo para que tenga mas sentido en mi cabeza

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            NameListData.Remove(TxtBox_Names.Text);

            ListBox_Names.DataSource = null;
            //esto de aca borra la lista NameListData anterior que se guardo en la ListBox_Names
            ListBox_Names.DataSource = NameListData;
            //y luego esto pone la lista osea NameListData actual
        }

        private void Btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                
                var index = NameListData.IndexOf(TxtBox_SelectToModify.Text);
                //"IndexOf" lo que hace es buscar el dato/objeto especificado y lo devuelve con su ubicacion, esto significa que el resultado de la "TxtBox_SelectToModify" sera el valor que defina "index"
                NameListData.RemoveAt(index);
                //NameListData.Remove(TxtBox_SelectToModify.Text);//mi manera de borrar el dato de la lista  
                NameListData.Insert(index, TxtBox_Names.Text);

                ListBox_Names.DataSource = null;
                ListBox_Names.DataSource = NameListData;


                
                switch (Btn_Modify)
                {
                    case TxtBox_Names.Text:

                    default: break;
                }



            }
            catch (Exception x)
            {
                MessageBox.Show("nombre inexistente");
            }

        }
    }
}
