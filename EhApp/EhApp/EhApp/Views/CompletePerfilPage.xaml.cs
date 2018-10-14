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
	public partial class CompletePerfilPage : ContentPage
	{
		public CompletePerfilPage ()
        {
            InitializeComponent();
            BtSalvar.Clicked += BtSalvarClicked;
            PickerObjetivo.Items.Add("Condicionamento fisico");
            PickerObjetivo.Items.Add("Redução de estresse");
            PickerObjetivo.Items.Add("Perda de peso");
            PickerObjetivo.Items.Add("Hipertrofia");
        }


        public void BtSalvarClicked(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

    }
}