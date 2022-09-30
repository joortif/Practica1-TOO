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
    public partial class FormEjer2 : Form
    {
        private int contador = 0;
        public FormEjer2()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btContar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("El número de clicks es " + contador, "Contar clics");
            fAux formulario = new fAux(contador);
            formulario.Show(); //Modal, no es necesario cerrarlo para continuar
            //formulario.ShowDialog(); //No modal, debe cerrarse para continuar
            contador = 0;
           
        }

        private void btClicks_Click(object sender, EventArgs e)
        {
            contador++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
