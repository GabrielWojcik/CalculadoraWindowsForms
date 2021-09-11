using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            float num01, num02, resultado;
            num01 = float.Parse(campoNumero01.Text);
            num02 = float.Parse(campoNumero02.Text);
            resultado = num01 + num02;
            campoResultado.Text = resultado.ToString();
        }
    }
}
