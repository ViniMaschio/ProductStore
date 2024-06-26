﻿namespace ProductStore.View.Funcionario.Funcionario
{
    partial class FuncionarioScreen
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
            this.dGVFuncionario = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.BntTelefone = new System.Windows.Forms.Button();
            this.bntApagar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionario";
            // 
            // dGVFuncionario
            // 
            this.dGVFuncionario.AllowUserToAddRows = false;
            this.dGVFuncionario.AllowUserToDeleteRows = false;
            this.dGVFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFuncionario.Location = new System.Drawing.Point(12, 78);
            this.dGVFuncionario.Name = "dGVFuncionario";
            this.dGVFuncionario.ReadOnly = true;
            this.dGVFuncionario.Size = new System.Drawing.Size(1687, 389);
            this.dGVFuncionario.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(511, 521);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(121, 34);
            this.bntNovo.TabIndex = 2;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(638, 521);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(121, 34);
            this.bntEditar.TabIndex = 3;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // BntTelefone
            // 
            this.BntTelefone.Location = new System.Drawing.Point(765, 521);
            this.BntTelefone.Name = "BntTelefone";
            this.BntTelefone.Size = new System.Drawing.Size(121, 34);
            this.BntTelefone.TabIndex = 4;
            this.BntTelefone.Text = "Telefone";
            this.BntTelefone.UseVisualStyleBackColor = true;
            this.BntTelefone.Click += new System.EventHandler(this.BntTelefone_Click);
            // 
            // bntApagar
            // 
            this.bntApagar.Location = new System.Drawing.Point(892, 521);
            this.bntApagar.Name = "bntApagar";
            this.bntApagar.Size = new System.Drawing.Size(121, 34);
            this.bntApagar.TabIndex = 5;
            this.bntApagar.Text = "Apagar";
            this.bntApagar.UseVisualStyleBackColor = true;
            this.bntApagar.Click += new System.EventHandler(this.bntApagar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(1019, 521);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(121, 34);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // FuncionarioScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 639);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntApagar);
            this.Controls.Add(this.BntTelefone);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVFuncionario;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button BntTelefone;
        private System.Windows.Forms.Button bntApagar;
        private System.Windows.Forms.Button bntSair;
    }
}