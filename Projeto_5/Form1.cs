using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form_calculadora : Form
    {
        public Form_calculadora()
        {
            InitializeComponent();
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja apagar? ", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                this.Close();
            }
            textBox_valor1.Text = string.Empty;
            textBox_valor2.Text = string.Empty;
        }

        private void button_soma_Click(object sender, EventArgs e)
        {
            double valor1, valor2, soma;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            soma = valor1 + valor2;
            label_resultado.Text = soma.ToString();
        }

        private void button_subtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, subtracao;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            subtracao = valor1 - valor2;
            label_resultado.Text = subtracao.ToString();
        }

        private void button_divisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, divisao;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse (textBox_valor2.Text);
            divisao = valor1 / valor2;
            label_resultado.Text = divisao.ToString();
        }

        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, multiplicacao;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            multiplicacao = valor1 * valor2;
            label_resultado.Text = multiplicacao.ToString();
        }
    }
}
