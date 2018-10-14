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
	public partial class PerfilPage : ContentPage
	{
		public PerfilPage ()
        {
            InitializeComponent();
        }

        public void SairClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<LoginPage>(new LoginPage(), "LoginPageAbrir");
        }

        public void TreinoClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<NewTreinoPage>(new NewTreinoPage(), "NewTreinoPageAbrir");
        }

        public void DietaClicked (object o, EventArgs e)
        {
            MessagingCenter.Send<DietaPage>(new DietaPage(), "DietaPageAbrir");
        }

        public void EditarClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<CompletePerfilPage>(new CompletePerfilPage(), "CompletePerfilPageAbrir");
        }

        public void QuemSomosClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<QuemSomosPage>(new QuemSomosPage(), "QuemSomosPageAbrir");
        }
    }
}