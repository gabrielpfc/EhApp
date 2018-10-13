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
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
            BotaoCancelar.Clicked += BotaoSairClicked;
            BotaoCadastrar.Clicked += BotaoCadastrarClicked;
        }


        public async void BotaoSairClicked(object o, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        public async void BotaoCadastrarClicked(object o, EventArgs e)
        {
            await Navigation.PushAsync(new CompletePerfilPage());
        }


    }
}