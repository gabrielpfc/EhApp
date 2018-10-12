using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EhApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
        {
            InitializeComponent();
            //BotaoLogin.Clicked += LoginClicked;
            BotaoLogin.Clicked += AbrirMenuClicked;
        }


        public async void AbrirMenuClicked(Object o, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());
        }

        //await Navigation.PushAsync(new MenuPage()); 

        public void LoginClicked(Object o, EventArgs e)
        {
            DisplayAlert("Título", "Mensagem Teste", "Ok");
        }
    }
}