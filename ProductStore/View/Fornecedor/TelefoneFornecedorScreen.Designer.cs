namespace ProductStore.View.Fornecedor
{
    partial class TelefoneFornecedorScreen
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
            this.dGVTelefoneFornecedor = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.cBoxTelefone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone Fornecedor";
            // 
            // dGVTelefoneFornecedor
            // 
            this.dGVTelefoneFornecedor.AllowUserToAddRows = false;
            this.dGVTelefoneFornecedor.AllowUserToDeleteRows = false;
            this.dGVTelefoneFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTelefoneFornecedor.Location = new System.Drawing.Point(12, 78);
            this.dGVTelefoneFornecedor.Name = "dGVTelefoneFornecedor";
            this.dGVTelefoneFornecedor.ReadOnly = true;
            this.dGVTelefoneFornecedor.Size = new System.Drawing.Size(297, 228);
            this.dGVTelefoneFornecedor.TabIndex = 1;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(208, 376);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(114, 34);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(338, 194);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(114, 34);
            this.bntAdicionar.TabIndex = 3;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(458, 194);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(114, 34);
            this.bntRemover.TabIndex = 4;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // cBoxTelefone
            // 
            this.cBoxTelefone.FormattingEnabled = true;
            this.cBoxTelefone.Location = new System.Drawing.Point(338, 113);
            this.cBoxTelefone.Name = "cBoxTelefone";
            this.cBoxTelefone.Size = new System.Drawing.Size(234, 31);
            this.cBoxTelefone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone:";
            // 
            // TelefoneFornecedorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxTelefone);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.bntAdicionar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dGVTelefoneFornecedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelefoneFornecedorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneFornecedorScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVTelefoneFornecedor;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.ComboBox cBoxTelefone;
        private System.Windows.Forms.Label label2;
    }
}