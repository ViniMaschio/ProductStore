namespace ProductStore.View.Fornecedor
{
    partial class FornecedorForm
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
            this.bntNovoCep = new System.Windows.Forms.Button();
            this.bntNovoBairro = new System.Windows.Forms.Button();
            this.vntNovoRua = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.cBoxCep = new System.Windows.Forms.ComboBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.cBoxCidade = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cBoxBairro = new System.Windows.Forms.ComboBox();
            this.cBoxRua = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntNovoCep
            // 
            this.bntNovoCep.Location = new System.Drawing.Point(659, 178);
            this.bntNovoCep.Name = "bntNovoCep";
            this.bntNovoCep.Size = new System.Drawing.Size(25, 30);
            this.bntNovoCep.TabIndex = 56;
            this.bntNovoCep.Text = "+";
            this.bntNovoCep.UseVisualStyleBackColor = true;
            // 
            // bntNovoBairro
            // 
            this.bntNovoBairro.Location = new System.Drawing.Point(380, 178);
            this.bntNovoBairro.Name = "bntNovoBairro";
            this.bntNovoBairro.Size = new System.Drawing.Size(29, 30);
            this.bntNovoBairro.TabIndex = 55;
            this.bntNovoBairro.Text = "+";
            this.bntNovoBairro.UseVisualStyleBackColor = true;
            // 
            // vntNovoRua
            // 
            this.vntNovoRua.Location = new System.Drawing.Point(66, 182);
            this.vntNovoRua.Name = "vntNovoRua";
            this.vntNovoRua.Size = new System.Drawing.Size(25, 30);
            this.vntNovoRua.TabIndex = 54;
            this.vntNovoRua.Text = "+";
            this.vntNovoRua.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(375, 379);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(104, 33);
            this.bntSair.TabIndex = 45;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(265, 379);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(104, 33);
            this.bntSalvar.TabIndex = 44;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // cBoxCep
            // 
            this.cBoxCep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCep.FormattingEnabled = true;
            this.cBoxCep.Location = new System.Drawing.Point(612, 208);
            this.cBoxCep.Name = "cBoxCep";
            this.cBoxCep.Size = new System.Drawing.Size(166, 31);
            this.cBoxCep.TabIndex = 39;
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Location = new System.Drawing.Point(22, 303);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(295, 31);
            this.cBoxEstado.TabIndex = 35;
            this.cBoxEstado.SelectedIndexChanged += new System.EventHandler(this.cBoxEstado_SelectedIndexChanged);
            // 
            // cBoxCidade
            // 
            this.cBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCidade.FormattingEnabled = true;
            this.cBoxCidade.Location = new System.Drawing.Point(374, 303);
            this.cBoxCidade.Name = "cBoxCidade";
            this.cBoxCidade.Size = new System.Drawing.Size(250, 31);
            this.cBoxCidade.TabIndex = 36;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 111);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 31);
            this.txtCodigo.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(646, 111);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 31);
            this.txtNumero.TabIndex = 32;
            // 
            // cBoxBairro
            // 
            this.cBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBairro.FormattingEnabled = true;
            this.cBoxBairro.Location = new System.Drawing.Point(312, 208);
            this.cBoxBairro.Name = "cBoxBairro";
            this.cBoxBairro.Size = new System.Drawing.Size(279, 31);
            this.cBoxBairro.TabIndex = 33;
            // 
            // cBoxRua
            // 
            this.cBoxRua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxRua.FormattingEnabled = true;
            this.cBoxRua.Location = new System.Drawing.Point(22, 212);
            this.cBoxRua.Name = "cBoxRua";
            this.cBoxRua.Size = new System.Drawing.Size(255, 31);
            this.cBoxRua.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(122, 111);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(480, 31);
            this.txtFornecedor.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // FornecedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 435);
            this.Controls.Add(this.bntNovoCep);
            this.Controls.Add(this.bntNovoBairro);
            this.Controls.Add(this.vntNovoRua);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.cBoxCep);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.cBoxCidade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cBoxBairro);
            this.Controls.Add(this.cBoxRua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FornecedorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FornecedorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNovoCep;
        private System.Windows.Forms.Button bntNovoBairro;
        private System.Windows.Forms.Button vntNovoRua;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.ComboBox cBoxCep;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.ComboBox cBoxCidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cBoxBairro;
        private System.Windows.Forms.ComboBox cBoxRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}