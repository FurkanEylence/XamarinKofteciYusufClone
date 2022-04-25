using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class IzgaraEtlerViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        CreateModels _models = new CreateModels();
        public IzgaraEtlerViewModel()
        {
            Products = _models.productsIzg;
        }
    }
}
