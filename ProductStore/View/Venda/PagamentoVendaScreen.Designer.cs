namespace ProductStore.View.Venda
{
    partial class PagamentoVendaScreen
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
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txtQuantidadeParcela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVBoletos = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(283, 416);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(103, 30);
            this.bntCancelar.TabIndex = 11;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(174, 416);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(103, 30);
            this.bntSalvar.TabIndex = 10;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txtQuantidadeParcela
            // 
            this.txtQuantidadeParcela.Location = new System.Drawing.Point(283, 50);
            this.txtQuantidadeParcela.Name = "txtQuantidadeParcela";
            this.txtQuantidadeParcela.Size = new System.Drawing.Size(48, 31);
            this.txtQuantidadeParcela.TabIndex = 9;
            this.txtQuantidadeParcela.Text = "1";
            this.txtQuantidadeParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeParcela.TextChanged += new System.EventHandler(this.txtQuantidadeParcela_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade Parcela:";
            // 
            // dGVBoletos
            // 
            this.dGVBoletos.AllowUserToAddRows = false;
            this.dGVBoletos.AllowUserToDeleteRows = false;
            this.dGVBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.CodVenda,
            this.ValorPar,
            this.Data});
            this.dGVBoletos.Location = new System.Drawing.Point(12, 85);
            this.dGVBoletos.Name = "dGVBoletos";
            this.dGVBoletos.ReadOnly = true;
            this.dGVBoletos.Size = new System.Drawing.Size(576, 297);
            this.dGVBoletos.TabIndex = 7;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            this.Parcela.Width = 80;
            // 
            // CodVenda
            // 
            this.CodVenda.HeaderText = "Venda";
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            // 
            // ValorPar
            // 
            this.ValorPar.HeaderText = "Valor Parcela";
            this.ValorPar.Name = "ValorPar";
            this.ValorPar.ReadOnly = true;
            this.ValorPar.Width = 180;
            // 
            // Data
            // 
            this.Data.HeaderText = "DataVencimento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Boletos";
            // 
            // BoletosVendaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 467);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtQuantidadeParcela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVBoletos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BoletosVendaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoletosVendaScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txtQuantidadeParcela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label1;
    }
}