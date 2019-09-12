using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtValor1.Text);      // (textValor1.Text) tem que ter o .Text se não ele tenta converter todo o objeto.
            decimal y = Convert.ToDecimal(txtValor2.Text);

            decimal soma = x + y;
            decimal subtração = x - y;
            decimal multiplicação = x * y;
            //decimal divisão = x / y;
            // decimal resto = x % y;

            txtSoma.Text = Convert.ToString(soma);
            txtSubtração.Text = Convert.ToString(subtração);
            txtMult.Text = Convert.ToString(multiplicação);

            if (y != 0)
            {
                decimal divisão = x / y;
                decimal resto = x % y;
                txtDiv.Text = divisão.ToString("0.00");
                txtRes.Text = Convert.ToString(resto);
            }
            else
            {
                txtRes.Text = txtDiv.Text = "É impossivel dividir por 0";
            }
            // Exemplo Idade
            int idade = Convert.ToInt32(txtValor1.Text);
            string sexo = txtValor2.Text;

            if (sexo == "Feminino")
            {
                MessageBox.Show("Não é obrigatório certificado de reservista");
            }
            else if (idade >= 18)
            {
                MessageBox.Show("É obrigatório o certificado de reservista");
            }
            else
            {
                MessageBox.Show("Menos de 18 anos não precisam de certificado de reservista");
            }
            if (sexo == "Masculino" && idade >= 18)
            {
                MessageBox.Show("Obrigatório");
            }
            else
            {
                MessageBox.Show("Não é obrigatório");
            }

        }
    }
}
