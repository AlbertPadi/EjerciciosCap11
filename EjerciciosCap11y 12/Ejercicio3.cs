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
    public partial class Ejercicio3 : Form
    {
        byte[] arreglo;
        FileStream fs;
        public Ejercicio3()
        {
            InitializeComponent();
            arreglo = new byte[100];
        }

        private void RutatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copiarbutton_Click(object sender, EventArgs e)
        {
            string archivo = @""+NombretextBox.Text;
            string ruta = @""+RutatextBox.Text;
            string nruta = @"" +NuevaRutatextBox.Text;

            string narchivo = System.IO.Path.Combine(ruta, archivo);
            string destino = System.IO.Path.Combine(nruta, archivo);


            if (System.IO.Directory.Exists(ruta))
            {
                string[] files = System.IO.Directory.GetFiles(ruta);

                
                foreach (string s in files)
                {
                   
                    archivo = System.IO.Path.GetFileName(s);
                    ruta = System.IO.Path.Combine(nruta, archivo);
                    System.IO.File.Copy(s, destino, true);
                }
                }
            else
            {
                MessageBox.Show("No se pudo completar!");
            }
        }
    }
}
