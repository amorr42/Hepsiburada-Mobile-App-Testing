using HepsiburadaApp.Base;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HepsiburadaAppTest.Pages.Giris
{
    class loginPage:BasePage
    {
        #region Kullanıcı Login      
        [CacheLookup] AppiumWebElement btnProfil => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/account_icon_frame");
        [CacheLookup] AppiumWebElement btnGirisYap => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/llUserAccountLogin");
        [CacheLookup] AppiumWebElement txtEposta => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/etLoginEmail");
        [CacheLookup] AppiumWebElement txtPassword => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/etLoginPassword");
        [CacheLookup] AppiumWebElement txtLoginButton => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/btnLoginLogin");
        [CacheLookup] AppiumWebElement btncloseAlert => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/buttonSecondaryAction");
        [CacheLookup] AppiumWebElement btnConfirmAlert => AppiumDriver.FindElementById("android:id/button1");
        [CacheLookup] AppiumWebElement btnCloseButton => AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/btnUserAccountClose");


        internal loginPage Profil()
        {
            Thread.Sleep(2000);
            btncloseAlert.Click();
            btnProfil.Click();
            return GetInstance<loginPage>();
        }

        internal loginPage GirisYap()
        {
            Thread.Sleep(1000);
            btnGirisYap.Click();
            return GetInstance<loginPage>();
        }

        internal loginPage Eposta(String Eposta)
        {
            Thread.Sleep(1000);
            txtEposta.SendKeys(Eposta);
            return GetInstance<loginPage>();
        }

        internal loginPage Password(String Password)
        {
            txtPassword.Click();
            Thread.Sleep(1000);
            txtPassword.SendKeys(Password);
            return GetInstance<loginPage>();
        }

        internal loginPage LoginButton()
        {
            Thread.Sleep(1000);
            txtLoginButton.Click();
            return GetInstance<loginPage>();
        }

        internal loginPage ConfirmAlert()
        {

            Thread.Sleep(2000);
            Assert.IsTrue(AppiumDriver.FindElementById("com.pozitron.hepsiburada:id/alertTitle").Text.Contains("Hoşgeldiniz"));
            btnConfirmAlert.Click();
            Thread.Sleep(1000);
            btnCloseButton.Click();
            return GetInstance<loginPage>();
        }



        #endregion
    }
}
