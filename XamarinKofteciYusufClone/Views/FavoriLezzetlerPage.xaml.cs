using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinKofteciYusufClone.Models;
using XamarinKofteciYusufClone.ViewModels;

namespace XamarinKofteciYusufClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriLezzetlerPage : ContentPage
    {
        public FavoriLezzetlerPage()
        {
            InitializeComponent();
            BindingContext = new FavoriLezzetlerViewModel();
        }
    }
}