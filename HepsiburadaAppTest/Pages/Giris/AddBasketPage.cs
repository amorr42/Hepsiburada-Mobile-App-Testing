using HepsiburadaApp.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android.UiAutomator;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Windows.Enums;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace HepsiburadaAppTest.Pages.Giris
{
    class AddBasketPage:BasePage
    {
        #region Sepete Ürün Ekleme

        [CacheLookup] AppiumWebElement btnSearchBox => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/categoriesSearchBox");
        [CacheLookup] AppiumWebElement btnSearchBox2 => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/etACBSearchBox");
        [CacheLookup] AppiumWebElement btncloseAlert => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/buttonSecondaryAction");
        [CacheLookup] AppiumWebElement btnfiltreButton => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/lyt_product_list_options_bar_filters");
        [CacheLookup] AppiumWebElement btnKategori => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Kategori')]");
        [CacheLookup] AppiumWebElement btnUygula=> AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/btn_filters_apply");
        [CacheLookup] AppiumWebElement btnUrunCesidi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Ürün Çeşidi')]");
        [CacheLookup] AppiumWebElement btnFiyatAraligi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Fiyat Aralığı')]");
        [CacheLookup] AppiumWebElement btnDegerlendirmePuani => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Değerlendirme Puanı')]");
        [CacheLookup] AppiumWebElement btnMarka => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Marka')]");
        [CacheLookup] AppiumWebElement btnKullanimAmaci => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Kullanım Amacı')]");
        [CacheLookup] AppiumWebElement btnFirsatUrünleri => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Fırsat Ürünleri')]");
        [CacheLookup] AppiumWebElement btnIslemciTipi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'İşlemci Tipi')]");
        [CacheLookup] AppiumWebElement btnEkranBoyutu => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Ekran Boyutu')]");
        [CacheLookup] AppiumWebElement btnEkranKartiHafizasi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Ekran Kartı Hafızası')]");
        [CacheLookup] AppiumWebElement btnSSDKapasitesi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'SSD Kapasitesi')]");
        [CacheLookup] AppiumWebElement btnMaxEkranCözünürlügü => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Max Ekran Çözünürlüğü')]");
        [CacheLookup] AppiumWebElement btnCihazAgirligi => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Cihaz Ağırlığı')]");
        [CacheLookup] AppiumWebElement btnEkranKarti => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Ekran Kartı')]");
        [CacheLookup] AppiumWebElement btnUrünleriGör => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/btn_filters_main_close");
        [CacheLookup] AppiumWebElement btnSepeteEkle => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/atcb_product_list_item_add_to_cart");
        [CacheLookup] AppiumWebElement btnSepeteGit => AppiumDriver.FindElementByXPath("//android.widget.TextView[contains(@text, 'Sepet')]");
        [CacheLookup] AppiumWebElement btnAlisverisiTamamla => AppiumDriver.FindElementById("continue_step_btn");

        



        internal AddBasketPage SearchBox()
        {
            Thread.Sleep(2000);
            btncloseAlert.Click();
            Thread.Sleep(1000);
            btnSearchBox.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage SearchBox2(string element)
        {
            Thread.Sleep(1000);
            btnSearchBox2.SendKeys(element);
            Thread.Sleep(1000);
            var list = AppiumDriver.FindElement(By.ClassName("androidx.recyclerview.widget.RecyclerView"));
            var locator = new ByAndroidUIAutomator(new AndroidUiScrollable()
                .ScrollIntoView(new AndroidUiSelector().TextEquals(element)));
            var confirmElement = list.FindElement(locator);
            confirmElement.Click();
            return GetInstance<AddBasketPage>();
        }


        internal AddBasketPage filtreButton()
        {
            Thread.Sleep(1000);
            btnfiltreButton.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage Kategori(string Element2)
        {
            Thread.Sleep(2000);
            btnKategori.Click();
            Thread.Sleep(1000);
            var BtnElement2 = String.Format("//android.widget.TextView[contains(@text,'Bilgisayar')]");
            AppiumDriver.FindElement(By.XPath(BtnElement2)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage UrunCesidi(string Element3)
        {
            Thread.Sleep(1000);
            btnUrunCesidi.Click();
            Thread.Sleep(1000);
            var BtnElement3 = String.Format("//android.widget.TextView[contains(@text,'Dizüstü Bilgisayar Laptop')]");
            AppiumDriver.FindElement(By.XPath(BtnElement3)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage FiyatAraligi(string Element4)
        {
            Thread.Sleep(1000);
            btnFiyatAraligi.Click();
            Thread.Sleep(1000);
            var BtnElement4 = String.Format("//android.widget.TextView[contains(@text,'2500 TL üzerinde')]");
            AppiumDriver.FindElement(By.XPath(BtnElement4)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage DegerlendirmePuani(string Element5)
        {
            Thread.Sleep(1000);
            btnDegerlendirmePuani.Click();
            Thread.Sleep(1000);
            var BtnElement5 = String.Format("//android.widget.TextView[contains(@text,'4  ve 4+ puanlı ürünler')]");
            AppiumDriver.FindElement(By.XPath(BtnElement5)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage Marka(string Element6)
        {
            Thread.Sleep(1000);
            btnMarka.Click();
            Thread.Sleep(1000);
            var BtnElement6 = String.Format("//android.widget.TextView[contains(@text,'Lenovo')]");
            AppiumDriver.FindElement(By.XPath(BtnElement6)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage KullanimAmaci(string Element7)
        {
            Thread.Sleep(1000);
            IList<AppiumWebElement> els = AppiumDriver.FindElementsByClassName("android.widget.LinearLayout");
            var loc1 = els[5].Location;
            var target = els[1];
            var loc2 = target.Location;
            var touchAction = new TouchAction(AppiumDriver);
            touchAction.Press(loc1.X, loc1.Y).Wait(800)
                .MoveTo(loc2.X, loc2.Y).Release().Perform();
            btnKullanimAmaci.Click();
            Thread.Sleep(1000);
            var BtnElement7 = String.Format("//android.widget.TextView[contains(@text,'Ofis ve İş')]");
            AppiumDriver.FindElement(By.XPath(BtnElement7)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage FirsatUrünleri(string Element8)
        {
            Thread.Sleep(1000);
            btnFirsatUrünleri.Click();
            Thread.Sleep(1000);
            var BtnElement8 = String.Format("//android.widget.TextView[contains(@text,'24 Saatte Kargoda')]");
            AppiumDriver.FindElement(By.XPath(BtnElement8)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage IslemciTipi(string Element9)
        {
            Thread.Sleep(1000);
            btnIslemciTipi.Click();
            Thread.Sleep(1000);
            var BtnElement9 = String.Format("//android.widget.TextView[contains(@text,'Intel Core i7')]");
            AppiumDriver.FindElement(By.XPath(BtnElement9)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>(); 
        }

        internal AddBasketPage EkranBoyutu(string Element10)
        {
            Thread.Sleep(1000);
            btnEkranBoyutu.Click();
            Thread.Sleep(1000);          
            var BtnElement10 = String.Format("//android.widget.TextView[contains(@text,'15,6 inç')]");
            AppiumDriver.FindElement(By.XPath(BtnElement10)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>(); 
        }

        //internal AddBasketPage EkranKartiHafizasi(string Element11)
        //{
        //    Thread.Sleep(1000);
        //    IList<AppiumWebElement> els = AppiumDriver.FindElementsByClassName("android.widget.LinearLayout");
        //    var loc1 = els[7].Location;
        //    var target = els[1];
        //    var loc2 = target.Location;
        //    var touchAction = new TouchAction(AppiumDriver);
        //    touchAction.Press(loc1.X, loc1.Y).Wait(800)
        //        .MoveTo(loc2.X, loc2.Y).Release().Perform();
        //    btnEkranKartiHafizasi.Click();
        //    Thread.Sleep(1000);
        //    var BtnElement11 = String.Format("//android.widget.TextView[contains(@text,'Paylaşımlı')]");
        //    AppiumDriver.FindElement(By.XPath(BtnElement11)).Click();
        //    Thread.Sleep(1000);
        //    btnUygula.Click();
        //    return GetInstance<AddBasketPage>();
        //}

        internal AddBasketPage SSDKapasitesi(string Element12)
        {
            Thread.Sleep(1000);
            IList<AppiumWebElement> els = AppiumDriver.FindElementsByClassName("android.widget.LinearLayout");
            var loc1 = els[7].Location;
            var target = els[1];
            var loc2 = target.Location;
            var touchAction = new TouchAction(AppiumDriver);
            touchAction.Press(loc1.X, loc1.Y).Wait(800)
                .MoveTo(loc2.X, loc2.Y).Release().Perform();
            btnSSDKapasitesi.Click();
            Thread.Sleep(1000);
            var BtnElement12 = String.Format("//android.widget.TextView[contains(@text,'512 GB')]");
            AppiumDriver.FindElement(By.XPath(BtnElement12)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage MaxEkranCözünürlügü(string Element13)
        {
            Thread.Sleep(1000);
            btnMaxEkranCözünürlügü.Click();
            Thread.Sleep(1000);
            var BtnElement13 = String.Format("//android.widget.TextView[contains(@text,'1920 x 1080')]");
            AppiumDriver.FindElement(By.XPath(BtnElement13)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage CihazAgirligi(string Element14)
        {
            Thread.Sleep(1000);
            btnCihazAgirligi.Click();
            Thread.Sleep(1000);
            var BtnElement14 = String.Format("//android.widget.TextView[contains(@text,'2 kg ve Altı')]");
            AppiumDriver.FindElement(By.XPath(BtnElement14)).Click();
            Thread.Sleep(1000);
            btnUygula.Click();
            return GetInstance<AddBasketPage>();
        }

        //internal AddBasketPage EkranKarti(string Element15)
        //{
        //    Thread.Sleep(1000);
        //    btnEkranKarti.Click();
        //    Thread.Sleep(1000);
        //    var BtnElement15 = String.Format("//android.widget.TextView[contains(@text,'Intel Iris Graphic')]");
        //    AppiumDriver.FindElement(By.XPath(BtnElement15)).Click();
        //    Thread.Sleep(1000);
        //    btnUygula.Click();
        //    return GetInstance<AddBasketPage>();
        //}

        internal AddBasketPage SepeteEkle()
        {
            Thread.Sleep(1000);
            btnUrünleriGör.Click();
            Thread.Sleep(1000);
            btnSepeteEkle.Click();
            return GetInstance<AddBasketPage>();
        }

        internal AddBasketPage SepeteGit()
        {
            Thread.Sleep(1000);
            btnSepeteGit.Click();
            return GetInstance<AddBasketPage>();
        }

     






        #endregion
    }
}
