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
	public partial class NewTreinoPage : ContentPage
	{
		public NewTreinoPage ()
        {
            InitializeComponent();
            btSelecionaTreino.Clicked += BotaoSelecionaTreinoClicked;
        }
        
        public async void BotaoSelecionaTreinoClicked(object o, EventArgs e)
        {
            DisplayAlert("Selecionado com sucesso.", "Bom treino!", "Ok");
            //Sair - > await Navigation.PopToRootAsync();
            await Navigation.PopAsync();
        }
    }
}