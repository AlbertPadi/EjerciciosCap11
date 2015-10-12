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
    public partial class Ejercicio1 : Form
    {
        MemoryStream ms;
        byte[] arreglo;
        public Ejercicio1()
        {
            InitializeComponent();

            ms = new MemoryStream(50);
            arreglo = new byte[50];
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            ms.Write(ASCIIEncoding.ASCII.GetBytes(CadenatextBox.Text), 0, CadenatextBox.Text.Length);

            ms.Seek(-10, SeekOrigin.End);
            ms.Read(arreglo, 0, CadenatextBox.TextLength);
            CadenalistView.Items.Add(ASCIIEncoding.ASCII.GetString(arreglo));
 
        }
    }
}