using SecureStorageDemo.Pages;
using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;

namespace SecureStorageDemo.ViewModels
{
    public class ExampleThreeVM
    {
        #region Login Properties
        private string username = string.Empty;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                (LoginCMD as Command).ChangeCanExecute();
            }
        }

        private string password = string.Empty;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                (LoginCMD as Command).ChangeCanExecute();
            }
        }
        #endregion

        #region Login Commands
        public ICommand RegisterCMD => new Command(() =>
        {
            App.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
        });

        public ICommand LoginCMD => new Command(
        execute: () => 
        {
            // If the user's entered creditentials don't match
            //  1: Send an error msg
            //  2: Return false
            if (Username == SecureStorage.GetAsync("username").Result &&
                Password == SecureStorage.GetAsync("password").Result)
            {
                App.Current.MainPage.DisplayAlert("Login Successfull", "You remembered your username and password.. good job!", "OK");                
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Login Error", "Username or password is invalid.", "OK");
            }
        });
        #endregion
    }
}
