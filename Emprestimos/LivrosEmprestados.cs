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
    public partial class LivrosEmprestados : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        string user = System.Configuration.ConfigurationSettings.AppSettings["login"];

        List<Livro> meusLivrosEmprestados = new List<Livro>();

        public object Livros { get; private set; }

        public LivrosEmprestados()
        {
            InitializeComponent();
        }

        private void LivrosEmprestados_Load(object sender, EventArgs e)
        {
            GetAllEmprestimos();
        }
        private async void GetAllEmprestimos()
        {
            var newURI = URI + "/Emprestimos" ;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Emprestimo[]>(ProdutoJsonString).ToList();
                        list.ForEach(verificaLivro);
                        livros.DataSource = this.meusLivrosEmprestados;

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }


            }
        }
        void verificaLivro(Emprestimo s)
        {
            if( s.devolvido == 0)
            {
                GetAllBookById(s.idLivro);
            }
            
        }

        private async void GetAllBookById(int id)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                var newURI = URI + "/Livros/" + id;

                HttpResponseMessage response = await client.GetAsync(newURI);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var old = JsonConvert.DeserializeObject<Livro>(ProdutoJsonString);
                    if (old.idUsuario.Equals(user))
                    {
                        meusLivrosEmprestados.Add(old);
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }

        }
        
    }
}
