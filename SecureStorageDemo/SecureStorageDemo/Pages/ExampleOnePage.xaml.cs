using SecureStorageDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SecureStorageDemo.Pages
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ExampleOnePage : ContentPage
    {
        public ExampleOnePage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }
    }
}
