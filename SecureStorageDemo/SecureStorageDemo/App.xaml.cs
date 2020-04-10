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
            // If this is the first time the application is running; we will set some keys.
            if (VersionTracking.IsFirstLaunchEver)
            {
                try
                {
                    // Storing the string to the disked based off the key
                    // Key/Value
                    await SecureStorage.SetAsync(TEST_TOKEN_KEY, "My important message: In C# 8.0 we can give our interfaces default implementation.");
                    await SecureStorage.SetAsync(SYNC_TOKEN_KEY, "MjE1MDg5QDMxMzcyZTM0MmUzMEFvaWJYdzFIeFoxMDE5SEZWQ3FlRmF1VUgxelFvdklNaXNxZUFva25DYkU9");
                }
                catch (Exception ex)
                {
                    // Its possible that device doesn't support secure storage on device.
                }
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
