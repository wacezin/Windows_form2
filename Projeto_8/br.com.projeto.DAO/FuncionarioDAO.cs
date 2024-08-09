using MySql.Data.MySqlClient;
using Projeto_8.br.com.projeto.CONEXAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.DAO
{
    internal class FuncionarioDAO
    {
        #region Conexão
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarFuncionario(Funcionarios obj)
        {
            try
            {
                // 1º PASSO - DEFINIR COMANDO SQL
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                     VALUES(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2º PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.RG);
                executarcmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@senha", obj.Senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executarcmd.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.CEP);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);

                // 3º PASSO - ABRIR CONEXAO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Cadastrado com Sucesso :D");

                // 4º PASSO - FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }
        #endregion

        #region Listar
        public DataTable listarFuncionario()
        {
            try
            {
                // 1º PASSO - ISNTANCIAR O DATATABLE
                DataTable tabelaFuncionario = new DataTable();

                // 2º PASSO - DEFINIR COMANDO SQL
                string sql = @"SELECT * FROM tb_funcionarios";

                // 3º PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                // 4º PASSO - ABRIR CONEXAO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                // 5º PASSO - PREENCHEMOS OS DADOS DO DATATABLE
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaFuncionario);

                // 6º PASSO - FECHAR CONEXAO
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
                return null;
            }
        }
        #endregion

        #region Alterar
        public void alterarFuncionario(Funcionarios obj)
        {
            try
            {
                // 1º PASSO - DEFINIR COMANDO SQL
                string sql = @"UPDATE tb_funcionarios SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, 
               telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero,
               complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id=@id";

                // 2º PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.RG);
                executarcmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@senha", obj.Senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executarcmd.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.CEP);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);
                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);

                // 3º PASSO - ABRIR CONEXAO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Alterado com Sucesso :D");

                // 4º PASSO - FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }
        #endregion

        #region Excluir
        public void excluirFuncionario(Funcionarios obj)
        {
            try
            {
                // 1º PASSO - DEFINIR COMANDO SQL
                string sql = @"DELETE FROM tb_funcionarios WHERE id=@id";

                // 2º PASSO - ORGANIZAR O COMANDO SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);

                // 3º PASSO - ABRIR CONEXAO E EXECUTAR O COMANDO SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Excluido com Sucesso :D");

                // 4º PASSO - FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }
        #endregion
    }
}
