using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinKofteciYusufClone.Models;

namespace XamarinKofteciYusufClone.ViewModels
{
    public class TatliIcecekViewModels
    {
        public ObservableCollection<Product> Products { get; set; }
        CreateModels _models = new CreateModels();
        public TatliIcecekViewModels()
        {
            //Products = _models.productsTatli;

        }
    }
}
