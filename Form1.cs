using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezCadenasTexto
{
    public partial class frmCadenasTexto : Form
    {
        string TextoA;
        string TextoB;
        public frmCadenasTexto()
        {
            InitializeComponent();
        }

        private void txtTextoA_TextChanged(object sender, EventArgs e)
        {
            TextoA = txtTextoA.Text;
            lblCantidadA.Text=TextoA.Length.ToString();

        }

        private void txtTextoB_TextChanged(object sender, EventArgs e)
        {
            TextoB=txtTextoB.Text;
            lblCantidadB.Text = TextoB.Length.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            TextoA = txtTextoA.Text;
            TextoB = txtTextoB.Text;

            int resultado= string.Compare(TextoA, TextoB);
            if (resultado== 0)
            {
                MessageBox.Show("Las dos cadenas tienen la misma cantidad de caracteres");
            }
            else
            {
                if (resultado<0)
                {
                    MessageBox.Show("La cadena B tiene mayor cantidad de caracteres");
                }
                else
                {
                    if (resultado>0)
                    {
                        MessageBox.Show("La cadena A tiene mayor cantidad de caracteres");
                    }
                }
            }
        }

        private void btnConveritr_Click(object sender, EventArgs e)
        {
            TextoA = txtTextoA.Text;
            string stringB = "";
            stringB = TextoA.Replace(TextoA, txtTextoB.Text);
            txtTextoA.Text=stringB;
            txtTextoB.Clear();
        }
    }
}
