using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EhApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
        {
            InitializeComponent();
            Ehicon.Source = ImageSource.FromFile("icon.png");
            //BotaoLogin.Clicked += LoginClicked;
            //BotaoLogin.Clicked += AbrirMenuClicked;
            //BotaoCadastro.Clicked += AbrirCadastroClicked;
        }


        //public async void AbrirMenuClicked(Object o, EventArgs e)
        //{
        //    await Navigation.PushAsync(new PerfilPage());
        //}

        //public async void AbrirCadastroClicked(Object o, EventArgs e)
        //{
          //  await Navigation.PushAsync(new CadastroPage());
        //}

        //await Navigation.PushAsync(new MenuPage()); 

        //public void LoginClicked(Object o, EventArgs e)
        //{
        //    DisplayAlert("Título", "Mensagem Teste", "Ok");
        //}
    }
}