﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinKofteciYusufClone.Helpers;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinKofteciYusufClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_OnClicked(object sender, EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoryAsync();
        }

        async void ButtonProducts_OnClicked(object sender, EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemAsync();
        }
    }
}