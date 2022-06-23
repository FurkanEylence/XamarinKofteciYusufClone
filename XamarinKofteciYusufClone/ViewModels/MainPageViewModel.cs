using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        private CreateModels _models = new CreateModels();
        public MainPageViewModel()
        {
            //Products = _models.productsFav;
        }
    }
}
