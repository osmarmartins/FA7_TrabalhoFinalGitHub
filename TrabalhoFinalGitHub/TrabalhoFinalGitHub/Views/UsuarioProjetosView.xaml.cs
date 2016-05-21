using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalGitHub.Utilities;
using Xamarin.Forms;

namespace TrabalhoFinalGitHub.Views
{
    public partial class UsuarioProjetosView : ContentPage
    {
        public UsuarioProjetosView()
        {
            InitializeComponent();

            listViewUsuarios.ItemsSource = new Daos.UsuarioDao().FindAllUsuario();
            listViewUsuarios.ItemSelected += ListViewUsuarios_ItemSelected;
            
        }

        private async void ListViewUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var gitHubRepositories = new GitHubRepositories();
            var lista = await gitHubRepositories.GetRepositories(listViewUsuarios.SelectedItem.ToString());
            repositories.ItemsSource = lista;
        }
    }
}

