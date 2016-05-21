using System;
using TrabalhoFinalGitHub.Models;
using TrabalhoFinalGitHub.Daos;

using Xamarin.Forms;

namespace TrabalhoFinalGitHub.Views
{
    public partial class UsuarioAlterarExcluirView : ContentPage
    {
        private UsuarioDao usuarioDao = new UsuarioDao();
        private UsuarioModel usuario;

        public UsuarioAlterarExcluirView(UsuarioModel usuarioAlterarExcluir)
        {
            InitializeComponent();

            this.usuario = usuarioAlterarExcluir;
            this.lbID.Text = string.Format("  ID: {0}", usuario.Id);
            this.txtUsuario.Text = usuario.Nome;
            this.btnAlterar.Clicked += BtnAlterar_Clicked;
            this.btnExcluir.Clicked += BtnExcluir_Clicked;
        }

        private async void BtnExcluir_Clicked(object sender, EventArgs e)
        {
            bool excluir = await DisplayAlert("Confirmação", "Confirma exclusão do usuário?", "Sim", "Não");
            if (excluir)
            {
                txtUsuario.IsEnabled = false;
                usuarioDao.DeleteUsuario(usuario);
            }
        }

        private async void BtnAlterar_Clicked(object sender, EventArgs e)
        {
            usuario.Nome = this.txtUsuario.Text;
            usuarioDao.UpdateUsuario(usuario);
            await DisplayAlert("Informação", "Usuário alterado com sucesso!", "Ok");
        }

    }
}
