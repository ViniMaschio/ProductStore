namespace ProductStore.View.Cliente.Cliente
{
    partial class ClienteForm
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
            this.bntNovaFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxRua = new System.Windows.Forms.ComboBox();
            this.cBoxBairro = new System.Windows.Forms.ComboBox();
            this.cBoxSexo = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cBoxCidade = new System.Windows.Forms.ComboBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.cBoxCep = new System.Windows.Forms.ComboBox();
            this.cBoxTrabalho = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FotoCliente = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.vntNovoRua = new System.Windows.Forms.Button();
            this.bntNovoBairro = new System.Windows.Forms.Button();
            this.bntNovoCep = new System.Windows.Forms.Button();
            this.bntNovoTrabalho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // bntNovaFoto
            // 
            this.bntNovaFoto.Location = new System.Drawing.Point(71, 244);
            this.bntNovaFoto.Name = "bntNovaFoto";
            this.bntNovaFoto.Size = new System.Drawing.Size(28, 31);
            this.bntNovaFoto.TabIndex = 2;
            this.bntNovaFoto.Text = "+";
            this.bntNovaFoto.UseVisualStyleBackColor = true;
            this.bntNovaFoto.Click += new System.EventHandler(this.bntNovaFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome :";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(294, 145);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(480, 31);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rua:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bairro:";
            // 
            // cBoxRua
            // 
            this.cBoxRua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxRua.FormattingEnabled = true;
            this.cBoxRua.Location = new System.Drawing.Point(194, 246);
            this.cBoxRua.Name = "cBoxRua";
            this.cBoxRua.Size = new System.Drawing.Size(255, 31);
            this.cBoxRua.TabIndex = 3;
            // 
            // cBoxBairro
            // 
            this.cBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBairro.FormattingEnabled = true;
            this.cBoxBairro.Location = new System.Drawing.Point(773, 246);
            this.cBoxBairro.Name = "cBoxBairro";
            this.cBoxBairro.Size = new System.Drawing.Size(250, 31);
            this.cBoxBairro.TabIndex = 5;
            // 
            // cBoxSexo
            // 
            this.cBoxSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBoxSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxSexo.FormattingEnabled = true;
            this.cBoxSexo.Location = new System.Drawing.Point(830, 145);
            this.cBoxSexo.Name = "cBoxSexo";
            this.cBoxSexo.Size = new System.Drawing.Size(193, 31);
            this.cBoxSexo.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(546, 246);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 31);
            this.txtNumero.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(853, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Trabalho:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(556, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Salario:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(194, 145);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 31);
            this.txtCodigo.TabIndex = 20;
            // 
            // cBoxCidade
            // 
            this.cBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCidade.FormattingEnabled = true;
            this.cBoxCidade.Location = new System.Drawing.Point(546, 337);
            this.cBoxCidade.Name = "cBoxCidade";
            this.cBoxCidade.Size = new System.Drawing.Size(250, 31);
            this.cBoxCidade.TabIndex = 7;
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Location = new System.Drawing.Point(194, 337);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(295, 31);
            this.cBoxEstado.TabIndex = 6;
            this.cBoxEstado.SelectedIndexChanged += new System.EventHandler(this.cBoxEstado_SelectedIndexChanged);
            // 
            // cBoxCep
            // 
            this.cBoxCep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCep.FormattingEnabled = true;
            this.cBoxCep.Location = new System.Drawing.Point(857, 337);
            this.cBoxCep.Name = "cBoxCep";
            this.cBoxCep.Size = new System.Drawing.Size(166, 31);
            this.cBoxCep.TabIndex = 8;
            // 
            // cBoxTrabalho
            // 
            this.cBoxTrabalho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxTrabalho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxTrabalho.FormattingEnabled = true;
            this.cBoxTrabalho.Location = new System.Drawing.Point(194, 434);
            this.cBoxTrabalho.Name = "cBoxTrabalho";
            this.cBoxTrabalho.Size = new System.Drawing.Size(224, 31);
            this.cBoxTrabalho.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(560, 434);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(111, 31);
            this.txtSalario.TabIndex = 10;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(399, 530);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(104, 33);
            this.bntSalvar.TabIndex = 11;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(509, 530);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(104, 33);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FotoCliente
            // 
            this.FotoCliente.Location = new System.Drawing.Point(37, 119);
            this.FotoCliente.Name = "FotoCliente";
            this.FotoCliente.Size = new System.Drawing.Size(106, 119);
            this.FotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoCliente.TabIndex = 1;
            this.FotoCliente.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(780, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Data Nascimento:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimento.Location = new System.Drawing.Point(784, 434);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(155, 31);
            this.DataNascimento.TabIndex = 22;
            // 
            // vntNovoRua
            // 
            this.vntNovoRua.Location = new System.Drawing.Point(238, 216);
            this.vntNovoRua.Name = "vntNovoRua";
            this.vntNovoRua.Size = new System.Drawing.Size(25, 30);
            this.vntNovoRua.TabIndex = 23;
            this.vntNovoRua.Text = "+";
            this.vntNovoRua.UseVisualStyleBackColor = true;
            this.vntNovoRua.Click += new System.EventHandler(this.vntNovoRua_Click);
            // 
            // bntNovoBairro
            // 
            this.bntNovoBairro.Location = new System.Drawing.Point(841, 216);
            this.bntNovoBairro.Name = "bntNovoBairro";
            this.bntNovoBairro.Size = new System.Drawing.Size(25, 30);
            this.bntNovoBairro.TabIndex = 24;
            this.bntNovoBairro.Text = "+";
            this.bntNovoBairro.UseVisualStyleBackColor = true;
            // 
            // bntNovoCep
            // 
            this.bntNovoCep.Location = new System.Drawing.Point(904, 307);
            this.bntNovoCep.Name = "bntNovoCep";
            this.bntNovoCep.Size = new System.Drawing.Size(25, 30);
            this.bntNovoCep.TabIndex = 25;
            this.bntNovoCep.Text = "+";
            this.bntNovoCep.UseVisualStyleBackColor = true;
            // 
            // bntNovoTrabalho
            // 
            this.bntNovoTrabalho.Location = new System.Drawing.Point(294, 404);
            this.bntNovoTrabalho.Name = "bntNovoTrabalho";
            this.bntNovoTrabalho.Size = new System.Drawing.Size(25, 30);
            this.bntNovoTrabalho.TabIndex = 26;
            this.bntNovoTrabalho.Text = "+";
            this.bntNovoTrabalho.UseVisualStyleBackColor = true;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 591);
            this.Controls.Add(this.bntNovoTrabalho);
            this.Controls.Add(this.bntNovoCep);
            this.Controls.Add(this.bntNovoBairro);
            this.Controls.Add(this.vntNovoRua);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cBoxTrabalho);
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
            this.Controls.Add(this.cBoxSexo);
            this.Controls.Add(this.cBoxBairro);
            this.Controls.Add(this.cBoxRua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntNovaFoto);
            this.Controls.Add(this.FotoCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.FotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FotoCliente;
        private System.Windows.Forms.Button bntNovaFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxRua;
        private System.Windows.Forms.ComboBox cBoxBairro;
        private System.Windows.Forms.ComboBox cBoxSexo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cBoxCidade;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.ComboBox cBoxCep;
        private System.Windows.Forms.ComboBox cBoxTrabalho;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.Button vntNovoRua;
        private System.Windows.Forms.Button bntNovoBairro;
        private System.Windows.Forms.Button bntNovoCep;
        private System.Windows.Forms.Button bntNovoTrabalho;
    }
}