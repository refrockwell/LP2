using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc_19_09_25
{
    public partial class Form1 : Form

   
    {
        double numero1, numero2, resultado; //globais

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(txtNumero2, "");
                numero2 = Convert.ToDouble(txtNumero2.Text);
            }
            catch {
                errorProvider2.SetError(txtNumero2, "Número Inválido");
                txtNumero2.Focus();
            }   
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString("G");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString("G");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString("G");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (numero2 != 0) {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString("G");
            }
            else
            {
                MessageBox.Show("O número precisa ser maior que 0");
                txtNumero2.Focus();
                txtNumero2.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair ?",
                            "Saída", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)==
                                DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse( txtNumero1.Text, out numero1))
                {
                errorProvider1.SetError(txtNumero1, "Número 1 é inválido !");
            }
            else
                errorProvider1.SetError(txtNumero1, "");
        }
    }
}
