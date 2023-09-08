using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informacion;

namespace POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona pepper = new Persona();

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Operaciones.Suma(250, 500).ToString());

            pepper.Pais1 = TxtBox_PaisIn.Text;
            MessageBox.Show(pepper.Pais1 + pepper.ID1);

            pepper.ID1 = "696969";

        }
    }
}
