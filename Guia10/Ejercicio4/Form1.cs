using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int hora = Convert.ToInt32(nudHora.Value);
            int minutos= Convert.ToInt32(nudMinuto.Value);
            int total = (hora*60)+minutos;
            lbMinutos.Text = total.ToString();
        }
    }
}
