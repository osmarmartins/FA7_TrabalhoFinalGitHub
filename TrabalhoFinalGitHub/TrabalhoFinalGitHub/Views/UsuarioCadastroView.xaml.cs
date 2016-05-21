
using Xamarin.Forms;


namespace TrabalhoFinalGitHub.Views
{
    public partial class UsuarioCadastroView : ContentPage
    {
        public UsuarioCadastroView()
        {
            InitializeComponent();
            this.listaUsuarios.ItemTapped += ListaUsuarios_ItemTapped;
            this.txtUsuario.TextChanged += TxtUsuario_TextChanged;
            this.Appearing += UsuarioCadastroView_Appearing;

        }

        private void UsuarioCadastroView_Appearing(object sender, System.EventArgs e)
        {
            try
            {
                this.BindingContext = new ViewModels.UsuarioViewModel();
            }
            catch (System.Exception)
            {
                DisplayAlert("Alerta", "Não existe usuários cadastrados", "Ok");
            }
        }

        private void TxtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            App app = Application.Current as App;
            app.NovoUsuario = txtUsuario.Text;
        }

        private async void ListaUsuarios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushModalAsync(new Views.UsuarioAlterarExcluirView((Models.UsuarioModel) e.Item));
        }
    }
}
