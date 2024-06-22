namespace ProductStore.View.Funcionario.Funcionario
{
    partial class TelefoneFuncionarioScreen
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
            this.dGVTelefoneFuncionario = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.Button();
            this.BntAdicionar = new System.Windows.Forms.Button();
            this.bntRemover = new System.Windows.Forms.Button();
            this.cBoxTelefone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntNovoTelefone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone Funcionario";
            // 
            // dGVTelefoneFuncionario
            // 
            this.dGVTelefoneFuncionario.AllowUserToAddRows = false;
            this.dGVTelefoneFuncionario.AllowUserToDeleteRows = false;
            this.dGVTelefoneFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTelefoneFuncionario.Location = new System.Drawing.Point(12, 108);
            this.dGVTelefoneFuncionario.Name = "dGVTelefoneFuncionario";
            this.dGVTelefoneFuncionario.ReadOnly = true;
            this.dGVTelefoneFuncionario.Size = new System.Drawing.Size(318, 238);
            this.dGVTelefoneFuncionario.TabIndex = 1;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(212, 390);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(118, 33);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // BntAdicionar
            // 
            this.BntAdicionar.Location = new System.Drawing.Point(353, 202);
            this.BntAdicionar.Name = "BntAdicionar";
            this.BntAdicionar.Size = new System.Drawing.Size(118, 33);
            this.BntAdicionar.TabIndex = 3;
            this.BntAdicionar.Text = "Adicionar";
            this.BntAdicionar.UseVisualStyleBackColor = true;
            this.BntAdicionar.Click += new System.EventHandler(this.BntAdicionar_Click);
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(477, 202);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(118, 33);
            this.bntRemover.TabIndex = 4;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // cBoxTelefone
            // 
            this.cBoxTelefone.FormattingEnabled = true;
            this.cBoxTelefone.Location = new System.Drawing.Point(364, 137);
            this.cBoxTelefone.Name = "cBoxTelefone";
            this.cBoxTelefone.Size = new System.Drawing.Size(214, 31);
            this.cBoxTelefone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone:";
            // 
            // bntNovoTelefone
            // 
            this.bntNovoTelefone.Location = new System.Drawing.Point(455, 108);
            this.bntNovoTelefone.Name = "bntNovoTelefone";
            this.bntNovoTelefone.Size = new System.Drawing.Size(26, 29);
            this.bntNovoTelefone.TabIndex = 7;
            this.bntNovoTelefone.Text = "+";
            this.bntNovoTelefone.UseVisualStyleBackColor = true;
            this.bntNovoTelefone.Click += new System.EventHandler(this.bntNovoTelefone_Click);
            // 
            // TelefoneFuncionarioScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 459);
            this.Controls.Add(this.bntNovoTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxTelefone);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.BntAdicionar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dGVTelefoneFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelefoneFuncionarioScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneFuncionarioScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVTelefoneFuncionario;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button BntAdicionar;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.ComboBox cBoxTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntNovoTelefone;
    }
}