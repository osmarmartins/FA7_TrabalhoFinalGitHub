using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrabalhoFinalGitHub.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
        }

        public async void CadastrarUsuario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UsuarioCadastroView());
        }

        public async void ListarProjetos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UsuarioProjetosView());
        }
    }
}
