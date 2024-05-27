namespace ProductStore.View.Cliente.Trabalho
{
    partial class TrabalhoForm
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Trabalho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Trabalho:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(39, 102);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 31);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(39, 178);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(240, 31);
            this.txtTrabalho.TabIndex = 4;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(51, 243);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(96, 39);
            this.bntSalvar.TabIndex = 5;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(153, 243);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(96, 39);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // TrabalhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 318);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrabalhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Trabalho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntSair;
    }
}