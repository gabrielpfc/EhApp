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
	public partial class PerfilPage : ContentPage
	{
		public PerfilPage ()
        {
            InitializeComponent();
            BotaoSair.Clicked += BotaoSairClicked;
            BtNovoTreino.Clicked += BotaoNovoTreinoClicked;
            Bttemp.Clicked += BotaoTempClicked;
        }

        public async void BotaoSairClicked(object o, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        public async void BotaoNovoTreinoClicked(object o, EventArgs e)
        {
            await Navigation.PushAsync(new NewTreinoPage());
        }

        public async void BotaoTempClicked (object o, EventArgs e)
        {
            await Navigation.PushAsync(new CompletePerfilPage());
        }
    }
}