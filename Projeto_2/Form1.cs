using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Fomr_Saudacao : Form
    {
        public Fomr_Saudacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exibir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Olá {textBox_nome.Text}");
            string nome = textBox_nome.Text;
            MessageBox.Show($"Olá {nome}", "Título da Resposta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
