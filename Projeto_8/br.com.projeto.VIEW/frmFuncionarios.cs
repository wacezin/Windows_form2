using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();
            // 1º PASSO - RECEBER OS DADOS
            obj.Nome = textBox_nome.Text;
            obj.RG = maskedTextBox_rg.Text.Replace(",", ".");
            obj.CPF = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.Email = textBox_email.Text;
            obj.Senha = txtSenha.Text;
            obj.Cargo = cb_Cargo.Text;
            obj.NivelAcesso = cb_Nivel.Text;
            obj.Telefone = maskedTextBox_telefone.Text;
            obj.Celular = maskedTextBox_celular.Text;
            obj.CEP = maskedTextBox_cep.Text;
            obj.Endereco = textBox_endereco.Text;
            obj.Numero = int.Parse(textBox_num.Text);
            obj.Complemento = textBox_compl.Text;
            obj.Bairro = textBox_bairro.Text;
            obj.Cidade = textBox_cidade.Text;
            obj.Estado = comboBox_uf.Text;

            // 2º PASSO - CRIAR OBJETO E CHAMAR O METODO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            dgconsulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dgconsulta_funcionario.DataSource = dao.listarFuncionario();
        }
    }
}
