using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealAndTripApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DealAndTripApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            this.BindingContext = new HomePageViewModel();
            InitializeComponent();
            
        }
    }
}