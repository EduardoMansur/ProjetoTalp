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
    public partial class Alugar : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        string user = System.Configuration.ConfigurationSettings.AppSettings["login"];

        int idMaterial = 1;
        List<string> names = new List<string>();
        List<Livro> livrosList = new List<Livro>();
        public Alugar()
        {
            InitializeComponent();
        }


        private async void GetAllBooks()
        {
            var newURI = URI + "/Livros";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Livro[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                        livros.DataSource = names;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o livro : " + response.StatusCode);
                    }
                }


            }
        }
        void get(Model.Livro s)
        {
            livrosList.Add(s);
            names.Add(s.nome);
        }
        async void AddEmprestimo()
        {
            var newURI = URI + "/Emprestimos";
            Emprestimo prod = new Emprestimo();
            prod.idLivro = livrosList[livros.SelectedIndex].idLivro;
            prod.devolvido = 0;
            prod.idUsuario = user;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            AddEmprestimo();
        }

        private void Alugar_Load(object sender, EventArgs e)
        {
            GetAllBooks();
        }
    }
}
