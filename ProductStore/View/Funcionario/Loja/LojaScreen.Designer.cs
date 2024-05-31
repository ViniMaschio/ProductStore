namespace ProductStore.View.Funcionario.Loja
{
    partial class LojaScreen
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
            this.dGWLoja = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.bntTelefone = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWLoja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Loja";
            // 
            // dGWLoja
            // 
            this.dGWLoja.AllowUserToAddRows = false;
            this.dGWLoja.AllowUserToDeleteRows = false;
            this.dGWLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWLoja.Location = new System.Drawing.Point(12, 118);
            this.dGWLoja.Name = "dGWLoja";
            this.dGWLoja.ReadOnly = true;
            this.dGWLoja.Size = new System.Drawing.Size(1093, 413);
            this.dGWLoja.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(228, 576);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(112, 32);
            this.bntNovo.TabIndex = 2;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(346, 576);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(112, 32);
            this.bntEditar.TabIndex = 3;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntDeletar
            // 
            this.bntDeletar.Location = new System.Drawing.Point(464, 576);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(112, 32);
            this.bntDeletar.TabIndex = 4;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // bntTelefone
            // 
            this.bntTelefone.Location = new System.Drawing.Point(582, 576);
            this.bntTelefone.Name = "bntTelefone";
            this.bntTelefone.Size = new System.Drawing.Size(112, 32);
            this.bntTelefone.TabIndex = 5;
            this.bntTelefone.Text = "Telefone";
            this.bntTelefone.UseVisualStyleBackColor = true;
            this.bntTelefone.Click += new System.EventHandler(this.bntTelefone_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(700, 576);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(112, 32);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // LojaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 648);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntTelefone);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGWLoja);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LojaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGWLoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWLoja;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button bntTelefone;
        private System.Windows.Forms.Button bntSair;
    }
}