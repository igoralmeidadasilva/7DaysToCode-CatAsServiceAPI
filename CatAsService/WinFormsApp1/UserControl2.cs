using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using RestSharp;
using WinFormsApp1.model;

namespace WinFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        List<Favorito?> listaFavorito = new List<Favorito?>();
        public UserControl2()
        {
            InitializeComponent();
            GetFavoritos();
            LoadListViewFavoritos();
        }

        public void GetFavoritos()
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites");
            var request = new RestRequest("", Method.Get);
            string apiKey = "";
            request.AddHeader("x-api-key", apiKey);
            var response = client.ExecuteGet(request);
            if ((response.StatusCode == System.Net.HttpStatusCode.OK) && (response.Content != null))
            {
                Console.WriteLine("Solicitação GET bem-sucedida:");
                listaFavorito = JsonSerializer.Deserialize<List<Favorito>>(response.Content!)!;
            }
            else
            {
                Console.WriteLine("A solicitação GET falhou. Status: " + response.StatusCode);
                Console.WriteLine(response.ErrorMessage);

            }
        }
        public void LoadListViewFavoritos()
        {
            foreach (var item in listaFavorito)
            {
                string? sub_id = item?.sub_id;
                var client = new RestClient($"https://api.thecatapi.com/v1/breeds/search?q={sub_id}");
                RestRequest request = new RestRequest("", Method.Get);
                var response = client.Execute(request);
                if ((response.StatusCode == System.Net.HttpStatusCode.OK) && (response.Content != null))
                {
                    var gato = JsonSerializer.Deserialize<List<Cat>>(response.Content!)!;
                    foreach (var itemLista in gato)
                    {
                        listView1.Items.Add(itemLista.name);
                    }
                }
                else
                {
                    Console.WriteLine(response.ErrorMessage);
                }
            }
            bloquearBtnExcluir();
        }

        private void buttonExcluirFavorito_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = listView1.SelectedIndices[0];
            Favorito itemSelecionado = listaFavorito[indiceSelecionado!]!;
            string item_id = Convert.ToString(itemSelecionado.id);

            var client = new RestClient($"https://api.thecatapi.com/v1/favourites/{item_id}");
            RestRequest request = new RestRequest("", Method.Delete);
            string apiKey = "";
            request.AddHeader("x-api-key", apiKey);
            var response = client.Execute(request);
            if ((response.StatusCode == System.Net.HttpStatusCode.OK) && (response.Content != null))
            {
                listaFavorito.RemoveAt(indiceSelecionado);
                listView1.Items.RemoveAt(indiceSelecionado);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
            bloquearBtnExcluir();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listaFavorito.Clear();
            GetFavoritos();
            LoadListViewFavoritos();
            bloquearBtnExcluir();
        }
        public void refreshFavortios()
        {
            listView1.Clear();
            listaFavorito.Clear();
            GetFavoritos();
            LoadListViewFavoritos();
            bloquearBtnExcluir(); 
        }
        private void bloquearBtnExcluir()
        {
            if (listView1.Items.Count == 0)
            {
                buttonExcluirFavorito.Enabled = false;
            }
            else
            {
                buttonExcluirFavorito.Enabled = true;
            }
        }
    }
}
