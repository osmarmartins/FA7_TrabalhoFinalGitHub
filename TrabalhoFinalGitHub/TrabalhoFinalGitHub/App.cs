using Xamarin.Forms;

namespace TrabalhoFinalGitHub
{
    public class App : Application
    {
        public string NovoUsuario { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new Views.HomeView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
