using Emprestimos.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimos
{
    public partial class CadastraLivro : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        string user = System.Configuration.ConfigurationSettings.AppSettings["login"];
        public CadastraLivro()
        {
            InitializeComponent();
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            AddLivro();
        }
        async void AddLivro()
        {
            var newURI = URI + "/Livros";
            Livro newBook = new Livro();
            newBook.nome = nomeBox.Text;
            newBook.editora = editoraBox.Text;
            newBook.idUsuario = user;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(newBook);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }
            this.Hide();
        }
    }
    
}
