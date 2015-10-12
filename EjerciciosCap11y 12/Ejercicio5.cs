using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EjerciciosCap11y_12
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = NombretextBox.Text;
            string ruta = @"" + RutatextBox.Text;
            string nnombre = NuevoNtextBox.Text;

            File.Move(ruta+"/"+nombre+".txt", ruta+"/"+nnombre+".txt");
        }
    }
}
