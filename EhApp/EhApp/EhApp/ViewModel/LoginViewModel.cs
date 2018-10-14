using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace EhApp.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand EntrarClickedCommand { get; private set; }

        public ICommand CadastrarClickedCommand { get; private set; }

        public LoginViewModel()
        {
            EntrarClickedCommand = new Command(() => {
                MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
            });

            CadastrarClickedCommand = new Command(() => {
                MessagingCenter.Send<LoginViewModel>(this, "AbrirCadastro");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string senha;
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (senha != value)
                {
                    senha = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
