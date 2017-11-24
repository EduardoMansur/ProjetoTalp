namespace Emprestimos
{
    partial class CadastraLivro
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
            this.nome = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.editora = new System.Windows.Forms.Label();
            this.editoraBox = new System.Windows.Forms.TextBox();
            this.cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(127, 77);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(36, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "nome:";
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(181, 77);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(100, 20);
            this.nomeBox.TabIndex = 1;
            // 
            // editora
            // 
            this.editora.AutoSize = true;
            this.editora.Location = new System.Drawing.Point(127, 111);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(42, 13);
            this.editora.TabIndex = 0;
            this.editora.Text = "editora:";
            // 
            // editoraBox
            // 
            this.editoraBox.Location = new System.Drawing.Point(181, 111);
            this.editoraBox.Name = "editoraBox";
            this.editoraBox.Size = new System.Drawing.Size(100, 20);
            this.editoraBox.TabIndex = 1;
            // 
            // cadastro
            // 
            this.cadastro.Location = new System.Drawing.Point(224, 173);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(75, 23);
            this.cadastro.TabIndex = 2;
            this.cadastro.Text = "cadastrar";
            this.cadastro.UseVisualStyleBackColor = true;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // CadastraLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 261);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.editoraBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.editora);
            this.Controls.Add(this.nome);
            this.Name = "CadastraLivro";
            this.Text = "CadastraLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label editora;
        private System.Windows.Forms.TextBox editoraBox;
        private System.Windows.Forms.Button cadastro;
    }
}