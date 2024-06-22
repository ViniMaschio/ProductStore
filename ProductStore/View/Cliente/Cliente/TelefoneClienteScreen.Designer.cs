namespace ProductStore.View.Cliente.Cliente
{
    partial class TelefoneClienteScreen
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
            this.dGVTelefoneCliente = new System.Windows.Forms.DataGridView();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.cBoxTelefone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntNovoTelefone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone Cliente";
            // 
            // dGVTelefoneCliente
            // 
            this.dGVTelefoneCliente.AllowUserToAddRows = false;
            this.dGVTelefoneCliente.AllowUserToDeleteRows = false;
            this.dGVTelefoneCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTelefoneCliente.Location = new System.Drawing.Point(12, 113);
            this.dGVTelefoneCliente.Name = "dGVTelefoneCliente";
            this.dGVTelefoneCliente.ReadOnly = true;
            this.dGVTelefoneCliente.Size = new System.Drawing.Size(282, 179);
            this.dGVTelefoneCliente.TabIndex = 1;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(309, 245);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(109, 33);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Adicionar";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(424, 245);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(109, 33);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Remover";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // cBoxTelefone
            // 
            this.cBoxTelefone.FormattingEnabled = true;
            this.cBoxTelefone.Location = new System.Drawing.Point(309, 143);
            this.cBoxTelefone.Name = "cBoxTelefone";
            this.cBoxTelefone.Size = new System.Drawing.Size(224, 31);
            this.cBoxTelefone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone:";
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(197, 333);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(109, 33);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntNovoTelefone
            // 
            this.bntNovoTelefone.Location = new System.Drawing.Point(410, 113);
            this.bntNovoTelefone.Name = "bntNovoTelefone";
            this.bntNovoTelefone.Size = new System.Drawing.Size(27, 29);
            this.bntNovoTelefone.TabIndex = 7;
            this.bntNovoTelefone.Text = "+";
            this.bntNovoTelefone.UseVisualStyleBackColor = true;
            this.bntNovoTelefone.Click += new System.EventHandler(this.bntNovoTelefone_Click);
            // 
            // TelefoneClienteScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.bntNovoTelefone);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxTelefone);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.dGVTelefoneCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TelefoneClienteScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefoneClienteScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTelefoneCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVTelefoneCliente;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.ComboBox cBoxTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntNovoTelefone;
    }
}