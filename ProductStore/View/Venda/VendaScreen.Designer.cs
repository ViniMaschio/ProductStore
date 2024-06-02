namespace ProductStore.View.Venda
{
    partial class VendaScreen
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
            this.dGVVendaProduto = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntItens = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVendaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda de Produto";
            // 
            // dGVVendaProduto
            // 
            this.dGVVendaProduto.AllowUserToAddRows = false;
            this.dGVVendaProduto.AllowUserToDeleteRows = false;
            this.dGVVendaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVendaProduto.Location = new System.Drawing.Point(12, 95);
            this.dGVVendaProduto.Name = "dGVVendaProduto";
            this.dGVVendaProduto.ReadOnly = true;
            this.dGVVendaProduto.Size = new System.Drawing.Size(896, 361);
            this.dGVVendaProduto.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(254, 482);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(111, 34);
            this.bntNovo.TabIndex = 2;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntItens
            // 
            this.bntItens.Location = new System.Drawing.Point(371, 482);
            this.bntItens.Name = "bntItens";
            this.bntItens.Size = new System.Drawing.Size(111, 34);
            this.bntItens.TabIndex = 3;
            this.bntItens.Text = "Itens";
            this.bntItens.UseVisualStyleBackColor = true;
            this.bntItens.Click += new System.EventHandler(this.bntItens_Click);
            // 
            // bntDeletar
            // 
            this.bntDeletar.Location = new System.Drawing.Point(488, 482);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(111, 34);
            this.bntDeletar.TabIndex = 4;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(605, 482);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(111, 34);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // VendaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 547);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntItens);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVVendaProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVVendaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVVendaProduto;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntItens;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button bntSair;
    }
}