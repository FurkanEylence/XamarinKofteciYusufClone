using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.Services
{
    public class CategoryService
    {
        FirebaseClient client;

        public CategoryService()
        {
            client = new FirebaseClient("https://xamarinkofteciyusuf-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Category>> GetCategoryAsync()
        {
            var category = (await client.Child("Categories").OnceAsync<Category>()).Select(c => new Category
            {
                Id = c.Object.Id,
                Name = c.Object.Name,
                ImageUrl = c.Object.ImageUrl,
                Products = c.Object.Products

            }).ToList();

            return category;
        }
    }
}
