namespace ProductStore.View.Cliente.Trabalho
{
    partial class TrabalhoScreen
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
            this.dGVTrabalho = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVTelefone = new System.Windows.Forms.DataGridView();
            this.bntTelefone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrabalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVTrabalho
            // 
            this.dGVTrabalho.AllowUserToAddRows = false;
            this.dGVTrabalho.AllowUserToDeleteRows = false;
            this.dGVTrabalho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrabalho.Location = new System.Drawing.Point(12, 102);
            this.dGVTrabalho.Name = "dGVTrabalho";
            this.dGVTrabalho.ReadOnly = true;
            this.dGVTrabalho.Size = new System.Drawing.Size(370, 210);
            this.dGVTrabalho.TabIndex = 0;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(70, 345);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(102, 33);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(178, 345);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(102, 33);
            this.bntEditar.TabIndex = 2;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(286, 345);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(102, 33);
            this.bntExcluir.TabIndex = 3;
            this.bntExcluir.Text = "Deletar";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(394, 345);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(102, 33);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de Trabalho";
            // 
            // dGVTelefone
            // 
            this.dGVTelefone.AllowUserToAddRows = false;
            this.dGVTelefone.AllowUserToDeleteRows = false;
            this.dGVTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTelefone.Location = new System.Drawing.Point(409, 102);
            this.dGVTelefone.Name = "dGVTelefone";
            this.dGVTelefone.ReadOnly = true;
            this.dGVTelefone.Size = new System.Drawing.Size(168, 150);
            this.dGVTelefone.TabIndex = 6;
            // 
            // bntTelefone
            // 
            this.bntTelefone.Location = new System.Drawing.Point(445, 258);
            this.bntTelefone.Name = "bntTelefone";
            this.bntTelefone.Size = new System.Drawing.Size(102, 33);
            this.bntTelefone.TabIndex = 7;
            this.bntTelefone.Text = "Telefones";
            this.bntTelefone.UseVisualStyleBackColor = true;
            this.bntTelefone.Click += new System.EventHandler(this.bntTelefone_Click);
            // 
            // TrabalhoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 407);
            this.Controls.Add(this.bntTelefone);
            this.Controls.Add(this.dGVTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVTrabalho);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrabalhoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrabalhoScreen";
            
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrabalho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTrabalho;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVTelefone;
        private System.Windows.Forms.Button bntTelefone;
    }
}