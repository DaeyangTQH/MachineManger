using Haichann.MachineManager.Command;
using Haichann.MachineManager.Service;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;

namespace Haichann.MachineManager.ViewModel
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private readonly IAuthService _authService;

        public ICommand LoginCommand { get; }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        public LoginVM(IAuthService authService)
        {
            _authService = authService;

            LoginCommand = new RelayCommand(
                _ => Login(),
                _ => CanLogin()
            );
        }

        private void Login()
        {
            bool success = _authService.Login(Username, Password);

            if (!success)
            {
                MessageBox.Show("Login failed");
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username)
                && !string.IsNullOrWhiteSpace(Password);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
