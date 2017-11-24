namespace Emprestimos
{
    partial class CadastrarDevolucao
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
            this.livros = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // livros
            // 
            this.livros.FormattingEnabled = true;
            this.livros.Location = new System.Drawing.Point(170, 77);
            this.livros.Name = "livros";
            this.livros.Size = new System.Drawing.Size(120, 95);
            this.livros.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.livros);
            this.Name = "CadastrarDevolucao";
            this.Text = "CadastrarDevolucao";
            this.Load += new System.EventHandler(this.CadastrarDevolucao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox livros;
        private System.Windows.Forms.Button button1;
    }
}