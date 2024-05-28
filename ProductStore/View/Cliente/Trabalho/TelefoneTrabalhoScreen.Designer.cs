namespace ProductStore.View.Cliente.Trabalho
{
    partial class TelefoneTrabalhoScreen
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
            this.dGvTelefone = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.cbBoxTelefone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // dGvTelefone
            // 
            this.dGvTelefone.AllowUserToAddRows = false;
            this.dGvTelefone.AllowUserToDeleteRows = false;
            this.dGvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTelefone.Location = new System.Drawing.Point(12, 130);
            this.dGvTelefone.Name = "dGvTelefone";
            this.dGvTelefone.ReadOnly = true;
            this.dGvTelefone.Size = new System.Drawing.Size(274, 150);
            this.dGvTelefone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefone Trabalho";
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(301, 228);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(115, 36);
            this.bntAdicionar.TabIndex = 2;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(422, 228);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(115, 36);
            this.bntRemover.TabIndex = 3;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // cbBoxTelefone
            // 
            this.cbBoxTelefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBoxTelefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBoxTelefone.FormattingEnabled = true;
            this.cbBoxTelefone.Location = new System.Drawing.Point(314, 165);
            this.cbBoxTelefone.Name = "cbBoxTelefone";
            this.cbBoxTelefone.Size = new System.Drawing.Size(197, 31);
            this.cbBoxTelefone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone :";
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(202, 341);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(115, 36);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // TelefoneTrabalhoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 419);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBoxTelefone);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.bntAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvTelefone);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelefoneTrabalhoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneTrabalhoScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGvTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.ComboBox cbBoxTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSair;
    }
}