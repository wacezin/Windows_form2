using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            // CONFIRMAR
            if(textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome: ");
                textBox_nome.Focus();
            }
            if(comboBox_destino.Text == "") {
                MessageBox.Show("Destino não selecionado: ");
                comboBox_destino.Focus();
            }
            if(radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Selecione um meio de transporte: ");
                radioButton_aviao.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 170);
            groupBox2.Visible = false;
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            // LIMPAR
            // textBox_nome.Text = ""
            textBox_nome.Clear();
            // comboBox_destino.Text = ""
            comboBox_destino.Text = string.Empty;
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            date_data.Value = DateTime.Now;
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            // CALCULAR
            double gasto_destino, gasto_transp, gasto_total;

            // DESTINO
            switch (comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }

            // MEIO DE TRANSPORTE
            if(radioButton_aviao.Checked == true) 
            {
                gasto_transp = 100;
            }
            else
            {
                gasto_transp = 30;
            }

            // CALCULO VALOR TOTAL
            gasto_total = gasto_destino + gasto_transp;

            // REDIMENSIONAMENTO
            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox2.Visible = true;

            // EXIBIR
            label_gasto_dest.Text = gasto_destino.ToString("C2");
            label_gasto_transp.Text = gasto_transp.ToString("C2");
            label_total.Text = gasto_total.ToString("C2");
            // C2 = O PONTO NO MILHAR E O R$
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
            {
                this.Close();
            }
        }
    }
}
