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
    public partial class CategoryView : ContentPage
    {
        private CategoryViewModel cvm;
        public CategoryView(Category category)
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;
        }

        public async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductDetailsView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}