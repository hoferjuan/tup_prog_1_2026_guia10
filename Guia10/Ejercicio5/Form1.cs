using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        int cantValores = 0, excelentes = 0, buenos = 0, insuficientes = 0;

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked || rbBueno.Checked || rbInsuficiente.Checked)
            {
                cantValores++;
                if (rbBueno.Checked)
                {
                    buenos++;
                    lbBuenos.Text = buenos.ToString();
                    rbBueno.Checked = false;
                }
                else
                {
                    if (rbExcelente.Checked)
                    {
                        excelentes++;
                        lbExcelentes.Text = excelentes.ToString();
                        rbExcelente.Checked = false;
                    }
                    else
                    {
                        insuficientes++;
                        lbInsuficientes.Text = insuficientes.ToString();
                        rbInsuficiente.Checked = false;
                    }
                }
                lbTotal.Text = cantValores.ToString();
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
