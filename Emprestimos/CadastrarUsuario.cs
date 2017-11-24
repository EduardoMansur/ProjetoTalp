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
    public partial class CadastrarUsuario : Form
    {
        string URI = System.Configuration.ConfigurationSettings.AppSettings["ApiURI"];
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            AddUsuario();


        }
        async void AddUsuario()
        {
            var newURI = URI + "/Usuarios";
            Usuario newUser = new Usuario();
            newUser.email = txtNome.Text;
            newUser.senha = txtSenha.Text;
            newUser.cep = cep.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(newUser);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(newURI, content);
            }
            this.Hide();
        }
    }
}
