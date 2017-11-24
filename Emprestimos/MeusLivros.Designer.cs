namespace Emprestimos
{
    partial class MeusLivros
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
            this.Livros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // Livros
            // 
            this.Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Livros.Location = new System.Drawing.Point(148, 32);
            this.Livros.Name = "Livros";
            this.Livros.Size = new System.Drawing.Size(339, 177);
            this.Livros.TabIndex = 0;
            // 
            // MeusLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 281);
            this.Controls.Add(this.Livros);
            this.Name = "MeusLivros";
            this.Text = "MeusLivros";
            this.Load += new System.EventHandler(this.MeusLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Livros;
    }
}