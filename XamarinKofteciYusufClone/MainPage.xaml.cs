using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinKofteciYusufClone.Navigation;

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

        private void CigUrunler_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IzgaraEtler_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EkmekArasi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TatliIcecek_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
