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
    public partial class MeusLivros : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        string user = System.Configuration.ConfigurationSettings.AppSettings["login"];
        public MeusLivros()
        {
            InitializeComponent();
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
                        Livros.DataSource = list;
                        
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o livro : " + response.StatusCode);
                    }
                }


            }
        }

        private void MeusLivros_Load(object sender, EventArgs e)
        {
            GetAllBooks();
        }
    }
}
