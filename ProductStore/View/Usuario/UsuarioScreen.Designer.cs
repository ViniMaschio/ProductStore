namespace ProductStore.View.Usuario
{
    partial class UsuarioScreen
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
            this.dGVLogins = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios do Sistema";
            // 
            // dGVLogins
            // 
            this.dGVLogins.AllowUserToAddRows = false;
            this.dGVLogins.AllowUserToDeleteRows = false;
            this.dGVLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLogins.Location = new System.Drawing.Point(12, 57);
            this.dGVLogins.Name = "dGVLogins";
            this.dGVLogins.ReadOnly = true;
            this.dGVLogins.Size = new System.Drawing.Size(761, 334);
            this.dGVLogins.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(98, 423);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(108, 35);
            this.bntNovo.TabIndex = 2;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(326, 423);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(108, 35);
            this.bntEditar.TabIndex = 3;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntDeletar
            // 
            this.bntDeletar.Location = new System.Drawing.Point(440, 423);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(108, 35);
            this.bntDeletar.TabIndex = 4;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(554, 423);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(108, 35);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntHistorico
            // 
            this.bntHistorico.Location = new System.Drawing.Point(212, 423);
            this.bntHistorico.Name = "bntHistorico";
            this.bntHistorico.Size = new System.Drawing.Size(108, 35);
            this.bntHistorico.TabIndex = 6;
            this.bntHistorico.Text = "Historico";
            this.bntHistorico.UseVisualStyleBackColor = true;
            this.bntHistorico.Click += new System.EventHandler(this.bntHistorico_Click);
            // 
            // UsuarioScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 509);
            this.Controls.Add(this.bntHistorico);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVLogins);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioScreen";
            this.Load += new System.EventHandler(this.UsuarioScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLogins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVLogins;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntHistorico;
    }
}