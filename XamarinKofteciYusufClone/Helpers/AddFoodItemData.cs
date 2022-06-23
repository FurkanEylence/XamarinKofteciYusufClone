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
    public class AddFoodItemData
    {
        private FirebaseClient client;
        public List<Product> FoodItems { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://xamarinkofteciyusuf-default-rtdb.firebaseio.com/");
            FoodItems = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_burger-koftesi_21.05.2021_02_05_37.jpg",
                    Name = "Burger Köftesi", Description = "1 Kg", Price = 106, CategoryID = 2
                },
                new Product
                {
                    Id = 2, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/dana-kiyma_21.05.2021_02_06_34.jpg",
                    Name = "Dana Kıyma", Description = "1 Kg", Price = 110, CategoryID = 2
                },
                new Product
                {
                    Id = 3, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-kusbasi_21.05.2021_02_08_53.jpg", 
                    Name = "Dana Kusbası", Description = "1 Kg", Price = 126, CategoryID = 2
                },
                new Product()
                {
                    Id = 4, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-kavurma_21.05.2021_02_12_27.jpg", 
                    Name = "Dana Kavurma", Description = "1 Kg", Price = 152, CategoryID = 2
                },
                new Product()
                {
                    Id = 5, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_biftek_30.09.2020_09_38_24.jpg", 
                    Name = "Dana Biftek", Description = "1 Kg", Price = 136, CategoryID =2
                },
                new Product()
                {
                    Id = 6, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-antrikot_27.07.2019_12_51_33.jpg", 
                    Name = "Dana Antrikot", Description = "1 Kg", Price = 160, CategoryID =2
                },
                new Product()
                {
                    Id = 7, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-gerdan_21.05.2021_02_09_44.jpg", 
                    Name = "Kuzu Gerdan", Description = "1 Kg", Price = 90, CategoryID = 2
                },
                new Product()
                {
                    Id = 8, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-pirzola_30.09.2020_10_32_59.jpg", 
                    Name = "Kuzu Pirzola", Description = "1 Kg", Price = 200, CategoryID = 2
                },
                new Product()
                {
                    Id = 9, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-sis_21.05.2021_04_15_45.jpg", 
                    Name = "Kuzu Şiş", Description = "200 gram", Price = 60, CategoryID = 3
                },
                new Product()
                {
                    Id = 10, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-kuzu-beyti_21.05.2021_12_12_04.jpg", 
                    Name = "Kuzu Beyti", Description = "200 gram", Price = 60, CategoryID = 3
                },new Product()
                {
                    Id = 11, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-pirzola_06.10.2021_04_02_19.jpg", 
                    Name = "Kuzu Pirzola", Description = "200 gram", Price = 60, CategoryID = 3
                },
                new Product()
                {
                    Id = 12, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_antrikot_21.05.2021_04_13_58.jpg", 
                    Name = "Dana Antrikot", Description = "200 gram", Price = 60, CategoryID = 3
                },
                new Product()
                {
                    Id = 13, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-pilic-incik_21.05.2021_11_15_52.jpg", 
                    Name = "Pilic İncik", Description = "200 gram", Price = 34, CategoryID = 3
                },
                new Product()
                {
                    Id = 14, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_pilic-kasrisik_07.10.2021_05_51_13.jpg", 
                    Name = "Pilic Karışık", Description = "200 gram", Price = 34, CategoryID = 3
                },
                new Product()
                {
                    Id = 15, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-pilic-kanat_21.05.2021_12_16_14.jpg", 
                    Name = "Piliç Kanat", Description = "200 gram", Price = 34, CategoryID = 3
                },
                new Product()
                {
                    Id = 16, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-sis-antrikot_21.05.2021_12_22_00.jpg", 
                    Name = "Dana-Kuzu Et Karışık", Description = "200 gram", Price = 60, CategoryID = 3
                },new Product()
                {
                    Id = 17, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_yarim-sucuk_24.08.2021_12_06_57.jpg", 
                    Name = "Sucuk", Description = "Yarım Ekmek", Price = 25, CategoryID = 4
                },new Product()
                {
                    Id = 18, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tam-sucuk_24.08.2021_12_08_37.jpg", 
                    Name = "Sucuk", Description = "Tam Ekmek", Price = 35,CategoryID = 4
                },
                new Product()
                {
                    Id = 19, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_yarim-kofteee_24.08.2021_12_00_40.jpg", 
                    Name = "Köfte", Description = "Yarım Ekmek", Price = 25, CategoryID = 4
                },
                new Product()
                {
                    Id = 20, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tam-kofte_24.08.2021_12_07_24.jpg", 
                    Name = "Köfte", Description = "Tam Ekmek", Price = 35, CategoryID = 4
                },
                new Product()
                {
                    Id = 21, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_yarim-doner_24.08.2021_12_06_31.jpg", 
                    Name = "Döner", Description = "Yarım Ekmek", Price = 25, CategoryID = 4
                },
                new Product()
                {
                    Id = 22, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tam-doner_24.08.2021_12_08_18.jpg", 
                    Name = "Döner", Description = "Tam Ekmek", Price = 35, CategoryID = 4
                },new Product()
                {
                    Id = 23, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tekkofte-burger_24.08.2021_12_06_00.jpg", 
                    Name = "Burger", Description = "Yarım Ekmek", Price = 25, CategoryID = 4
                },
                new Product()
                {
                    Id = 24, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ciftkofte-burgerjpg_24.08.2021_12_07_45.jpg", 
                    Name = "Burger", Description = "Tam Ekmek", Price = 35, CategoryID = 4
                },
                new Product()
                {
                    Id = 25, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ekmek-kadayifi-kaymakli_24.09.2021_05_11_57.jpg", 
                    Name = "Ekmek Kadayifi", Description = "Tatlı", Price = 18, CategoryID = 5
                },new Product()
                {
                    Id = 26, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_trilece_02.06.2021_12_21_07.jpg", 
                    Name = "Triliçe", Description = "Tatlı", Price = 12, CategoryID = 5
                },
                new Product()
                {
                    Id = 27, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tiramisu_23.08.2021_08_21_04.jpg", 
                    Name = "Tiramisu", Description = "Tatlı", Price = 9, CategoryID = 5
                },new Product()
                {
                    Id = 28, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ayranlar_09.07.2021_02_38_27.jpg", 
                    Name = "Ayran", Description = "İçecek", Price = 5, CategoryID = 5
                },
                new Product()
                {
                    Id = 29, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_icecekler_01.06.2021_01_13_41.jpg", 
                    Name = "Kutu İçecekler", Description = "İçecek", Price = 8, CategoryID = 5
                },
                new Product()
                {
                    Id = 30, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_salgam-cesitleri_01.12.2021_03_54_14.jpg", 
                    Name = "Şalgam Suyu", Description = "İçecek", Price = 8, CategoryID = 5
                },
                new Product()
                {
                    Id = 31, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_madensuyu_09.07.2021_02_39_20.jpg", 
                    Name = "Maden Suyu", Description = "İçecek", Price = 4, CategoryID = 5
                },
                new Product()
                {
                    Id = 32, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_su-0-5_11.10.2021_05_23_59.jpg", 
                    Name = "Su", Description = "İçecek", Price = 3, CategoryID = 5
                },
                new Product()
                {
                    Id = 33, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/dana-kiyma_21.05.2021_02_06_34.jpg",
                    Name = "Dana Kıyma", Description = "1 Kg", Price = 110, CategoryID = 1
                },
                new Product()
                {
                    Id = 34, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-kusbasi_21.05.2021_02_08_53.jpg",
                    Name = "Dana Kusbası", Description = "1 Kg", Price = 126, CategoryID = 1
                },
                new Product()
                {
                    Id = 35, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-sis-antrikot_21.05.2021_12_22_00.jpg",
                    Name = "Dana-Kuzu Et Karışık", Description = "200 gram", Price = 60, CategoryID = 1
                },
                new Product()
                {
                    Id = 36, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-pirzola_06.10.2021_04_02_19.jpg",
                    Name = "Kuzu Pirzola", Description = "200 gram", Price = 60, CategoryID = 1
                },
                new Product()
                {
                    Id = 37, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ayranlar_09.07.2021_02_38_27.jpg",
                    Name = "Ayran", Description = "İçecek", Price = 5, CategoryID = 1
                },
                new Product()
                {
                    Id = 38, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_su-0-5_11.10.2021_05_23_59.jpg",
                    Name = "Su", Description = "İçecek", Price = 3, CategoryID = 1
                },
                new Product()
                {
                    Id = 39, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ekmek-kadayifi-kaymakli_24.09.2021_05_11_57.jpg",
                    Name = "Ekmek Kadayifi", Description = "Tatlı", Price = 18, CategoryID = 1
                },
                new Product()
                {
                    Id = 40, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ekmek-kadayifi-kaymakli_24.09.2021_05_11_57.jpg",
                    Name = "Ekmek Kadayifi", Description = "Tatlı", Price = 18, CategoryID = 1
                }


            };
        }
        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new Product()
                    {
                        CategoryID = item.CategoryID,
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        Price = item.Price,
                        ImageUrl = item.ImageUrl
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
