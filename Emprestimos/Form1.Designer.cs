namespace Emprestimos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosPossuidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosEmprestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.alugarLivroToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.livroToolStripMenuItem.Text = "Livro";
            this.livroToolStripMenuItem.Click += new System.EventHandler(this.livroToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosPossuidosToolStripMenuItem,
            this.livrosEmprestadosToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // livrosPossuidosToolStripMenuItem
            // 
            this.livrosPossuidosToolStripMenuItem.Name = "livrosPossuidosToolStripMenuItem";
            this.livrosPossuidosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.livrosPossuidosToolStripMenuItem.Text = "Livros possuidos";
            this.livrosPossuidosToolStripMenuItem.Click += new System.EventHandler(this.livrosPossuidosToolStripMenuItem_Click);
            // 
            // livrosEmprestadosToolStripMenuItem
            // 
            this.livrosEmprestadosToolStripMenuItem.Name = "livrosEmprestadosToolStripMenuItem";
            this.livrosEmprestadosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.livrosEmprestadosToolStripMenuItem.Text = "Livros emprestados";
            this.livrosEmprestadosToolStripMenuItem.Click += new System.EventHandler(this.livrosEmprestadosToolStripMenuItem_Click);
            // 
            // alugarLivroToolStripMenuItem
            // 
            this.alugarLivroToolStripMenuItem.Name = "alugarLivroToolStripMenuItem";
            this.alugarLivroToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alugarLivroToolStripMenuItem.Text = "Alugar Livro";
            this.alugarLivroToolStripMenuItem.Click += new System.EventHandler(this.alugarLivroToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 292);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosPossuidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosEmprestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alugarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
    }
}

