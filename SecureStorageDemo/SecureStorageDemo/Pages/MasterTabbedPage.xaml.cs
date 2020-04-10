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
    public partial class MasterTabbedPage : TabbedPage
    {
        public MasterTabbedPage()
        {
            InitializeComponent();

            this.Children.Add(new ExampleOnePage() { Title = "Ex. 1" });
            this.Children.Add(new ExampleTwoPage() { Title = "Ex. 2" });
            this.Children.Add(new ExampleThreePage() { Title = "Ex. 3" });
        }
    }
}