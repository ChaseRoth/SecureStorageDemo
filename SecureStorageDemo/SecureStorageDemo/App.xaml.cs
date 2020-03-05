using SecureStorageDemo.Pages;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureStorageDemo
{
    public partial class App : Application
    {
        public const string TEST_TOKEN_KEY = "test_token";
        public const string SYNC_TOKEN_KEY = "sync_token";

        public App()
        {
            InitializeComponent();
            MainPage = new MasterTabbedPage();
        }

        protected async override void OnStart()
        {
            try
            {
                // Storing the string to the disked based off the key
                //await SecureStorage.SetAsync(TEST_TOKEN_KEY, "In C# 8.0 we can give our interfaces default implementation.");
                //await SecureStorage.SetAsync(SYNC_TOKEN_KEY, "MjE1MDg5QDMxMzcyZTM0MmUzMEFvaWJYdzFIeFoxMDE5SEZWQ3FlRmF1VUgxelFvdklNaXNxZUFva25DYkU9");
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
