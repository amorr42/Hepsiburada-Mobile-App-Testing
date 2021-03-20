using HepsiburadaApp.Base;
using HepsiburadaAppTest.Pages.Giris;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace HepsiburadaAppTest.Steps
{
    [Binding]
    public class AddBasketSteps:BasePage
    {
        //[Given(@"Hepsiburada Mobile App uygulamasi acilir\. Profil butonuna tiklanir\.")]
        //public void GivenLogInAppHepsiburadaMobileAppUygulamasiAcilir_ProfilButonunaTiklanir_()
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().Profil();
        //}

        //[When(@"Giris yap butonuna tiklanir\.")]
        //public void WhenLogInAppGirisYapButonunaTiklanir_()
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().GirisYap();
        //}

        //[Then(@"Email ""(.*)"" girilir\.")]
        //public void ThenLogInAppEmailGirilir_(string Eposta)
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage.As<loginPage>().Eposta(Eposta);
        //}

        //[Then(@"Sifre ""(.*)"" girilir\.")]
        //public void ThenLogInAppSifreGirilir_(string Password)
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage.As<loginPage>().Password(Password);
        //}

        //[Then(@"Güvenli Giris butonuna tiklanir\.")]
        //public void ThenLogInAppGuvenliGirisButonunaTiklanir_()
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().LoginButton();
        //}

        //[Then(@"Alert Mesaji onaylanir\.")]
        //public void ThenLogInAppAlertMesajiOnaylanir_()
        //{
        //    PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().ConfirmAlert();
        //}

        [Given(@"Arama ekranina gidilir\.")]
        public void GivenAramaEkraninaGidilir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().SearchBox();
        }

        [When(@"Aranacak ürünün adi ""(.*)"" girilir ve arama yapilir\.")]
        public void WhenAranacakUrununAdiGirilirVeAramaYapilir_(String element)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().SearchBox2(element);
        }

        [When(@"Filtrele butonuna tiklanir\.")]
        public void WhenFiltreleButonunaTiklanir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().filtreButton();
        }

        [Then(@"(.*) Kategori secilir\.")]
        public void ThenKategoriSecilir_(String Element2)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().Kategori(Element2);
        }

        [Then(@"(.*) Urün Cesidi secilir\.")]
        public void ThenUrunCesidiSecilir_(String Element3)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().UrunCesidi(Element3);
        }

        [Then(@"(.*) Fiyat Araligi secilir\.")]
        public void ThenFiyatAraligiSecilir_(String Element4)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().FiyatAraligi(Element4);
        }

        [Then(@"(.*) Degerlendirme Puani secilir\.")]
        public void ThenDegerlendirmePuaniSecilir_(String Element5)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().DegerlendirmePuani(Element5);
        }

        [Then(@"(.*) Marka secilir\.")]
        public void ThenMarkaSecilir_(String Element6)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().Marka(Element6);
        }

        [Then(@"(.*) Kullanim Amaci secilir\.")]
        public void ThenKullanimAmaciSecilir_(String Element7)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().KullanimAmaci(Element7);
        }

        [Then(@"(.*) Firsat Urünleri secilir\.")]
        public void ThenFirsatUrunleriSecilir_(String Element8)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().FirsatUrünleri(Element8);
        }

        [Then(@"(.*) İslemci Tipi secilir\.")]
        public void ThenİslemciTipiSecilir_(String Element9)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().IslemciTipi(Element9);
        }

        [Then(@"(.*) Ekran Boyutu secilir\.")]
        public void ThenEkranBoyutuSecilir_(String Element10)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().EkranBoyutu(Element10);
        }

        //[Then(@"(.*) Ekran Karti Hafizasi secilir\.")]
        //public void ThenEkranKartiHafizasiSecilir_(String Element11)
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().EkranKartiHafizasi(Element11);
        //}

        [Then(@"(.*) SSD Kapasitesi secilir\.")]
        public void ThenSSDKapasitesiSecilir_(String Element12)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().SSDKapasitesi(Element12);
        }

        [Then(@"(.*) Max Ekran Cözünürlügü secilir\.")]
        public void ThenMaxEkranCözünürlügüSecilir_(String Element13)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().MaxEkranCözünürlügü(Element13);
        }

        [Then(@"(.*) Cihaz Agirligi secilir\.")]
        public void ThenCihazAgirligiSecilir_(String Element14)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().CihazAgirligi(Element14);
        }

        //[Then(@"(.*) Ekran Karti secilir\.")]
        //public void ThenEkranKartiSecilir_(String Element15)
        //{
        //    Thread.Sleep(1000);
        //    PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
        //    PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().EkranKarti(Element15);
        //}

        [Then(@"Urünleri gör butonuna tiklanir ve ürün sepete eklenir\.")]
        public void ThenUrunleriGorButonunaTiklanirVeUrunSepeteEklenir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().SepeteEkle();
        }

        [Then(@"Sepete gidilir\.")]
        public void ThenSepeteGidilir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<AddBasketPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<AddBasketPage>().SepeteGit();
        }

      




    }
}
