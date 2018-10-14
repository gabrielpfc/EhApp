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
	public partial class DietaPage : ContentPage
	{
		public DietaPage ()
        {
            InitializeComponent();
            BotaoVoltar.Clicked += BotaoVoltarClicked;
            BotaoSair.Clicked += BotaoSairClicked;
        }

        public void BotaoSairClicked(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
        public void BotaoVoltarClicked(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

    }
}