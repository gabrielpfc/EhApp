using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EhApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EhApp.Views.LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MessagingCenter.Subscribe<ViewModel.LoginViewModel>(this, "LoginSucesso",
                (sender) =>
                {
                    MainPage = new Views.PrincipalPage();
                });
            MessagingCenter.Subscribe<ViewModel.LoginViewModel>(this, "AbrirCadastro",
                (sender) =>
                {
                    MainPage = new Views.CadastroPage();
                });

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
