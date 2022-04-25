using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class EkmekArasiViewModel
    {
        CreateModels _models = new CreateModels();
        public ObservableCollection<Product> Products { get; set; }

        public EkmekArasiViewModel()
        {
            Products = _models.productsEkmk;
        }
    }
}
