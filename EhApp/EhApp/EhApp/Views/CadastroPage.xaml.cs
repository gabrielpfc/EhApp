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
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
            BotaoCancelar.Clicked += BotaoSairClicked;
            BotaoCadastrar.Clicked += BotaoCadastrarClicked;
        }


        public void BotaoSairClicked(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
        public void BotaoCadastrarClicked(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new CadastroPage());
        }


    }
}