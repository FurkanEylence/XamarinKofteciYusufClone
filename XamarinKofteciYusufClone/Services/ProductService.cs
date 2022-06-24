using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.Services
{
    public class ProductService
    {
        FirebaseClient client;

        public ProductService()
        {
            client = new FirebaseClient("https://xamarinkofteciyusuf-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Product>> GetProdutcsAsync()
        {
            var products = (await client.Child("FoodItems").OnceAsync<Product>()).Select(f => new Product
            {
                CategoryID = f.Object.CategoryID,
                Name = f.Object.Name,
                Description = f.Object.Description,
                Id = f.Object.Id,
                ImageUrl = f.Object.ImageUrl,
                Price = f.Object.Price

            }).ToList();
            return products;
        }

        public async Task<ObservableCollection<Product>> GetProdutcsByCategoryIDAsync(int id)
        {
            var productsByCategory = new ObservableCollection<Product>();
            var items = (await GetProdutcsAsync()).Where(p => p.CategoryID == id).ToList();
            foreach (var item in items)
            {
                productsByCategory.Add(item);
            }

            return productsByCategory;
        }

        public async Task<ObservableCollection<Product>> GetFavoriItems()
        {
            var products = GetProdutcsByCategoryIDAsync(1);
            return await products;
        }
    }
}
