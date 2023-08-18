using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpStrings1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void T3_TextChanged(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {
           



            T3.Text = T1.Text +T2.Text;


            
        }

        private void B2_Click(object sender, EventArgs e)
        {
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            LONGITUD.Text = "VALOR DE LONGITUD:";




        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            int caracteres = 0;
            caracteres = T3.Text.Length;

           LONGITUD.Text=caracteres.ToString();
        }
    }
}
