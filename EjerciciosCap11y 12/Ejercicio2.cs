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
    public partial class Ejercicio2 : Form
    {
        byte[] arreglo;
        FileStream fs;
        public Ejercicio2()
        {
            InitializeComponent();
            arreglo = new byte[100];
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void Abrirbutton_Click(object sender, EventArgs e)
        {
            fs = new FileStream(@""+RutatextBox .Text +"\\"+NombretextBox.Text, FileMode.Open);
            fs.Read(arreglo, 0, (int)fs.Length);
            ArchivolistView.Items.Add(ASCIIEncoding.ASCII.GetString(arreglo));

            fs.Close();
        }
    }
}
