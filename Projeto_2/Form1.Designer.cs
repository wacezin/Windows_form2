namespace Projeto_2
{
    partial class Fomr_Saudacao
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_nome.Location = new System.Drawing.Point(101, 101);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(73, 23);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            this.label_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(193, 106);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(220, 20);
            this.textBox_nome.TabIndex = 1;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // button_exibir
            // 
            this.button_exibir.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exibir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_exibir.Location = new System.Drawing.Point(193, 163);
            this.button_exibir.Name = "button_exibir";
            this.button_exibir.Size = new System.Drawing.Size(145, 43);
            this.button_exibir.TabIndex = 2;
            this.button_exibir.Text = "&Clique Aqui!";
            this.button_exibir.UseVisualStyleBackColor = true;
            this.button_exibir.Click += new System.EventHandler(this.button_exibir_Click);
            // 
            // Fomr_Saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(558, 327);
            this.Controls.Add(this.button_exibir);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fomr_Saudacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 2 - Saudação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_exibir;
    }
}

