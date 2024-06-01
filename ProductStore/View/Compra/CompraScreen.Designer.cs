namespace ProductStore.View.Compra
{
    partial class CompraScreen
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
            this.dGVCompraProduto = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntItens = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompraProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Produtos";
            // 
            // dGVCompraProduto
            // 
            this.dGVCompraProduto.AllowUserToAddRows = false;
            this.dGVCompraProduto.AllowUserToDeleteRows = false;
            this.dGVCompraProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCompraProduto.Location = new System.Drawing.Point(12, 83);
            this.dGVCompraProduto.Name = "dGVCompraProduto";
            this.dGVCompraProduto.ReadOnly = true;
            this.dGVCompraProduto.Size = new System.Drawing.Size(899, 463);
            this.dGVCompraProduto.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(178, 596);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(103, 33);
            this.bntNovo.TabIndex = 2;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntItens
            // 
            this.bntItens.Location = new System.Drawing.Point(287, 596);
            this.bntItens.Name = "bntItens";
            this.bntItens.Size = new System.Drawing.Size(103, 33);
            this.bntItens.TabIndex = 3;
            this.bntItens.Text = "Itens";
            this.bntItens.UseVisualStyleBackColor = true;
            this.bntItens.Click += new System.EventHandler(this.bntItens_Click);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(506, 596);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(103, 33);
            this.Deletar.TabIndex = 4;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(396, 596);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(103, 33);
            this.bntEditar.TabIndex = 5;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(614, 596);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(103, 33);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // CompraScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.bntItens);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVCompraProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompraProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVCompraProduto;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntItens;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntSair;
    }
}