using SecureStorageDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureStorageDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleTwoPage : ContentPage
    {
        public ExampleTwoPage()
        {
            InitializeComponent();
            BindingContext = new ExampleTwoVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(await SecureStorage.GetAsync(App.SYNC_TOKEN_KEY));
        }
    }
}