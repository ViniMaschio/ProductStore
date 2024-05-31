namespace ProductStore.View.Funcionario.Funcao
{
    partial class FuncaoScreen
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
            this.dGVFuncao = new System.Windows.Forms.DataGridView();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuncao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Função ";
            // 
            // dGVFuncao
            // 
            this.dGVFuncao.AllowUserToAddRows = false;
            this.dGVFuncao.AllowUserToDeleteRows = false;
            this.dGVFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFuncao.Location = new System.Drawing.Point(12, 66);
            this.dGVFuncao.Name = "dGVFuncao";
            this.dGVFuncao.ReadOnly = true;
            this.dGVFuncao.Size = new System.Drawing.Size(411, 262);
            this.dGVFuncao.TabIndex = 3;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(12, 357);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(95, 33);
            this.bntNovo.TabIndex = 4;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(113, 357);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(95, 33);
            this.bntEditar.TabIndex = 5;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntDeletar
            // 
            this.bntDeletar.Location = new System.Drawing.Point(215, 357);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(95, 33);
            this.bntDeletar.TabIndex = 6;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(316, 357);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(95, 33);
            this.bntSair.TabIndex = 7;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // FuncaoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 422);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.dGVFuncao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncaoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncaoScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFuncao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVFuncao;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button bntSair;
    }
}