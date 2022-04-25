using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace XamarinKofteciYusufClone.Models
{
    public  class CreateModels
    {
        public ObservableCollection<Product> productsCig = new ObservableCollection<Product>();
        public ObservableCollection<Product> productsFav = new ObservableCollection<Product>();
        public ObservableCollection<Product> productsIzg = new ObservableCollection<Product>();
        public ObservableCollection<Product> productsEkmk = new ObservableCollection<Product>();
        public ObservableCollection<Product> productsTatli = new ObservableCollection<Product>();


        public CreateModels()
        {
           

            //for demo models before connection db.
            #region Categories
            Category FavoriLezzetler = new Category { Id = 1, ImageUrl = "logo.jpg", Name = "FAVORİ LEZZETLER", Products = productsFav };
            Category CigUrunler = new Category { Id = 2, ImageUrl = "kasap.jpg", Name = "ÇİĞ ÜRÜNLER", Products = productsCig };
            Category IzgaraEtler = new Category { Id = 3, ImageUrl = "izgara_etler.jpg", Name = "IZGARA ETLER", Products = productsIzg };
            Category EkmekArasi = new Category { Id = 4, ImageUrl = "ekmek_arasi.jpg", Name = "EKMEK ARASI", Products = productsEkmk };
            Category TatliIcecek = new Category { Id = 5, ImageUrl = "tatli_icecek.jpg", Name = "TATLI - İÇECEK", Products = productsTatli };


            #endregion

            #region CigUrunler
            Product burgerKofte = new Product
            { Id = 1, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_burger-koftesi_21.05.2021_02_05_37.jpg", Name = "Burger Köftesi", Description = "1 Kilogram", Price = 106.0, Category = CigUrunler };
            Product danaKiyma = new Product
            { Id = 2, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/dana-kiyma_21.05.2021_02_06_34.jpg", Name = "Dana Kıyma", Description = "1 Kilogram", Price = 110.0, Category = CigUrunler };
            Product danaKusbasi = new Product
            { Id = 3, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-kusbasi_21.05.2021_02_08_53.jpg", Name = "Dana Kusbası", Description = "1 Kilogram", Price = 126, Category = CigUrunler };
            Product danaKavurma = new Product
            { Id = 4, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-kavurma_21.05.2021_02_12_27.jpg", Name = "Dana Kavurma", Description = "1 Kilogram", Price = 152, Category = CigUrunler };
            Product danaBiftek = new Product
            { Id = 5, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_biftek_30.09.2020_09_38_24.jpg", Name = "Dana Biftek", Description = "1 Kilogram", Price = 136, Category = CigUrunler };
            Product danaAntrikot = new Product
            { Id = 6, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_dana-antrikot_27.07.2019_12_51_33.jpg", Name = "Dana Antrikot", Description = "1 Kilogram", Price = 160, Category = CigUrunler };
            Product kuzuGerdan = new Product
            { Id = 7, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-gerdan_21.05.2021_02_09_44.jpg", Name = "Kuzu Gerdan", Description = "1 Kilogram", Price = 90, Category = CigUrunler };
            Product kuzuPirzola = new Product
            { Id = 8, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-pirzola_30.09.2020_10_32_59.jpg", Name = "Kuzu Pirzola", Description = "1 Kilogram", Price = 200, Category = CigUrunler };


            productsCig.Add(burgerKofte);
            productsCig.Add(danaKiyma);
            productsCig.Add(danaKusbasi);
            productsCig.Add(danaKavurma);
            productsCig.Add(danaBiftek);
            productsCig.Add(danaAntrikot);
            productsCig.Add(kuzuGerdan);
            productsCig.Add(kuzuPirzola);


            #endregion

            #region IzgaraEtler
            Product kuzuSisIzgara = new Product
            { Id = 9, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-sis_21.05.2021_04_15_45.jpg", Name = "Kuzu Şiş", Description = "200 gram", Price = 60, Category = IzgaraEtler };
            Product kuzuBeytiIzgara = new Product
            { Id = 10, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-kuzu-beyti_21.05.2021_12_12_04.jpg", Name = "Kuzu Beyti", Description = "200 gram", Price = 60, Category = IzgaraEtler };
            Product kuzuPirzolaIzgara = new Product
            { Id = 11, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-pirzola_06.10.2021_04_02_19.jpg", Name = "Kuzu Pirzola", Description = "200 gram", Price = 60, Category = IzgaraEtler };
            Product danaAntrikotIzgara = new Product
            { Id = 12, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_antrikot_21.05.2021_04_13_58.jpg", Name = "Dana Antrikot", Description = "200 gram", Price = 60, Category = IzgaraEtler };
            Product pilicIncikIzgara = new Product
            { Id = 13, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-pilic-incik_21.05.2021_11_15_52.jpg", Name = "Pilic İncik", Description = "200 gram", Price = 34, Category = IzgaraEtler };
            Product pilicKarisikIzgara = new Product
            { Id = 14, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_pilic-kasrisik_07.10.2021_05_51_13.jpg", Name = "Pilic Karışık", Description = "200 gram", Price = 34, Category = IzgaraEtler };
            Product pilicKanatIzgara = new Product
            { Id = 15, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_izgara-pilic-kanat_21.05.2021_12_16_14.jpg", Name = "Piliç Kanat", Description = "200 gram", Price = 34, Category = IzgaraEtler };
            Product danaKuzuKarisikIzgara = new Product
            { Id = 16, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_kuzu-sis-antrikot_21.05.2021_12_22_00.jpg", Name = "Dana-Kuzu Et Karışık", Description = "200 gram", Price = 60, Category = IzgaraEtler };

            productsIzg.Add(kuzuSisIzgara);
            productsIzg.Add(kuzuBeytiIzgara);
            productsIzg.Add(kuzuPirzolaIzgara);
            productsIzg.Add(danaAntrikotIzgara);
            productsIzg.Add(pilicIncikIzgara);
            productsIzg.Add(pilicKarisikIzgara);
            productsIzg.Add(pilicKanatIzgara);
            productsIzg.Add(danaKuzuKarisikIzgara);

            #endregion

            #region EkmekArasi
            Product sucukYEkmek = new Product
            { Id = 17, ImageUrl = "img", Name = "Sucuk", Description = "Yarım Ekmek", Price = 25, Category = EkmekArasi };
            Product sucukTEkmek = new Product
            { Id = 18, ImageUrl = "img", Name = "Sucuk", Description = "Tam Ekmek", Price = 35, Category = EkmekArasi };
            Product kofteYEkmek = new Product
            { Id = 19, ImageUrl = "img", Name = "Köfte", Description = "Yarım Ekmek", Price = 25, Category = EkmekArasi };
            Product kofteTEkmek = new Product
            { Id = 20, ImageUrl = "img", Name = "Köfte", Description = "Tam Ekmek", Price = 35, Category = EkmekArasi };
            Product donerYEkmek = new Product
            { Id = 21, ImageUrl = "img", Name = "Döner", Description = "Yarım Ekmek", Price = 25, Category = EkmekArasi };
            Product donerTEkmek = new Product
            { Id = 22, ImageUrl = "img", Name = "Döner", Description = "Tam Ekmek", Price = 35, Category = EkmekArasi };
            Product burgerYEkmek = new Product
            { Id = 23, ImageUrl = "img", Name = "Burger", Description = "Yarım Ekmek", Price = 25, Category = EkmekArasi };
            Product burgerTEkmek = new Product
            { Id = 24, ImageUrl = "img", Name = "Burger", Description = "Tam Ekmek", Price = 35, Category = EkmekArasi };

            productsEkmk.Add(sucukYEkmek);
            productsEkmk.Add(sucukTEkmek);
            productsEkmk.Add(kofteYEkmek);
            productsEkmk.Add(kofteTEkmek);
            productsEkmk.Add(donerYEkmek);
            productsEkmk.Add(donerTEkmek);
            productsEkmk.Add(burgerYEkmek);
            productsEkmk.Add(burgerTEkmek);


            #endregion

            #region Tatli-Icecek
            Product ekmekKadayifi = new Product
            { Id = 25, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ekmek-kadayifi-kaymakli_24.09.2021_05_11_57.jpg", Name = "Ekmek Kadayifi", Description = "Tatlı", Price = 18, Category = TatliIcecek };
            Product trilice = new Product
            { Id = 26, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_trilece_02.06.2021_12_21_07.jpg", Name = "Triliçe", Description = "Tatlı", Price = 12, Category = TatliIcecek };
            Product tiramisu = new Product
            { Id = 27, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_tiramisu_23.08.2021_08_21_04.jpg", Name = "Tiramisu", Description = "Tatlı", Price = 9, Category = TatliIcecek };
            Product ayran = new Product
            { Id = 28, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_ayranlar_09.07.2021_02_38_27.jpg", Name = "Ayran", Description = "İçecek", Price = 5, Category = TatliIcecek };
            Product kutuIcecek = new Product
            { Id = 29, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_icecekler_01.06.2021_01_13_41.jpg", Name = "Kutu İçecekler", Description = "İçecek", Price = 8, Category = TatliIcecek };
            Product salgamSuyu = new Product
            { Id = 30, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_salgam-cesitleri_01.12.2021_03_54_14.jpg", Name = "Şalgam Suyu", Description = "İçecek", Price = 8, Category = TatliIcecek };
            Product madenSuyu = new Product
            { Id = 31, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_madensuyu_09.07.2021_02_39_20.jpg", Name = "Maden Suyu", Description = "İçecek", Price = 4, Category = TatliIcecek };
            Product su = new Product
            { Id = 32, ImageUrl = "https://kofteciyusuf.com/uploads/pictures/thumb_su-0-5_11.10.2021_05_23_59.jpg", Name = "Su", Description = "İçecek", Price = 3, Category = TatliIcecek };

            productsTatli.Add(ekmekKadayifi);
            productsTatli.Add(trilice);
            productsTatli.Add(tiramisu);
            productsTatli.Add(ayran);
            productsTatli.Add(kutuIcecek);
            productsTatli.Add(salgamSuyu);
            productsTatli.Add(madenSuyu);
            productsTatli.Add(su);

            #endregion

            #region FavoriLezzetler



            productsFav.Add(danaKiyma);
            productsFav.Add(danaKusbasi);
            productsFav.Add(kuzuPirzolaIzgara);
            productsFav.Add(danaKuzuKarisikIzgara);
            productsFav.Add(burgerTEkmek);
            productsFav.Add(kofteYEkmek);
            productsFav.Add(ayran);
            productsFav.Add(ekmekKadayifi);


            #endregion

        }
     
    }
}
