namespace Projeto_6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_casa = new System.Windows.Forms.CheckBox();
            this.comboBox_estadocivil = new System.Windows.Forms.ComboBox();
            this.checkBox_veiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_outros = new System.Windows.Forms.RadioButton();
            this.radioButton_sexoFem = new System.Windows.Forms.RadioButton();
            this.radioButton_sexoMasc = new System.Windows.Forms.RadioButton();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.date_data = new System.Windows.Forms.DateTimePicker();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.maskedTextBox_tel = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView_exibir = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exibir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Civil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(109, 30);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(265, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // checkBox_casa
            // 
            this.checkBox_casa.AutoSize = true;
            this.checkBox_casa.Location = new System.Drawing.Point(53, 136);
            this.checkBox_casa.Name = "checkBox_casa";
            this.checkBox_casa.Size = new System.Drawing.Size(120, 17);
            this.checkBox_casa.TabIndex = 7;
            this.checkBox_casa.Text = "Possui Casa Própria";
            this.checkBox_casa.UseVisualStyleBackColor = true;
            // 
            // comboBox_estadocivil
            // 
            this.comboBox_estadocivil.FormattingEnabled = true;
            this.comboBox_estadocivil.Location = new System.Drawing.Point(145, 83);
            this.comboBox_estadocivil.Name = "comboBox_estadocivil";
            this.comboBox_estadocivil.Size = new System.Drawing.Size(229, 21);
            this.comboBox_estadocivil.TabIndex = 9;
            this.comboBox_estadocivil.SelectedIndexChanged += new System.EventHandler(this.comboBox_estadocivil_SelectedIndexChanged);
            // 
            // checkBox_veiculo
            // 
            this.checkBox_veiculo.AutoSize = true;
            this.checkBox_veiculo.Location = new System.Drawing.Point(256, 136);
            this.checkBox_veiculo.Name = "checkBox_veiculo";
            this.checkBox_veiculo.Size = new System.Drawing.Size(99, 17);
            this.checkBox_veiculo.TabIndex = 10;
            this.checkBox_veiculo.Text = "Possuí Veículo";
            this.checkBox_veiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_outros);
            this.groupBox1.Controls.Add(this.radioButton_sexoFem);
            this.groupBox1.Controls.Add(this.radioButton_sexoMasc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // radioButton_outros
            // 
            this.radioButton_outros.AutoSize = true;
            this.radioButton_outros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_outros.Location = new System.Drawing.Point(246, 19);
            this.radioButton_outros.Name = "radioButton_outros";
            this.radioButton_outros.Size = new System.Drawing.Size(56, 17);
            this.radioButton_outros.TabIndex = 14;
            this.radioButton_outros.TabStop = true;
            this.radioButton_outros.Text = "Outros";
            this.radioButton_outros.UseVisualStyleBackColor = true;
            // 
            // radioButton_sexoFem
            // 
            this.radioButton_sexoFem.AutoSize = true;
            this.radioButton_sexoFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_sexoFem.Location = new System.Drawing.Point(133, 19);
            this.radioButton_sexoFem.Name = "radioButton_sexoFem";
            this.radioButton_sexoFem.Size = new System.Drawing.Size(67, 17);
            this.radioButton_sexoFem.TabIndex = 13;
            this.radioButton_sexoFem.TabStop = true;
            this.radioButton_sexoFem.Text = "Feminino";
            this.radioButton_sexoFem.UseVisualStyleBackColor = true;
            // 
            // radioButton_sexoMasc
            // 
            this.radioButton_sexoMasc.AutoSize = true;
            this.radioButton_sexoMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_sexoMasc.Location = new System.Drawing.Point(11, 19);
            this.radioButton_sexoMasc.Name = "radioButton_sexoMasc";
            this.radioButton_sexoMasc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_sexoMasc.TabIndex = 12;
            this.radioButton_sexoMasc.TabStop = true;
            this.radioButton_sexoMasc.Text = "Masculino";
            this.radioButton_sexoMasc.UseVisualStyleBackColor = true;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.Location = new System.Drawing.Point(52, 221);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(155, 32);
            this.button_cadastrar.TabIndex = 12;
            this.button_cadastrar.Text = "Cadastrar | Alterar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(213, 221);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(81, 32);
            this.button_excluir.TabIndex = 13;
            this.button_excluir.Text = "Excluir ";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(300, 221);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(74, 32);
            this.button_limpar.TabIndex = 14;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // date_data
            // 
            this.date_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_data.Location = new System.Drawing.Point(203, 56);
            this.date_data.Name = "date_data";
            this.date_data.Size = new System.Drawing.Size(171, 20);
            this.date_data.TabIndex = 15;
            // 
            // listBox_lista
            // 
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.Location = new System.Drawing.Point(52, 259);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.Size = new System.Drawing.Size(322, 56);
            this.listBox_lista.TabIndex = 16;
            this.listBox_lista.SelectedIndexChanged += new System.EventHandler(this.listBox_lista_SelectedIndexChanged);
            this.listBox_lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_lista_MouseDoubleClick);
            // 
            // maskedTextBox_tel
            // 
            this.maskedTextBox_tel.Location = new System.Drawing.Point(145, 110);
            this.maskedTextBox_tel.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_tel.Name = "maskedTextBox_tel";
            this.maskedTextBox_tel.Size = new System.Drawing.Size(229, 20);
            this.maskedTextBox_tel.TabIndex = 17;
            // 
            // dataGridView_exibir
            // 
            this.dataGridView_exibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_exibir.Location = new System.Drawing.Point(52, 321);
            this.dataGridView_exibir.Name = "dataGridView_exibir";
            this.dataGridView_exibir.Size = new System.Drawing.Size(322, 109);
            this.dataGridView_exibir.TabIndex = 18;
          
            this.dataGridView_exibir.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_exibir_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 524);
            this.Controls.Add(this.dataGridView_exibir);
            this.Controls.Add(this.maskedTextBox_tel);
            this.Controls.Add(this.listBox_lista);
            this.Controls.Add(this.date_data);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_veiculo);
            this.Controls.Add(this.comboBox_estadocivil);
            this.Controls.Add(this.checkBox_casa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_casa;
        private System.Windows.Forms.ComboBox comboBox_estadocivil;
        private System.Windows.Forms.CheckBox checkBox_veiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_outros;
        private System.Windows.Forms.RadioButton radioButton_sexoFem;
        private System.Windows.Forms.RadioButton radioButton_sexoMasc;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.DateTimePicker date_data;
        private System.Windows.Forms.ListBox listBox_lista;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_tel;
        private System.Windows.Forms.DataGridView dataGridView_exibir;
    }
}

