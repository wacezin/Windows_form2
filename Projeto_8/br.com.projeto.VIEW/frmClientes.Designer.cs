namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_clientes = new System.Windows.Forms.TabControl();
            this.tabPage_dadospessoais = new System.Windows.Forms.TabPage();
            this.comboBox_uf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBox_cep = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.maskedTextBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_rg = new System.Windows.Forms.MaskedTextBox();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_compl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_bairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_endereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_consulta = new System.Windows.Forms.TabPage();
            this.dataGrid_consulta = new System.Windows.Forms.DataGridView();
            this.button_pesquisarConsulta = new System.Windows.Forms.Button();
            this.textBox_nomeConsulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_novo = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl_clientes.SuspendLayout();
            this.tabPage_dadospessoais.SuspendLayout();
            this.tabPage_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabControl_clientes
            // 
            this.tabControl_clientes.Controls.Add(this.tabPage_dadospessoais);
            this.tabControl_clientes.Controls.Add(this.tabPage_consulta);
            this.tabControl_clientes.Location = new System.Drawing.Point(30, 121);
            this.tabControl_clientes.Name = "tabControl_clientes";
            this.tabControl_clientes.SelectedIndex = 0;
            this.tabControl_clientes.Size = new System.Drawing.Size(518, 308);
            this.tabControl_clientes.TabIndex = 1;
            // 
            // tabPage_dadospessoais
            // 
            this.tabPage_dadospessoais.Controls.Add(this.comboBox_uf);
            this.tabPage_dadospessoais.Controls.Add(this.label15);
            this.tabPage_dadospessoais.Controls.Add(this.maskedTextBox_cep);
            this.tabPage_dadospessoais.Controls.Add(this.label14);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_cidade);
            this.tabPage_dadospessoais.Controls.Add(this.maskedTextBox_celular);
            this.tabPage_dadospessoais.Controls.Add(this.maskedTextBox_telefone);
            this.tabPage_dadospessoais.Controls.Add(this.maskedTextBox_cpf);
            this.tabPage_dadospessoais.Controls.Add(this.maskedTextBox_rg);
            this.tabPage_dadospessoais.Controls.Add(this.button_pesquisar);
            this.tabPage_dadospessoais.Controls.Add(this.label13);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_compl);
            this.tabPage_dadospessoais.Controls.Add(this.label12);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_bairro);
            this.tabPage_dadospessoais.Controls.Add(this.label11);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_num);
            this.tabPage_dadospessoais.Controls.Add(this.label10);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_endereco);
            this.tabPage_dadospessoais.Controls.Add(this.label9);
            this.tabPage_dadospessoais.Controls.Add(this.label8);
            this.tabPage_dadospessoais.Controls.Add(this.label7);
            this.tabPage_dadospessoais.Controls.Add(this.label6);
            this.tabPage_dadospessoais.Controls.Add(this.label5);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_email);
            this.tabPage_dadospessoais.Controls.Add(this.label4);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_nome);
            this.tabPage_dadospessoais.Controls.Add(this.label3);
            this.tabPage_dadospessoais.Controls.Add(this.textBox_cod);
            this.tabPage_dadospessoais.Controls.Add(this.label2);
            this.tabPage_dadospessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPage_dadospessoais.Name = "tabPage_dadospessoais";
            this.tabPage_dadospessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dadospessoais.Size = new System.Drawing.Size(510, 282);
            this.tabPage_dadospessoais.TabIndex = 0;
            this.tabPage_dadospessoais.Text = "Dados Pessoais";
            this.tabPage_dadospessoais.UseVisualStyleBackColor = true;
            // 
            // comboBox_uf
            // 
            this.comboBox_uf.FormattingEnabled = true;
            this.comboBox_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox_uf.Location = new System.Drawing.Point(91, 248);
            this.comboBox_uf.Name = "comboBox_uf";
            this.comboBox_uf.Size = new System.Drawing.Size(173, 21);
            this.comboBox_uf.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "UF:";
            // 
            // maskedTextBox_cep
            // 
            this.maskedTextBox_cep.Location = new System.Drawing.Point(91, 219);
            this.maskedTextBox_cep.Mask = "99999-999";
            this.maskedTextBox_cep.Name = "maskedTextBox_cep";
            this.maskedTextBox_cep.Size = new System.Drawing.Size(173, 20);
            this.maskedTextBox_cep.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "CEP";
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.Location = new System.Drawing.Point(333, 193);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(157, 20);
            this.textBox_cidade.TabIndex = 28;
            // 
            // maskedTextBox_celular
            // 
            this.maskedTextBox_celular.Location = new System.Drawing.Point(333, 118);
            this.maskedTextBox_celular.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_celular.Name = "maskedTextBox_celular";
            this.maskedTextBox_celular.Size = new System.Drawing.Size(157, 20);
            this.maskedTextBox_celular.TabIndex = 27;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(91, 120);
            this.maskedTextBox_telefone.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBox_telefone.TabIndex = 26;
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(319, 94);
            this.maskedTextBox_cpf.Mask = "999,999,999-99";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBox_cpf.TabIndex = 25;
            // 
            // maskedTextBox_rg
            // 
            this.maskedTextBox_rg.Location = new System.Drawing.Point(91, 94);
            this.maskedTextBox_rg.Mask = "99,999,999-9";
            this.maskedTextBox_rg.Name = "maskedTextBox_rg";
            this.maskedTextBox_rg.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBox_rg.TabIndex = 24;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pesquisar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.White;
            this.button_pesquisar.Location = new System.Drawing.Point(333, 219);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(157, 30);
            this.button_pesquisar.TabIndex = 6;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(269, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Cidade:";
            // 
            // textBox_compl
            // 
            this.textBox_compl.Location = new System.Drawing.Point(91, 193);
            this.textBox_compl.Name = "textBox_compl";
            this.textBox_compl.Size = new System.Drawing.Size(173, 20);
            this.textBox_compl.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Compl:";
            // 
            // textBox_bairro
            // 
            this.textBox_bairro.Location = new System.Drawing.Point(302, 167);
            this.textBox_bairro.Name = "textBox_bairro";
            this.textBox_bairro.Size = new System.Drawing.Size(188, 20);
            this.textBox_bairro.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bairro:";
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(56, 167);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(173, 20);
            this.textBox_num.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nº:";
            // 
            // textBox_endereco
            // 
            this.textBox_endereco.Location = new System.Drawing.Point(103, 144);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(387, 20);
            this.textBox_endereco.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "RG:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(91, 68);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(399, 20);
            this.textBox_email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(91, 42);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(399, 20);
            this.textBox_nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // textBox_cod
            // 
            this.textBox_cod.Location = new System.Drawing.Point(91, 16);
            this.textBox_cod.Name = "textBox_cod";
            this.textBox_cod.Size = new System.Drawing.Size(100, 20);
            this.textBox_cod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage_consulta
            // 
            this.tabPage_consulta.Controls.Add(this.dataGrid_consulta);
            this.tabPage_consulta.Controls.Add(this.button_pesquisarConsulta);
            this.tabPage_consulta.Controls.Add(this.textBox_nomeConsulta);
            this.tabPage_consulta.Controls.Add(this.label16);
            this.tabPage_consulta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consulta.Name = "tabPage_consulta";
            this.tabPage_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consulta.Size = new System.Drawing.Size(510, 282);
            this.tabPage_consulta.TabIndex = 1;
            this.tabPage_consulta.Text = "Consulta";
            this.tabPage_consulta.UseVisualStyleBackColor = true;
            // 
            // dataGrid_consulta
            // 
            this.dataGrid_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_consulta.Location = new System.Drawing.Point(14, 52);
            this.dataGrid_consulta.Name = "dataGrid_consulta";
            this.dataGrid_consulta.Size = new System.Drawing.Size(478, 213);
            this.dataGrid_consulta.TabIndex = 8;
            this.dataGrid_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_consulta_CellClick);
            // 
            // button_pesquisarConsulta
            // 
            this.button_pesquisarConsulta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pesquisarConsulta.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisarConsulta.ForeColor = System.Drawing.Color.White;
            this.button_pesquisarConsulta.Location = new System.Drawing.Point(350, 11);
            this.button_pesquisarConsulta.Name = "button_pesquisarConsulta";
            this.button_pesquisarConsulta.Size = new System.Drawing.Size(142, 30);
            this.button_pesquisarConsulta.TabIndex = 7;
            this.button_pesquisarConsulta.Text = "Pesquisar";
            this.button_pesquisarConsulta.UseVisualStyleBackColor = false;
            this.button_pesquisarConsulta.Click += new System.EventHandler(this.button_pesquisarConsulta_Click);
            // 
            // textBox_nomeConsulta
            // 
            this.textBox_nomeConsulta.Location = new System.Drawing.Point(82, 16);
            this.textBox_nomeConsulta.Name = "textBox_nomeConsulta";
            this.textBox_nomeConsulta.Size = new System.Drawing.Size(257, 20);
            this.textBox_nomeConsulta.TabIndex = 6;
            this.textBox_nomeConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeConsulta_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nome:";
            // 
            // button_novo
            // 
            this.button_novo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_novo.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.ForeColor = System.Drawing.Color.White;
            this.button_novo.Location = new System.Drawing.Point(57, 435);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(94, 45);
            this.button_novo.TabIndex = 2;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = false;
            this.button_novo.Click += new System.EventHandler(this.button_novo_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_salvar.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(177, 435);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(96, 45);
            this.button_salvar.TabIndex = 3;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_excluir.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.White;
            this.button_excluir.Location = new System.Drawing.Point(304, 435);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(96, 45);
            this.button_excluir.TabIndex = 4;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_editar.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.ForeColor = System.Drawing.Color.White;
            this.button_editar.Location = new System.Drawing.Point(430, 435);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(96, 45);
            this.button_editar.TabIndex = 5;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 492);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.tabControl_clientes);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_clientes.ResumeLayout(false);
            this.tabPage_dadospessoais.ResumeLayout(false);
            this.tabPage_dadospessoais.PerformLayout();
            this.tabPage_consulta.ResumeLayout(false);
            this.tabPage_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_clientes;
        private System.Windows.Forms.TabPage tabPage_dadospessoais;
        private System.Windows.Forms.TabPage tabPage_consulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cod;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_bairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_compl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_endereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_celular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_rg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_uf;
        private System.Windows.Forms.DataGridView dataGrid_consulta;
        private System.Windows.Forms.Button button_pesquisarConsulta;
        private System.Windows.Forms.TextBox textBox_nomeConsulta;
        private System.Windows.Forms.Label label16;
    }
}