namespace Projeto_5
{
    partial class Form_calculadora
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
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.button_soma = new System.Windows.Forms.Button();
            this.button_subtracao = new System.Windows.Forms.Button();
            this.button_divisao = new System.Windows.Forms.Button();
            this.button_multiplicacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_apagar = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite outro valor:";
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(150, 30);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(105, 20);
            this.textBox_valor1.TabIndex = 2;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(150, 76);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(105, 20);
            this.textBox_valor2.TabIndex = 3;
            // 
            // button_soma
            // 
            this.button_soma.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_soma.ForeColor = System.Drawing.Color.White;
            this.button_soma.Location = new System.Drawing.Point(12, 129);
            this.button_soma.Name = "button_soma";
            this.button_soma.Size = new System.Drawing.Size(75, 34);
            this.button_soma.TabIndex = 4;
            this.button_soma.Text = "+";
            this.button_soma.UseVisualStyleBackColor = false;
            this.button_soma.Click += new System.EventHandler(this.button_soma_Click);
            // 
            // button_subtracao
            // 
            this.button_subtracao.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtracao.ForeColor = System.Drawing.Color.White;
            this.button_subtracao.Location = new System.Drawing.Point(102, 129);
            this.button_subtracao.Name = "button_subtracao";
            this.button_subtracao.Size = new System.Drawing.Size(75, 34);
            this.button_subtracao.TabIndex = 5;
            this.button_subtracao.Text = "-";
            this.button_subtracao.UseVisualStyleBackColor = false;
            this.button_subtracao.Click += new System.EventHandler(this.button_subtracao_Click);
            // 
            // button_divisao
            // 
            this.button_divisao.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divisao.ForeColor = System.Drawing.Color.White;
            this.button_divisao.Location = new System.Drawing.Point(281, 129);
            this.button_divisao.Name = "button_divisao";
            this.button_divisao.Size = new System.Drawing.Size(75, 34);
            this.button_divisao.TabIndex = 7;
            this.button_divisao.Text = "/";
            this.button_divisao.UseVisualStyleBackColor = false;
            this.button_divisao.Click += new System.EventHandler(this.button_divisao_Click);
            // 
            // button_multiplicacao
            // 
            this.button_multiplicacao.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplicacao.ForeColor = System.Drawing.Color.White;
            this.button_multiplicacao.Location = new System.Drawing.Point(191, 129);
            this.button_multiplicacao.Name = "button_multiplicacao";
            this.button_multiplicacao.Size = new System.Drawing.Size(75, 34);
            this.button_multiplicacao.TabIndex = 6;
            this.button_multiplicacao.Text = "*";
            this.button_multiplicacao.UseVisualStyleBackColor = false;
            this.button_multiplicacao.Click += new System.EventHandler(this.button_multiplicacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // button_apagar
            // 
            this.button_apagar.BackColor = System.Drawing.Color.OliveDrab;
            this.button_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagar.ForeColor = System.Drawing.Color.White;
            this.button_apagar.Location = new System.Drawing.Point(281, 48);
            this.button_apagar.Name = "button_apagar";
            this.button_apagar.Size = new System.Drawing.Size(75, 34);
            this.button_apagar.TabIndex = 9;
            this.button_apagar.Text = "<=";
            this.button_apagar.UseVisualStyleBackColor = false;
            this.button_apagar.Click += new System.EventHandler(this.button_apagar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(188, 178);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(36, 18);
            this.label_resultado.TabIndex = 10;
            this.label_resultado.Text = "Aqui";
            // 
            // Form_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(368, 227);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_apagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_divisao);
            this.Controls.Add(this.button_multiplicacao);
            this.Controls.Add(this.button_subtracao);
            this.Controls.Add(this.button_soma);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Button button_soma;
        private System.Windows.Forms.Button button_subtracao;
        private System.Windows.Forms.Button button_divisao;
        private System.Windows.Forms.Button button_multiplicacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_apagar;
        private System.Windows.Forms.Label label_resultado;
    }
}

