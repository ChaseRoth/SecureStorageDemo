using SecureStorageDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureStorageDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleThreePage : ContentPage
    {
        public ExampleThreePage()
        {
            InitializeComponent();
            BindingContext = new ExampleThreeVM();
        }
    }
}