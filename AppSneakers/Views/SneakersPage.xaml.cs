using AppSneakers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSneakers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SneakersPage : ContentPage
    {
        public SneakersPage()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}