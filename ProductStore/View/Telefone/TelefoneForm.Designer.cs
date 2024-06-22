namespace ProductStore.View.Telefone
{
    partial class TelefoneForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cBoxOperadora = new System.Windows.Forms.ComboBox();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operadora:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(97, 87);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(45, 31);
            this.txtCod.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(141, 119);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 31);
            this.txtTelefone.TabIndex = 4;
            // 
            // cBoxOperadora
            // 
            this.cBoxOperadora.FormattingEnabled = true;
            this.cBoxOperadora.Location = new System.Drawing.Point(160, 156);
            this.cBoxOperadora.Name = "cBoxOperadora";
            this.cBoxOperadora.Size = new System.Drawing.Size(156, 31);
            this.cBoxOperadora.TabIndex = 5;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(74, 242);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(97, 39);
            this.bntNovo.TabIndex = 6;
            this.bntNovo.Text = "Salvar";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(185, 242);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(97, 39);
            this.bntSair.TabIndex = 7;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadastro de Telefone";
            // 
            // TelefoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.cBoxOperadora);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelefoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cBoxOperadora;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label label4;
    }
}