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
    public partial class FormEjer4 : Form
    {
        public FormEjer4()
        {
            InitializeComponent();
        }

        private void btCrearBt_Click(object sender, EventArgs e)
        {
            btNuevo.Visible = true;

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
