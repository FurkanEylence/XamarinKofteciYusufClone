﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinKofteciYusufClone.Models
{
    public class Cart
    {
        public string UserName { get; set; }
        public int CardId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
