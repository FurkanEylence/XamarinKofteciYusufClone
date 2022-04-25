using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinKofteciYusufClone.Models
{
    public  class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ObservableCollection<Product> Products { get; set; }
    }
}
