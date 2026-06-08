using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            tbInvitaciones.Text = tbInvitaciones.Text + "\r\n" + tbNombre.Text;
            tbNombre.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
