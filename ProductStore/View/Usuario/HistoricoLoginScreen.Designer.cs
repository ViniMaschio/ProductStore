﻿namespace ProductStore.View.Usuario
{
    partial class HistoricoLoginScreen
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
            this.dGVControleLogin = new System.Windows.Forms.DataGridView();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVControleLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico de Login";
            // 
            // dGVControleLogin
            // 
            this.dGVControleLogin.AllowUserToAddRows = false;
            this.dGVControleLogin.AllowUserToDeleteRows = false;
            this.dGVControleLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVControleLogin.Location = new System.Drawing.Point(12, 71);
            this.dGVControleLogin.Name = "dGVControleLogin";
            this.dGVControleLogin.ReadOnly = true;
            this.dGVControleLogin.Size = new System.Drawing.Size(705, 509);
            this.dGVControleLogin.TabIndex = 1;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(281, 592);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(88, 31);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // HistoricoLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 635);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.dGVControleLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricoLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricoLoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVControleLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVControleLogin;
        private System.Windows.Forms.Button bntSair;
    }
}