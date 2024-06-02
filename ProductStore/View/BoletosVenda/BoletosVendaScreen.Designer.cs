namespace ProductStore.View.BoletosVenda
{
    partial class BoletosVendaScreen
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
            this.bntSair = new System.Windows.Forms.Button();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioTodosPagos = new System.Windows.Forms.RadioButton();
            this.radioAbertos = new System.Windows.Forms.RadioButton();
            this.dGVBoletoFornecedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bntReceber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBoletoFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(336, 544);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(100, 32);
            this.bntSair.TabIndex = 13;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(485, 61);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(84, 27);
            this.radioTodos.TabIndex = 11;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // radioTodosPagos
            // 
            this.radioTodosPagos.AutoSize = true;
            this.radioTodosPagos.Location = new System.Drawing.Point(315, 61);
            this.radioTodosPagos.Name = "radioTodosPagos";
            this.radioTodosPagos.Size = new System.Drawing.Size(147, 27);
            this.radioTodosPagos.TabIndex = 10;
            this.radioTodosPagos.Text = "Todos Pagos";
            this.radioTodosPagos.UseVisualStyleBackColor = true;
            this.radioTodosPagos.CheckedChanged += new System.EventHandler(this.radioTodosPagos_CheckedChanged);
            // 
            // radioAbertos
            // 
            this.radioAbertos.AutoSize = true;
            this.radioAbertos.Checked = true;
            this.radioAbertos.Location = new System.Drawing.Point(119, 61);
            this.radioAbertos.Name = "radioAbertos";
            this.radioAbertos.Size = new System.Drawing.Size(190, 27);
            this.radioAbertos.TabIndex = 9;
            this.radioAbertos.TabStop = true;
            this.radioAbertos.Text = "Todos em Aberto";
            this.radioAbertos.UseVisualStyleBackColor = true;
            this.radioAbertos.CheckedChanged += new System.EventHandler(this.radioAbertos_CheckedChanged);
            // 
            // dGVBoletoFornecedor
            // 
            this.dGVBoletoFornecedor.AllowUserToAddRows = false;
            this.dGVBoletoFornecedor.AllowUserToDeleteRows = false;
            this.dGVBoletoFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBoletoFornecedor.Location = new System.Drawing.Point(12, 106);
            this.dGVBoletoFornecedor.Name = "dGVBoletoFornecedor";
            this.dGVBoletoFornecedor.ReadOnly = true;
            this.dGVBoletoFornecedor.Size = new System.Drawing.Size(693, 414);
            this.dGVBoletoFornecedor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Botelos para Receber";
            // 
            // bntReceber
            // 
            this.bntReceber.Location = new System.Drawing.Point(230, 544);
            this.bntReceber.Name = "bntReceber";
            this.bntReceber.Size = new System.Drawing.Size(100, 32);
            this.bntReceber.TabIndex = 14;
            this.bntReceber.Text = "Receber";
            this.bntReceber.UseVisualStyleBackColor = true;
            this.bntReceber.Click += new System.EventHandler(this.bntReceber_Click);
            // 
            // BoletosVendaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 611);
            this.Controls.Add(this.bntReceber);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.radioTodos);
            this.Controls.Add(this.radioTodosPagos);
            this.Controls.Add(this.radioAbertos);
            this.Controls.Add(this.dGVBoletoFornecedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoletosVendaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoletosVendaScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVBoletoFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioTodosPagos;
        private System.Windows.Forms.RadioButton radioAbertos;
        private System.Windows.Forms.DataGridView dGVBoletoFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntReceber;
    }
}