using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TecnologicoApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand => new Command(OnLogin);

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnLogin()
        {
            // Validar el correo electrónico y la contraseña aquí
            if (Email == "usuarios@gmail.com" && Password == "Password1234")
            {
                // Mostrar mensaje de inicio de sesión correcto
                Application.Current.MainPage.DisplayAlert("Inicio de Sesión", "Ha iniciado sesión correctamente", "OK");
            }
            else
            {
                // Mostrar mensaje de error de inicio de sesión
                Application.Current.MainPage.DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }
    }
}
