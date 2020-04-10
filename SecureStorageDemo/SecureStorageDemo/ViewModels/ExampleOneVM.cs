using System;
using SecureStorageDemo.Util;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SecureStorageDemo.ViewModel
{
    public class ExampleOneVM : NotifyClass
    {
        // The property our UI label is bound to
        private string tokenValue;
        public string TokenValue {
            get => tokenValue;
            private set
            {
                tokenValue = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        ///     Command that handles the GetTokenValue button being clicked
        /// </summary>
        public ICommand GetTokenValueCMD => new Command(async () => {
            try
            {
                // Retrieving our test token's value using the key we initialized in our App class
                TokenValue = await SecureStorage.GetAsync(App.TEST_TOKEN_KEY);
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
        });
    }
}
