namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_senha_login = new System.Windows.Forms.TextBox();
            this.button_entrar_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autentificação do Sistema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 100);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            // 
            // txt_email_login
            // 
            this.txt_email_login.Location = new System.Drawing.Point(85, 121);
            this.txt_email_login.Name = "txt_email_login";
            this.txt_email_login.Size = new System.Drawing.Size(263, 20);
            this.txt_email_login.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // txt_senha_login
            // 
            this.txt_senha_login.Location = new System.Drawing.Point(85, 147);
            this.txt_senha_login.Name = "txt_senha_login";
            this.txt_senha_login.Size = new System.Drawing.Size(263, 20);
            this.txt_senha_login.TabIndex = 10;
            this.txt_senha_login.UseSystemPasswordChar = true;
            // 
            // button_entrar_login
            // 
            this.button_entrar_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_entrar_login.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar_login.ForeColor = System.Drawing.Color.White;
            this.button_entrar_login.Location = new System.Drawing.Point(129, 187);
            this.button_entrar_login.Name = "button_entrar_login";
            this.button_entrar_login.Size = new System.Drawing.Size(123, 45);
            this.button_entrar_login.TabIndex = 11;
            this.button_entrar_login.Text = "ENTRAR";
            this.button_entrar_login.UseVisualStyleBackColor = false;
            this.button_entrar_login.Click += new System.EventHandler(this.button_entrar_login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 252);
            this.Controls.Add(this.button_entrar_login);
            this.Controls.Add(this.txt_senha_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_senha_login;
        private System.Windows.Forms.Button button_entrar_login;
    }
}