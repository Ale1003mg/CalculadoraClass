using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)//Salir
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//Suma
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                SClass Suma = new SClass();
                Suma.obtener(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Suma.suma();
                textBox3.Text= String.Concat(Suma.Datos());
            }
            else {
                textBox3.Text = "Los campos esta vacios";
            }
        }

        private void button6_Click(object sender, EventArgs e)//Limpiar
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//Resta
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                SClass Resta = new SClass();
                Resta.obtener(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Resta.Resta();
                textBox3.Text = String.Concat(Resta.Datos());
            }
            else
            {
                textBox3.Text = "Los campos esta vacios";
            }
        }

        private void button3_Click(object sender, EventArgs e)//Multiplicacion
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                SClass Multi = new SClass();
                Multi.obtener(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Multi.Multi();
                textBox3.Text = String.Concat(Multi.Datos());
            }
            else
            {
                textBox3.Text = "Los campos esta vacios";
            }
        }

        private void button4_Click(object sender, EventArgs e)//Division
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                SClass Divi = new SClass();
                Divi.obtener(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Divi.Division();
                textBox3.Text = String.Concat(Divi.Datos());
            }
            else
            {
                textBox3.Text = "Los campos esta vacios";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)//cerrar
        {
            Close();
        }
    }
}
