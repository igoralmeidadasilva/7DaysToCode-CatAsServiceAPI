using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using RestSharp;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private IList<Cat?> listaRacas = new List<Cat?>();
        public UserControl1()
        {
            InitializeComponent();
            getRacas();
            loadComboBox();
        }

        private void loadComboBox()
        {
            comboBoxRaca.DataSource = listaRacas;
            comboBoxRaca.ValueMember = "name";
            comboBoxRaca.DisplayMember = "name";
        }

        private void getRacas()
        {
            var client = new RestClient("https://api.thecatapi.com/v1/breeds/");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);
            if ((response.StatusCode == System.Net.HttpStatusCode.OK) && !string.IsNullOrEmpty(response.Content))
            {
                listaRacas = JsonSerializer.Deserialize<List<Cat?>>(response.Content!)!;
            }
            else
            {
                MessageBox.Show("Campos de busca obrigatórios!");
                Console.WriteLine(response.ErrorMessage);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Cat? cat = comboBoxRaca.SelectedItem as Cat;
            if (cat != null)
            {
                labelTemperamento.Text = cat.temperament;
                labelOrigem.Text = cat.origin;
                labelDescricao.Text = cat.description;
            } else {
                MessageBox.Show("A Raça não existe!");
            }
        }

        private void buttonFavoritar_Click(object sender, EventArgs e)
        {
            if (comboBoxRaca.SelectedItem != null) {
                 Cat? cat = comboBoxRaca.SelectedItem as Cat;
                 var client = new RestClient("https://api.thecatapi.com/v1/favourites");
                 var request = new RestRequest("", Method.Post);
                 string apiKey = "";
                 request.AddHeader("x-api-key", apiKey);
                 request.AddJsonBody(new { image_id = cat?.reference_image_id, sub_id = cat?.id });
                 var response = client.ExecutePost(request);
                if ((response.StatusCode == System.Net.HttpStatusCode.OK) && (response != null)) {
                    var data = JsonSerializer.Deserialize<JsonNode>(response.Content!)!;
                    MessageBox.Show("Solicitação POST foi bem sucedida!");
                    labelTemperamento.Text = "";
                    labelOrigem.Text = "";
                    labelDescricao.Text = "";
                } else {
                    MessageBox.Show("Erro: " + response?.StatusCode);
                    labelTemperamento.Text = "";
                    labelOrigem.Text = "";
                    labelDescricao.Text = "";
                }
            }
        }
    }
}
