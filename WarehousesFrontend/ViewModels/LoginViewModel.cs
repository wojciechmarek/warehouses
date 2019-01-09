using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarehousesFrontend.Commands;
using WarehousesFrontend.Services;

namespace WarehousesFrontend.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginButton { get; set; }
        public Action CloseAction { get; set; }

        private string loginInput;
        public string LoginInput
        {
            get { return loginInput; }
            set { loginInput = value; }
        }

        private string passwordInput;
        public string PasswordInput
        {
            get { return passwordInput; }
            set { passwordInput = value; }
        }

        Service _services;
        MainWindow mainWindow;


        public LoginViewModel()
        {
            _services = new Service();
            mainWindow = new MainWindow();
            LoginButton = new RelayCommand(Login);
        }

        private void Login(object obj)
        {
            var existUser = _services.IsUserExist(LoginInput, PasswordInput);

            if (existUser)
            {
                CloseAction();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło", "Błąd", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
