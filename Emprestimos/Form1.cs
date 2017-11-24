using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void livrosPossuidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeusLivros cadastro = new MeusLivros();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraLivro cadastro = new CadastraLivro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void livrosEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivrosEmprestados cadastro = new LivrosEmprestados();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void alugarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alugar cadastro = new Alugar();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDevolucao cadastro = new CadastrarDevolucao();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email cadastro = new Email();
            cadastro.MdiParent = this;
            cadastro.Show();
        }
    }
}
