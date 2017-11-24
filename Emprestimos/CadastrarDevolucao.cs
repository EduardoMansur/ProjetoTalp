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
    public partial class CadastrarDevolucao : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        string user = System.Configuration.ConfigurationSettings.AppSettings["login"];
  
        int idMaterial = 1;
        List<string> names = new List<string>();
        List<int> ids = new List<int>();
        List<Livro> livrosList = new List<Livro>();
        List<Emprestimo> emprestimos = new List<Emprestimo>();
        Emprestimo old = new Emprestimo();
        public CadastrarDevolucao()
        {
            InitializeComponent();
        }

        private void CadastrarDevolucao_Load(object sender, EventArgs e)
        {
            GetAllBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            old = emprestimos[livros.SelectedIndex];
            UpdatEmprestimo(emprestimos[livros.SelectedIndex].idEmprestimo);
            
        }
        private async void GetAllBooks()
        {
            var newURI = URI + "/Livros/search/" + user;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Livro[]>(ProdutoJsonString).ToList();
                        list.ForEach(addLivroList);
                        GetAllEmprestimos();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o livro : " + response.StatusCode);
                    }
                }


            }
        }
        void addLivroList(Livro s)
        {
            livrosList.Add(s);
            names.Add(s.nome);

        }
        private async void UpdatEmprestimo(int codProduto)
        {
            var newURI = URI + "/Emprestimos";
            old.devolvido = 1;

            using (var client = new HttpClient())
            {

                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(newURI + "/" + old.idEmprestimo, old);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");

                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
        }

        private async void GetAllEmprestimos()
        {
            var newURI = URI + "/Emprestimos";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                     
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Emprestimo[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                        livros.DataSource = names;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }


            }
        }
        void get(Model.Emprestimo s)
        {
             foreach (Livro element in livrosList)
            {
                if (element.idLivro.Equals(s.idLivro))
                {
                    emprestimos.Add(s);
                }
            }
           
        }
       
    }
}
