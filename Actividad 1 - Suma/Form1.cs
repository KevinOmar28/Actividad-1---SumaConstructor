using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1___Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma osuma = new Suma(int.Parse(Valor1.Text), int.Parse(Valor2.Text));
            Resultado.Text = osuma.sumar().ToString();
        }
    }
}
