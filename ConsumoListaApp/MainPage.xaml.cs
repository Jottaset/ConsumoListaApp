using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumoListaApp.Model1;
using Xamarin.Forms;

namespace ConsumoListaApp
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked1(object sender, System.EventArgs e)
        {
            Dictionary<string, string> conteudo = new Dictionary<string, string>();

            conteudo.Add("Professor","Ramon");
            conteudo.Add("Aluno", "Michel Temer");
            conteudo.Add("Mito", "Lula");
            conteudo.Add("Oraculo", "Dilma");

            ArrayList lista = new ArrayList();
            List<Mestre> listaMestre = new List<Mestre>();

            foreach(KeyValuePair<string, string> conteudoDaLista in conteudo)
            {
                Mestre mestre = new Mestre();

                mestre.nome = conteudoDaLista.Value;
                mestre.tipo = conteudoDaLista.Key;

                listaMestre.Add(mestre);
            }

         //   var listaItens = conteudo.Keys.ToList();
         //   ArrayList lista = new ArrayList();
         //
         //   lista.Add(listaItens[i]);
         //
         //   for(int i = 0; i <listaItens.Count; i++)
         //   {
         //       if (listaItens[i] == "Oraculo")
         //       {
         //       }
                
         //   }

            ListaMunicipio.ItemsSource = listaMestre;
        }

        void Save_Clicked(object sender, System.EventArgs e)
        {

        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
