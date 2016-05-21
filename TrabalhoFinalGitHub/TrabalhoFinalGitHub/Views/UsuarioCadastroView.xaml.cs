
using Xamarin.Forms;


namespace TrabalhoFinalGitHub.Views
{
    public partial class UsuarioCadastroView : ContentPage
    {
        public UsuarioCadastroView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.UsuarioViewModel();

            this.listaUsuarios.ItemTapped += ListaUsuarios_ItemTapped;

        }

        private async void ListaUsuarios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new Views.UsuarioAlterarExcluirView((Models.UsuarioModel) e.Item));
        }
    }
}
