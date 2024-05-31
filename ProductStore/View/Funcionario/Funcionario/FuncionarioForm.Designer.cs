namespace ProductStore.View.Funcionario.Funcionario
{
    partial class FuncionarioForm
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
            this.bntNovoFuncao = new System.Windows.Forms.Button();
            this.bntNovoCep = new System.Windows.Forms.Button();
            this.bntNovoBairro = new System.Windows.Forms.Button();
            this.vntNovoRua = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cBoxCep = new System.Windows.Forms.ComboBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.cBoxCidade = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxFuncao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxLoja = new System.Windows.Forms.ComboBox();
            this.bntNovaLoja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntNovoFuncao
            // 
            this.bntNovoFuncao.Location = new System.Drawing.Point(157, 385);
            this.bntNovoFuncao.Name = "bntNovoFuncao";
            this.bntNovoFuncao.Size = new System.Drawing.Size(25, 30);
            this.bntNovoFuncao.TabIndex = 56;
            this.bntNovoFuncao.Text = "+";
            this.bntNovoFuncao.UseVisualStyleBackColor = true;
            this.bntNovoFuncao.Click += new System.EventHandler(this.bntNovoFuncao_Click);
            // 
            // bntNovoCep
            // 
            this.bntNovoCep.Location = new System.Drawing.Point(716, 288);
            this.bntNovoCep.Name = "bntNovoCep";
            this.bntNovoCep.Size = new System.Drawing.Size(25, 30);
            this.bntNovoCep.TabIndex = 55;
            this.bntNovoCep.Text = "+";
            this.bntNovoCep.UseVisualStyleBackColor = true;
            this.bntNovoCep.Click += new System.EventHandler(this.bntNovoCep_Click);
            // 
            // bntNovoBairro
            // 
            this.bntNovoBairro.Location = new System.Drawing.Point(643, 197);
            this.bntNovoBairro.Name = "bntNovoBairro";
            this.bntNovoBairro.Size = new System.Drawing.Size(25, 30);
            this.bntNovoBairro.TabIndex = 54;
            this.bntNovoBairro.Text = "+";
            this.bntNovoBairro.UseVisualStyleBackColor = true;
            this.bntNovoBairro.Click += new System.EventHandler(this.bntNovoBairro_Click);
            // 
            // vntNovoRua
            // 
            this.vntNovoRua.Location = new System.Drawing.Point(112, 197);
            this.vntNovoRua.Name = "vntNovoRua";
            this.vntNovoRua.Size = new System.Drawing.Size(25, 30);
            this.vntNovoRua.TabIndex = 53;
            this.vntNovoRua.Text = "+";
            this.vntNovoRua.UseVisualStyleBackColor = true;
            this.vntNovoRua.Click += new System.EventHandler(this.vntNovoRua_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(457, 518);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(104, 33);
            this.bntSair.TabIndex = 44;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(347, 518);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(104, 33);
            this.bntSalvar.TabIndex = 43;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(714, 126);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(111, 31);
            this.txtSalario.TabIndex = 41;
            // 
            // cBoxCep
            // 
            this.cBoxCep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCep.FormattingEnabled = true;
            this.cBoxCep.Location = new System.Drawing.Point(659, 318);
            this.cBoxCep.Name = "cBoxCep";
            this.cBoxCep.Size = new System.Drawing.Size(166, 31);
            this.cBoxCep.TabIndex = 38;
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Location = new System.Drawing.Point(68, 318);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(295, 31);
            this.cBoxEstado.TabIndex = 34;
            this.cBoxEstado.SelectedIndexChanged += new System.EventHandler(this.cBoxEstado_SelectedIndexChanged);
            // 
            // cBoxCidade
            // 
            this.cBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCidade.FormattingEnabled = true;
            this.cBoxCidade.Location = new System.Drawing.Point(383, 318);
            this.cBoxCidade.Name = "cBoxCidade";
            this.cBoxCidade.Size = new System.Drawing.Size(250, 31);
            this.cBoxCidade.TabIndex = 35;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(68, 126);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 31);
            this.txtCodigo.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(710, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 49;
            this.label13.Text = "Salario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "Funcao:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(655, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 47;
            this.label11.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(420, 227);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 31);
            this.txtNumero.TabIndex = 31;
            // 
            // cBoxBairro
            // 
            this.cBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBairro.FormattingEnabled = true;
            this.cBoxBairro.Location = new System.Drawing.Point(575, 227);
            this.cBoxBairro.Name = "cBoxBairro";
            this.cBoxBairro.Size = new System.Drawing.Size(250, 31);
            this.cBoxBairro.TabIndex = 32;
            // 
            // cBoxRua
            // 
            this.cBoxRua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxRua.FormattingEnabled = true;
            this.cBoxRua.Location = new System.Drawing.Point(68, 227);
            this.cBoxRua.Name = "cBoxRua";
            this.cBoxRua.Size = new System.Drawing.Size(255, 31);
            this.cBoxRua.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(168, 126);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(480, 31);
            this.txtNomeFuncionario.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "CadastroFuncionario";
            // 
            // cBoxFuncao
            // 
            this.cBoxFuncao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxFuncao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxFuncao.FormattingEnabled = true;
            this.cBoxFuncao.Location = new System.Drawing.Point(68, 415);
            this.cBoxFuncao.Name = "cBoxFuncao";
            this.cBoxFuncao.Size = new System.Drawing.Size(224, 31);
            this.cBoxFuncao.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Loja:";
            // 
            // cBoxLoja
            // 
            this.cBoxLoja.FormattingEnabled = true;
            this.cBoxLoja.Location = new System.Drawing.Point(395, 415);
            this.cBoxLoja.Name = "cBoxLoja";
            this.cBoxLoja.Size = new System.Drawing.Size(401, 31);
            this.cBoxLoja.TabIndex = 59;
            // 
            // bntNovaLoja
            // 
            this.bntNovaLoja.Location = new System.Drawing.Point(457, 385);
            this.bntNovaLoja.Name = "bntNovaLoja";
            this.bntNovaLoja.Size = new System.Drawing.Size(25, 30);
            this.bntNovaLoja.TabIndex = 60;
            this.bntNovaLoja.Text = "+";
            this.bntNovaLoja.UseVisualStyleBackColor = true;
            this.bntNovaLoja.Click += new System.EventHandler(this.bntNovaLoja_Click);
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.bntNovaLoja);
            this.Controls.Add(this.cBoxLoja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntNovoFuncao);
            this.Controls.Add(this.bntNovoCep);
            this.Controls.Add(this.bntNovoBairro);
            this.Controls.Add(this.vntNovoRua);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cBoxFuncao);
            this.Controls.Add(this.cBoxCep);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.cBoxCidade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNovoFuncao;
        private System.Windows.Forms.Button bntNovoCep;
        private System.Windows.Forms.Button bntNovoBairro;
        private System.Windows.Forms.Button vntNovoRua;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cBoxCep;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.ComboBox cBoxCidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxLoja;
        private System.Windows.Forms.Button bntNovaLoja;
    }
}