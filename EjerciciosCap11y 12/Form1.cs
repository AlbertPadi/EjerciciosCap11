using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCap11y_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 eje1 = new Ejercicio1();
            eje1.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 ej3 = new Ejercicio3();
            ej3.Show();


        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4 ej4 = new Ejercicio4();
            ej4.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5 ej5 = new Ejercicio5();
            ej5.Show();
        }
    }
}
