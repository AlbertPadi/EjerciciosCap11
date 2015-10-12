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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Eliminarbutton_Click(object sender, EventArgs ex)
        {


            if (System.IO.File.Exists(@"" + RutatextBox.Text))
            {

                try
                {
                    System.IO.File.Delete(@"" + RutatextBox.Text);
                }
                catch (System.IO.IOException e)
                {
                    MessageBox.Show("Seguro?: "+e.Message);
                    return;
                }
            }
        }
    }
}
