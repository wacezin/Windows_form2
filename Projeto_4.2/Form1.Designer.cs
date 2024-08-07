namespace Projeto_4._2
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
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.date_data = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_gasto_transp = new System.Windows.Forms.Label();
            this.label_gasto_dest = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(140, 0, 120, 0);
            this.label1.Size = new System.Drawing.Size(626, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVA DE PASSAGEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(87, 41);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(373, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_destino.Location = new System.Drawing.Point(87, 76);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(126, 21);
            this.comboBox_destino.TabIndex = 4;
            // 
            // date_data
            // 
            this.date_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_data.Location = new System.Drawing.Point(87, 111);
            this.date_data.Name = "date_data";
            this.date_data.Size = new System.Drawing.Size(126, 20);
            this.date_data.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_onibus);
            this.groupBox1.Controls.Add(this.radioButton_aviao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(228, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meios de Transporte:";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_onibus.Location = new System.Drawing.Point(129, 19);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(58, 17);
            this.radioButton_onibus.TabIndex = 1;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Ônibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_aviao.Location = new System.Drawing.Point(25, 19);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(52, 17);
            this.radioButton_aviao.TabIndex = 0;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_gasto_transp);
            this.groupBox2.Controls.Add(this.label_gasto_dest);
            this.groupBox2.Controls.Add(this.label_total);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(87, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 81);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores do Pacote:";
            // 
            // label_gasto_transp
            // 
            this.label_gasto_transp.AutoSize = true;
            this.label_gasto_transp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gasto_transp.Location = new System.Drawing.Point(42, 50);
            this.label_gasto_transp.Name = "label_gasto_transp";
            this.label_gasto_transp.Size = new System.Drawing.Size(34, 13);
            this.label_gasto_transp.TabIndex = 8;
            this.label_gasto_transp.Text = "00,00";
            // 
            // label_gasto_dest
            // 
            this.label_gasto_dest.AutoSize = true;
            this.label_gasto_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gasto_dest.Location = new System.Drawing.Point(173, 50);
            this.label_gasto_dest.Name = "label_gasto_dest";
            this.label_gasto_dest.Size = new System.Drawing.Size(34, 13);
            this.label_gasto_dest.TabIndex = 7;
            this.label_gasto_dest.Text = "00,00";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(308, 50);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 13);
            this.label_total.TabIndex = 6;
            this.label_total.Text = "00,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gasto com Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gasto Transporte:";
            // 
            // button_confirmar
            // 
            this.button_confirmar.Location = new System.Drawing.Point(463, 41);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(75, 33);
            this.button_confirmar.TabIndex = 9;
            this.button_confirmar.Text = "Confirmar";
            this.button_confirmar.UseVisualStyleBackColor = true;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(463, 87);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(75, 33);
            this.button_calc.TabIndex = 10;
            this.button_calc.Text = "Cacular";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(544, 87);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 33);
            this.button_sair.TabIndex = 12;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(544, 41);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 33);
            this.button_limpar.TabIndex = 11;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 268);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_data);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Passagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.DateTimePicker date_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_gasto_transp;
        private System.Windows.Forms.Label label_gasto_dest;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_limpar;
    }
}

