namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrodeclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultadeclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrofuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultafuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configuracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_trocarfuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt__data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_funcionarios,
            this.menu_fornecedores,
            this.menu_produtos,
            this.menu_configuracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_clientes
            // 
            this.menu_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrodeclientes,
            this.menu_consultadeclientes});
            this.menu_clientes.Image = global::Projeto_8.Properties.Resources.clientes1;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(77, 20);
            this.menu_clientes.Text = "Clientes";
            // 
            // menu_cadastrodeclientes
            // 
            this.menu_cadastrodeclientes.Name = "menu_cadastrodeclientes";
            this.menu_cadastrodeclientes.Size = new System.Drawing.Size(182, 22);
            this.menu_cadastrodeclientes.Text = "Cadastro de Clientes";
            // 
            // menu_consultadeclientes
            // 
            this.menu_consultadeclientes.Name = "menu_consultadeclientes";
            this.menu_consultadeclientes.Size = new System.Drawing.Size(182, 22);
            this.menu_consultadeclientes.Text = "Consulta de Clientes";
            // 
            // menu_funcionarios
            // 
            this.menu_funcionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrofuncionarios,
            this.menu_consultafuncionarios});
            this.menu_funcionarios.Image = global::Projeto_8.Properties.Resources.funcionarios1;
            this.menu_funcionarios.Name = "menu_funcionarios";
            this.menu_funcionarios.Size = new System.Drawing.Size(103, 20);
            this.menu_funcionarios.Text = "Funcionários";
            // 
            // menu_cadastrofuncionarios
            // 
            this.menu_cadastrofuncionarios.Name = "menu_cadastrofuncionarios";
            this.menu_cadastrofuncionarios.Size = new System.Drawing.Size(208, 22);
            this.menu_cadastrofuncionarios.Text = "Cadastro de Funcionários";
            // 
            // menu_consultafuncionarios
            // 
            this.menu_consultafuncionarios.Name = "menu_consultafuncionarios";
            this.menu_consultafuncionarios.Size = new System.Drawing.Size(208, 22);
            this.menu_consultafuncionarios.Text = "Consulta de Funcionários";
            // 
            // menu_fornecedores
            // 
            this.menu_fornecedores.Image = global::Projeto_8.Properties.Resources.fornecedores1;
            this.menu_fornecedores.Name = "menu_fornecedores";
            this.menu_fornecedores.Size = new System.Drawing.Size(106, 20);
            this.menu_fornecedores.Text = "Fornecedores";
            // 
            // menu_produtos
            // 
            this.menu_produtos.Image = global::Projeto_8.Properties.Resources.produtos1;
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(83, 20);
            this.menu_produtos.Text = "Produtos";
            // 
            // menu_configuracoes
            // 
            this.menu_configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_trocarfuncionario,
            this.menu_sair});
            this.menu_configuracoes.Image = global::Projeto_8.Properties.Resources.configurações1;
            this.menu_configuracoes.Name = "menu_configuracoes";
            this.menu_configuracoes.Size = new System.Drawing.Size(112, 20);
            this.menu_configuracoes.Text = "Configurações";
            // 
            // menu_trocarfuncionario
            // 
            this.menu_trocarfuncionario.Name = "menu_trocarfuncionario";
            this.menu_trocarfuncionario.Size = new System.Drawing.Size(180, 22);
            this.menu_trocarfuncionario.Text = "Trocar Usuário";
            // 
            // menu_sair
            // 
            this.menu_sair.Name = "menu_sair";
            this.menu_sair.Size = new System.Drawing.Size(180, 22);
            this.menu_sair.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt__data,
            this.toolStripStatusLabel3,
            this.txt_hora,
            this.toolStripStatusLabel5,
            this.txt_usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Data atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txt__data
            // 
            this.txt__data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt__data.Name = "txt__data";
            this.txt__data.Size = new System.Drawing.Size(73, 17);
            this.txt__data.Text = "12/08/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(38, 17);
            this.txt_hora.Text = "14:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(40, 17);
            this.txt_usuario.Text = "Cassio";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrodeclientes;
        private System.Windows.Forms.ToolStripMenuItem menu_consultadeclientes;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrofuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_consultafuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_fornecedores;
        private System.Windows.Forms.ToolStripMenuItem menu_produtos;
        private System.Windows.Forms.ToolStripMenuItem menu_configuracoes;
        private System.Windows.Forms.ToolStripMenuItem menu_trocarfuncionario;
        private System.Windows.Forms.ToolStripMenuItem menu_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt__data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txt_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel txt_usuario;
    }
}