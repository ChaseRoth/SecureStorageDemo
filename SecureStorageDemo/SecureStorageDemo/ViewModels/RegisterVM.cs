using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;

namespace SecureStorageDemo.ViewModels
{
    public class RegisterVM
    {
        #region Login Properties
        public string Username { get; set; } = string.Empty;

        string password = string.Empty;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                (SaveCMD as Command).ChangeCanExecute();
            }
        }
        #endregion

        #region Login Commands
        // Cancel Command
        public ICommand CancelCMD => new Command(() => App.Current.MainPage.Navigation.PopModalAsync());
        // Save Command
        public ICommand SaveCMD { get; private set; }
        #endregion 

        public RegisterVM()
        {
            SaveCMD = new Command(
            execute: () =>
            {
                // Saving the user's credentials using SecureStorage.
                SecureStorage.SetAsync("username", Username);
                SecureStorage.SetAsync("password", Password);
                App.Current.MainPage.Navigation.PopModalAsync();
            },
            canExecute: () =>
            {
                return !string.IsNullOrWhiteSpace(Username) &&
                       !string.IsNullOrWhiteSpace(Password) &&
                       Password.Length >= 3;
            });
        }
    }
}
