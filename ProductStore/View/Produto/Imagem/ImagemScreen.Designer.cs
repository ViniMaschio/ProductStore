namespace ProductStore.View.Produto.Imagem
{
    partial class ImagemScreen
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
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCodImagem = new System.Windows.Forms.TextBox();
            this.bntImagem = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Imagem do Produto";
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(214, 91);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(313, 250);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagem.TabIndex = 1;
            this.pictureBoxImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo Imagem";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(16, 126);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(49, 31);
            this.txtCodProduto.TabIndex = 0;
            // 
            // txtCodImagem
            // 
            this.txtCodImagem.Enabled = false;
            this.txtCodImagem.Location = new System.Drawing.Point(16, 205);
            this.txtCodImagem.Name = "txtCodImagem";
            this.txtCodImagem.Size = new System.Drawing.Size(49, 31);
            this.txtCodImagem.TabIndex = 0;
            // 
            // bntImagem
            // 
            this.bntImagem.Location = new System.Drawing.Point(320, 347);
            this.bntImagem.Name = "bntImagem";
            this.bntImagem.Size = new System.Drawing.Size(207, 33);
            this.bntImagem.TabIndex = 0;
            this.bntImagem.Text = "Selecionar Imagem";
            this.bntImagem.UseVisualStyleBackColor = true;
            this.bntImagem.Click += new System.EventHandler(this.bntImagem_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 417);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(515, 98);
            this.txtDescricao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(88, 551);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(99, 38);
            this.bntSalvar.TabIndex = 2;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntDeletar
            // 
            this.bntDeletar.Location = new System.Drawing.Point(193, 551);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(99, 38);
            this.bntDeletar.TabIndex = 3;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(298, 551);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(99, 38);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|\" + \"All f" +
    "iles (*.*)|*.*";
            // 
            // ImagemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 638);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.bntImagem);
            this.Controls.Add(this.txtCodImagem);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagemScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagemScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtCodImagem;
        private System.Windows.Forms.Button bntImagem;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}