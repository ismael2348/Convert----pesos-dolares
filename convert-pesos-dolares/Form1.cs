using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            cambio cambio = new cambio();
                if (cambio.validar(pesos.Text, valordolar.Text.Trim())&& pesos.Text != "0" && valordolar.Text != "0")
            {

                dolares.Text = Convert.ToString(cambio.pesosdolar(pesos.Text, valordolar.Text.Trim()));

            }
            else {
                MessageBox.Show("No valido!");
            
            }



        }
    }
}
