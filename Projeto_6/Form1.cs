using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_6
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa> ();

            comboBox_estadocivil.Items.Add("Casado");
            comboBox_estadocivil.Items.Add("Solteiro");
            comboBox_estadocivil.Items.Add("Viúvo");
            comboBox_estadocivil.Items.Add("Divorciado");

            comboBox_estadocivil.SelectedIndex = 0;

            //DATA GRID VIEW
            dataGridView_exibir.Columns.Add("Nome", "Nome");
            dataGridView_exibir.Columns.Add("DataNascimento", "Data de Nascimento");
            dataGridView_exibir.Columns.Add("EstadoCivil", "Estado Civil");
            dataGridView_exibir.Columns.Add("Telefone", "Telefone");
            dataGridView_exibir.Columns.Add("CasaPropria", "Casa Propria");
            dataGridView_exibir.Columns.Add("Veiculo", "Veiculo");
            dataGridView_exibir.Columns.Add("Sexo", "Sexo");
        }

        private void comboBox_estadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            int index = -1; // VERIFICA SE O USUARIO JA ESTA CADASTRADO

            // VERIFICA SE OS NOMES SÃO IGUAIS (NOME É NOSSO PARAMETRO)
            foreach(Pessoa cadastro in pessoas)
            {
                if(cadastro.Nome == textBox_nome.Text)
                {
                    index = pessoas.IndexOf(cadastro);
                }
            }

            // VEREFICA SE OS CAMPOS FORAM PREENCHIDOS 
            if(textBox_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome! ", "Caixa mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Focus();
                return;
            }

            if(maskedTextBox_tel.Text == "(  )       -")
            {
                MessageBox.Show("Preencha o campo telefone", "Caixa mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox_tel.Focus();
                return;
            }

            char sexo; // CHAR SÓ FUNCIONA COM AS ASPAS SIMPLES
            if(radioButton_sexoMasc.Checked)
            {
                sexo = 'M';
            }else if(radioButton_sexoFem.Checked)
            {
                sexo = 'F';
            }else
            {
                sexo = 'O';
            }

            // ATRIBUIR VALORES
            Pessoa valores = new Pessoa();
            valores.Nome = textBox_nome.Text;
            valores.DataNasc = date_data.Text;
            valores.EstadoCivil = comboBox_estadocivil.SelectedItem.ToString(); // POR SER COMBOBOX A FORMA DE SELECIONAR É DIFERENTE
            valores.Telefone = maskedTextBox_tel.Text;
            valores.CasaPropria = checkBox_casa.Checked; // CHECKBOX NAO RECEBE STRING APENAS VERDADEIRO E FALSO OU SEJA BOOL
            valores.Veiculo = checkBox_veiculo.Checked;
            valores.Sexo = sexo; // COMO FOI FEITO O CHAR EM CIMA PRECISA SUBSTITUIR O TIPO DA VARIAVEL NA CLASSE TAMBEM :)

            // VERIFICA SE JÁ ESTÁ CADASTRADO
            if(index < 0) // SE ELE FOR MENOR QUE ZERO SIGNIFICA QUE NAO TEM NINGUEM CADASTRADO AINDA
            {
                pessoas.Add(valores);
            }
            else
            {
                pessoas[index] = valores; // ARRAY É USADO ESSA CHAVE
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);
            Listar();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            // int indice = listBox_lista.SelectedIndex; // TODOS OS INDICES SAO GUARDADOS NA VARIAVEL PESSOAS
            int indice = dataGridView_exibir.CurrentCell.RowIndex;
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = "";
            date_data.Value = DateTime.Now;
            comboBox_estadocivil.SelectedIndex = 0;
            maskedTextBox_tel.Text = "";
            checkBox_casa.Checked = false;
            checkBox_veiculo.Checked = false;
            radioButton_sexoMasc.Checked = false;
            radioButton_sexoFem.Checked = false;
            radioButton_outros.Checked = false;
            textBox_nome.Focus();
        }

        private void Listar()
        {
            //listBox_lista.Items.Clear(); // LIMPA OS DADOS
            dataGridView_exibir.Rows.Clear();
            foreach (Pessoa p in pessoas) // ESTAMOS PEGANDO A CLASSE, CRIANDO UMA VARIAVEL PARA RECEBER TODOS OS DADOS 
            {
                //listBox_lista.Items.Add(p.ToString()); // RESULTADO DO OVERRIDE QUE ESTÁ NA CLASSE
                dataGridView_exibir.Rows.Add(p.Nome, p.DataNasc, p.EstadoCivil, p.Telefone, p.CasaPropria ? "SIM" : "NÃO", p.Veiculo ? "SIM" : "NÃO", p.Sexo) ;
                // ROWS = LINHAS
                // ? = SE
                // : = SE NÃO
            }
        }

        private void listBox_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ALTERAR
            int indice = listBox_lista.SelectedIndex;
            Pessoa p = pessoas[indice];
            textBox_nome.Text = p.Nome;
            date_data.Text = p.DataNasc;
            comboBox_estadocivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_tel.Text = p.Telefone;
            checkBox_casa.Checked = p.CasaPropria;
            checkBox_veiculo.Checked = p.Veiculo;

            switch(p.Sexo)
            {
                case 'M':
                    radioButton_sexoMasc.Checked = true;
                    break;
                case 'F':
                    radioButton_sexoFem.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }


        }

        private void dataGridView_exibir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Pessoa p = pessoas[indice];
            textBox_nome.Text = p.Nome;
            date_data.Text = p.DataNasc;
            comboBox_estadocivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_tel.Text = p.Telefone;
            checkBox_casa.Checked = p.CasaPropria;
            checkBox_veiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioButton_sexoMasc.Checked = true;
                    break;
                case 'F':
                    radioButton_sexoFem.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }

      
    }
}
