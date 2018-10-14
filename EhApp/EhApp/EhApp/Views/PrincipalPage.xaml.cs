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
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Abrindo tela de treino
            MessagingCenter.Subscribe<NewTreinoPage>(this,
                    "NewTreinoPageAbrir",
                    (sender) =>
                    {
                        this.Detail = new NavigationPage(new NewTreinoPage());
                        this.IsPresented = false;
                    });
            MessagingCenter.Subscribe<DietaPage>(this, "DietaPageAbrir",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new DietaPage());
                    this.IsPresented = false;
                });
            MessagingCenter.Subscribe<LoginPage>(this, "LoginPageAbrir",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new LoginPage());
                    this.IsPresented = false;
                });
            MessagingCenter.Subscribe<CompletePerfilPage>(this, "CompletePerfilPageAbrir",
               (sender) =>
               {
                   this.Detail = new NavigationPage(new CompletePerfilPage());
                   this.IsPresented = false;
               });
            MessagingCenter.Subscribe<QuemSomosPage>(this, "QuemSomosPageAbrir",
               (sender) =>
               {
                   this.Detail = new NavigationPage(new QuemSomosPage());
                   this.IsPresented = false;
               });

        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<CompletePerfilPage>(this, "CompletePerfilPageAbrir");
            MessagingCenter.Unsubscribe<NewTreinoPage>(this, "NewTreinoPageAbrir");
            MessagingCenter.Unsubscribe<DietaPage>(this, "DietaPageAbrir");
            MessagingCenter.Unsubscribe<LoginPage>(this, "LoginPageAbrir");
            MessagingCenter.Unsubscribe<QuemSomosPage>(this, "QuemSomosPageAbrir");
        }
    }
}