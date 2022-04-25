using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;


namespace XamarinKofteciYusufClone.ViewModels
{
    public class CigUrunlerViewModel
    {
        CreateModels _models = new CreateModels();
        public ObservableCollection<Product> Products { get; set; }

        public CigUrunlerViewModel()
        {
            /*
            Products.Add(new Product
                {ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_burger-koftesi_21.05.2021_02_05_37.jpg", Name = "Burger Köftesi", Description = "1 Kilogram", Price = 106.00f});
            Products.Add(new Product
                {ImageUrl = "https://kofteciyusuf.com/uploads/pictures/dana-kiyma_21.05.2021_02_06_34.jpg", Name = "Dana Kıyma", Description = "1 Kilogram", Price = 110.00f});
            Products.Add();
            Products.Add();
            Products.Add();
            Products.Add();
            Products.Add();
            Products.Add();
            */
            Products = _models.productsCig;
        }
    }
}
