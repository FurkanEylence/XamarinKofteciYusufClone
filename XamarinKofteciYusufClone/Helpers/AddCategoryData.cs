using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        private FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://xamarinkofteciyusuf-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category(){ Id = 1, ImageUrl = "logo.jpg", Name = "FAVORİ LEZZETLER" },
                new Category(){ Id = 2, ImageUrl = "kasap.jpg", Name = "ÇİĞ ÜRÜNLER" },
                new Category(){ Id = 3, ImageUrl = "izgara_etler.jpg", Name = "IZGARA ETLER"},
                new Category(){ Id = 4, ImageUrl = "ekmek_arasi.jpg", Name = "EKMEK ARASI"},
                new Category(){ Id = 5, ImageUrl = "tatli_icecek.jpg", Name = "TATLI - İÇECEK"}
            };
        }

        public async Task AddCategoryAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        Id = category.Id,
                        Name = category.Name,
                        ImageUrl = category.ImageUrl
                    });
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", e.Message, "OK");
            }
        }
    }
}
