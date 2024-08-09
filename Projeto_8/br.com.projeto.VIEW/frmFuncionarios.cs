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

        private void dgconsulta_funcionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_cod.Text = dgconsulta_funcionario.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dgconsulta_funcionario.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_rg.Text = dgconsulta_funcionario.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_cpf.Text = dgconsulta_funcionario.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dgconsulta_funcionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgconsulta_funcionario.CurrentRow.Cells[5].Value.ToString();    
            cb_Cargo.Text = dgconsulta_funcionario.CurrentRow.Cells[6].Value.ToString();
            cb_Nivel.Text = dgconsulta_funcionario.CurrentRow.Cells[7].Value.ToString();
            maskedTextBox_telefone.Text = dgconsulta_funcionario.CurrentRow.Cells[8].Value.ToString();
            maskedTextBox_celular.Text = dgconsulta_funcionario.CurrentRow.Cells[9].Value.ToString();
            maskedTextBox_cep.Text = dgconsulta_funcionario.CurrentRow.Cells[10].Value.ToString();
            textBox_endereco.Text = dgconsulta_funcionario.CurrentRow.Cells[11].Value.ToString();
            textBox_num.Text = dgconsulta_funcionario.CurrentRow.Cells[12].Value.ToString();
            textBox_compl.Text = dgconsulta_funcionario.CurrentRow.Cells[13].Value.ToString();
            textBox_bairro.Text = dgconsulta_funcionario.CurrentRow.Cells[14].Value.ToString();
            textBox_cidade.Text = dgconsulta_funcionario.CurrentRow.Cells[15].Value.ToString();
            comboBox_uf.Text = dgconsulta_funcionario.CurrentRow.Cells[16].Value.ToString();

            // ALTERAR PARA GUIA DADOS PESSOAIS
            tab_funcionarios.SelectedTab = tabPage_dadospessoais;
        }

        private void button_editar_Click(object sender, EventArgs e)
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
            obj.Codigo = int.Parse(textBox_cod.Text);

            // 2º PASSO - CRIAR OBJETO E CHAMAR O METODO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            // 3º PASSO - RECARREGAR O DATAGRID
            dgconsulta_funcionario.DataSource = dao.listarFuncionario();
        }
    }
}
