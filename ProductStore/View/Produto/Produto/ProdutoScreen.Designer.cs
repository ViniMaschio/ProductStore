namespace ProductStore.View.Produto.Produto
{
    partial class ProdutoScreen
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
            this.dGVProduto = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVProduto
            // 
            this.dGVProduto.AllowUserToAddRows = false;
            this.dGVProduto.AllowUserToDeleteRows = false;
            this.dGVProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduto.Location = new System.Drawing.Point(12, 125);
            this.dGVProduto.Name = "dGVProduto";
            this.dGVProduto.ReadOnly = true;
            this.dGVProduto.RowHeadersWidth = 62;
            this.dGVProduto.Size = new System.Drawing.Size(932, 395);
            this.dGVProduto.TabIndex = 0;
            // 
            // bntNovo
            // 
            this.bntNovo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNovo.Location = new System.Drawing.Point(206, 571);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(91, 40);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditar.Location = new System.Drawing.Point(303, 571);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(91, 40);
            this.bntEditar.TabIndex = 2;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.Location = new System.Drawing.Point(400, 571);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(91, 40);
            this.bntExcluir.TabIndex = 3;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntSair
            // 
            this.bntSair.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(599, 571);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(91, 40);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de produtos";
            // 
            // bntImagem
            // 
            this.bntImagem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImagem.Location = new System.Drawing.Point(497, 571);
            this.bntImagem.Name = "bntImagem";
            this.bntImagem.Size = new System.Drawing.Size(96, 40);
            this.bntImagem.TabIndex = 6;
            this.bntImagem.Text = "Foto";
            this.bntImagem.UseVisualStyleBackColor = true;
            this.bntImagem.Click += new System.EventHandler(this.bntImagem_Click);
            // 
            // ProdutoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 701);
            this.Controls.Add(this.bntImagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVProduto);
            this.Name = "ProdutoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoScreen";
            this.Load += new System.EventHandler(this.ProdutoScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVProduto;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntImagem;
    }
}