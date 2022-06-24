using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsView : ContentPage
    {
        private ProductDetailsView pvm;
        public ProductDetailsView(Product foodItem)
        {
            InitializeComponent();
            pvm = new ProductDetailsView(foodItem);
            this.BindingContext = pvm;
        }
    }
}