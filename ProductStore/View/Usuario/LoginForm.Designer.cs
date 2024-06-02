namespace ProductStore.View.Usuario
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cBoxAcesso = new System.Windows.Forms.ComboBox();
            this.cBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acesso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Funcionario:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(12, 118);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(52, 31);
            this.txtCod.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(122, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(341, 31);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(515, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(187, 31);
            this.txtSenha.TabIndex = 8;
            // 
            // cBoxAcesso
            // 
            this.cBoxAcesso.FormattingEnabled = true;
            this.cBoxAcesso.Location = new System.Drawing.Point(369, 191);
            this.cBoxAcesso.Name = "cBoxAcesso";
            this.cBoxAcesso.Size = new System.Drawing.Size(246, 31);
            this.cBoxAcesso.TabIndex = 9;
            // 
            // cBoxFuncionario
            // 
            this.cBoxFuncionario.FormattingEnabled = true;
            this.cBoxFuncionario.Location = new System.Drawing.Point(14, 191);
            this.cBoxFuncionario.Name = "cBoxFuncionario";
            this.cBoxFuncionario.Size = new System.Drawing.Size(284, 31);
            this.cBoxFuncionario.TabIndex = 10;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(209, 280);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(110, 31);
            this.bntSalvar.TabIndex = 11;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(345, 280);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(110, 31);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 373);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.cBoxFuncionario);
            this.Controls.Add(this.cBoxAcesso);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cBoxAcesso;
        private System.Windows.Forms.ComboBox cBoxFuncionario;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntSair;
    }
}