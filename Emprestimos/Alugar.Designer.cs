namespace Emprestimos
{
    partial class Alugar
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.livros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(264, 231);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // livros
            // 
            this.livros.FormattingEnabled = true;
            this.livros.Location = new System.Drawing.Point(234, 113);
            this.livros.Name = "livros";
            this.livros.Size = new System.Drawing.Size(120, 95);
            this.livros.TabIndex = 1;
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 319);
            this.Controls.Add(this.livros);
            this.Controls.Add(this.cadastrar);
            this.Name = "Alugar";
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.Alugar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ListBox livros;
    }
}