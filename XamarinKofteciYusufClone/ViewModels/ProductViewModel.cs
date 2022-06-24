using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinKofteciYusufClone.Models;
using XamarinKofteciYusufClone.Services;
using XamarinKofteciYusufClone.Views;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private string _UserName;
        public string UserName
        {
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
            get
            {
                return _UserName;
            }
        }

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }
            get
            {
                return _UserCartItemsCount;
            }
        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> LatestItems { get; set; }

        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }
        public ProductViewModel()
        {
            var uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
                UserName = "Guest";
            else
            {
                UserName = uname;
            }

            UserCartItemsCount = new CartItemService().GetUserCartCount();
            Categories = new ObservableCollection<Category>();
            LatestItems = new ObservableCollection<Product>();

            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogoutCommand = new Command(async async => await LogoutAsync());

            GetCategories();
            GetLatestItems();

            var categoryService = new CategoryService();

        }

        private async Task LogoutAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LogoutView());
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }

        private async void GetLatestItems()
        {
            var data = await new ProductService().GetFavoriItems();
            LatestItems.Clear();
            foreach (var item in data)
            {
                LatestItems.Add(item);
            }
        }

        private async void GetCategories()
        {
            var data = await new CategoryService().GetCategoryAsync();
            Categories.Clear();
            foreach (var item in data)
            {
                Categories.Add(item);
            }
        }
    }
}
