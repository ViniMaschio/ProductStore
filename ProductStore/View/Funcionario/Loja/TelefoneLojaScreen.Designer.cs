﻿namespace ProductStore.View.Funcionario.Loja
{
    partial class TelefoneLojaScreen
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
            this.dGVTelefoneLoja = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.cBoxTelefone = new System.Windows.Forms.ComboBox();
            this.bntRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneLoja)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVTelefoneLoja
            // 
            this.dGVTelefoneLoja.AllowUserToAddRows = false;
            this.dGVTelefoneLoja.AllowUserToDeleteRows = false;
            this.dGVTelefoneLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTelefoneLoja.Location = new System.Drawing.Point(22, 102);
            this.dGVTelefoneLoja.Name = "dGVTelefoneLoja";
            this.dGVTelefoneLoja.ReadOnly = true;
            this.dGVTelefoneLoja.Size = new System.Drawing.Size(277, 258);
            this.dGVTelefoneLoja.TabIndex = 0;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(174, 418);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(104, 34);
            this.bntSair.TabIndex = 1;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(318, 195);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(116, 34);
            this.bntAdicionar.TabIndex = 2;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // cBoxTelefone
            // 
            this.cBoxTelefone.FormattingEnabled = true;
            this.cBoxTelefone.Location = new System.Drawing.Point(329, 130);
            this.cBoxTelefone.Name = "cBoxTelefone";
            this.cBoxTelefone.Size = new System.Drawing.Size(214, 31);
            this.cBoxTelefone.TabIndex = 3;
            // 
            // bntRemover
            // 
            this.bntRemover.Location = new System.Drawing.Point(440, 195);
            this.bntRemover.Name = "bntRemover";
            this.bntRemover.Size = new System.Drawing.Size(116, 34);
            this.bntRemover.TabIndex = 4;
            this.bntRemover.Text = "Remover";
            this.bntRemover.UseVisualStyleBackColor = true;
            this.bntRemover.Click += new System.EventHandler(this.bntRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefone da Loja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelefoneLojaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRemover);
            this.Controls.Add(this.cBoxTelefone);
            this.Controls.Add(this.bntAdicionar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dGVTelefoneLoja);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelefoneLojaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneLoja";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneLoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTelefoneLoja;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.ComboBox cBoxTelefone;
        private System.Windows.Forms.Button bntRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}