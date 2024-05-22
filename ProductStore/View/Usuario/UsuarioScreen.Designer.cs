namespace ProductStore.View.Usuario
{
    partial class UsuarioScreen
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
            this.dGWUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGWUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dGWUsuario
            // 
            this.dGWUsuario.AllowUserToDeleteRows = false;
            this.dGWUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWUsuario.Location = new System.Drawing.Point(143, 92);
            this.dGWUsuario.Name = "dGWUsuario";
            this.dGWUsuario.ReadOnly = true;
            this.dGWUsuario.Size = new System.Drawing.Size(444, 268);
            this.dGWUsuario.TabIndex = 0;
            // 
            // UsuarioScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGWUsuario);
            this.Name = "UsuarioScreen";
            this.Text = "UsuarioScreen";
            this.Load += new System.EventHandler(this.UsuarioScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGWUsuario;
    }
}