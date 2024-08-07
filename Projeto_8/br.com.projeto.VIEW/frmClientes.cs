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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            // 1º PASSO - RECEBER OS DADOS
            obj.Nome = textBox_nome.Text;
            obj.RG = maskedTextBox_rg.Text.Replace(",", ".");
            obj.CPF = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.Email = textBox_email.Text;
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
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            dataGrid_consulta.DataSource = dao.listarCliente();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGrid_consulta.DataSource = dao.listarCliente();
        }

        private void dataGrid_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // PEGAR OS DADOS
            textBox_cod.Text = dataGrid_consulta.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dataGrid_consulta.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_rg.Text = dataGrid_consulta.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_cpf.Text = dataGrid_consulta.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGrid_consulta.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox_telefone.Text = dataGrid_consulta.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_celular.Text = dataGrid_consulta.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox_cep.Text = dataGrid_consulta.CurrentRow.Cells[7].Value.ToString();
            textBox_endereco.Text = dataGrid_consulta.CurrentRow.Cells[8].Value.ToString();
            textBox_num.Text = dataGrid_consulta.CurrentRow.Cells[9].Value.ToString();
            textBox_compl.Text = dataGrid_consulta.CurrentRow.Cells[10].Value.ToString();
            textBox_bairro.Text = dataGrid_consulta.CurrentRow.Cells[11].Value.ToString();
            textBox_cidade.Text = dataGrid_consulta.CurrentRow.Cells[12].Value.ToString();
            comboBox_uf.Text = dataGrid_consulta.CurrentRow.Cells[13].Value.ToString();

            // ALTERAR PARA GUIA DADOS PESSOAIS
            tabControl_clientes.SelectedTab = tabPage_dadospessoais;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            // 1º PASSO - RECEBER OS DADOS
            obj.Nome = textBox_nome.Text;
            obj.RG = maskedTextBox_rg.Text.Replace(",", ".");
            obj.CPF = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.Email = textBox_email.Text;
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
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            // 3º PASSO - RECARREGAR O DATAGRID
            dataGrid_consulta.DataSource = dao.listarCliente();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            // 1º PASSO - RECEBER OS DADOS
            obj.Codigo = int.Parse(textBox_cod.Text);
            

            // 2º PASSO - CRIAR OBJETO E CHAMAR O METODO
            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            // 3º PASSO - RECARREGAR O DATAGRID
            dataGrid_consulta.DataSource = dao.listarCliente();
            tabControl_clientes.SelectedTab = tabPage_consulta;
        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void button_pesquisarConsulta_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomeConsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            dataGrid_consulta.DataSource = dao.BuscarClientPorNome(nome);

            if(dataGrid_consulta.Rows.Count == 0)
            {
                dataGrid_consulta.DataSource = dao.listarCliente();
            }
        }

        private void textBox_nomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + textBox_nomeConsulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dataGrid_consulta.DataSource = dao.BuscarClienteListando(nome);
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {



                string cep = maskedTextBox_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                
                dados.ReadXml(xml);

                textBox_endereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                textBox_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                textBox_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                textBox_compl.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                comboBox_uf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor verifique.");
            }
        }
        }
    }
    
