using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinKofteciYusufClone.Models;

using XamarinKofteciYusufClone.Views;

namespace XamarinKofteciYusufClone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            
           

        }

        private async void FavoriLezzetler_Click(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new FavoriLezzetlerPage());
           

        }

        private async void CigUrunler_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CigUrunlerPage());
        }

        private async void IzgaraEtler_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IzgaraEtlerPage());
        }

        private async void EkmekArasi_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EkmekArasiPage());
        }

        private async void TatliIcecek_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TatliPage());
        }

        private async void Hesabim_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView());
        }
    }
}
