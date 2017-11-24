using Emprestimos.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimos
{
    public partial class Login : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            GetAllUsers();

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async void GetAllUsers()
        {
            var newURI = URI + "/Usuarios";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(newURI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        var list = JsonConvert.DeserializeObject<Model.Usuario[]>(ProdutoJsonString).ToList();
                        list.ForEach(get);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o usuario : " + response.StatusCode);
                    }
                }
            }
        }
        void get(Model.Usuario s)
        {

            if (txtNome.Text.Equals(s.email) &&
                txtSenha.Text.Equals(s.senha))
            {
                this.Hide();
                UpdateSetting("login", s.email);
                Form1 form = new Form1();
                form.Show();
            }
       
        }
        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastro = new CadastrarUsuario();

            cadastro.Show();
        }
    }
}

