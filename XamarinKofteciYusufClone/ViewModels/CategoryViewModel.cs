using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;
using XamarinKofteciYusufClone.Services;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        private Category _SelectedCategory;

        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedCategory;
            }
        }

        public ObservableCollection<Product> FoodItemsByCategory { get; set; }

        private int _TotalFoodItems;

        public int TotalFoodItems
        {
            set
            {
                _TotalFoodItems = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalFoodItems;
            }
        }

       
        public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            FoodItemsByCategory = new ObservableCollection<Product>();
            GetFoodItems(category.Id);
        }

        public async void GetFoodItems(int categoryId)
        {
            var data = await new ProductService().GetProdutcsByCategoryIDAsync(categoryId);
            FoodItemsByCategory.Clear();
            foreach (var item in data)
            {
                FoodItemsByCategory.Add(item);
            }

            TotalFoodItems = FoodItemsByCategory.Count;
        }
    }
}
