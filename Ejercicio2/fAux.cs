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
    public partial class fAux : Form
    {
        public fAux()
        {
            InitializeComponent();
        }

        public fAux(int contador)
        {
            InitializeComponent();
            lbCuenta.Text = "El número de clicks es "+contador;
        }

        private void fAux_Load(object sender, EventArgs e)
        {

        }
    }
}
