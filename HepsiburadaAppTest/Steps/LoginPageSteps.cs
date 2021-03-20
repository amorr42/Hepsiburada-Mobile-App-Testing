using HepsiburadaApp.Base;
using HepsiburadaAppTest.Pages.Giris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace HepsiburadaAppTest.Steps
{
    [Binding]
    public class LoginPageSteps : BasePage
    {

        #region
        [Given(@"logInApp  Hepsiburada Mobile App uygulamasi acilir\. Profil butonuna tiklanir\.")]
        public void GivenLogInAppHepsiburadaMobileAppUygulamasiAcilir_ProfilButonunaTiklanir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().Profil();
        }

        [When(@"logInApp\tGiris yap butonuna tiklanir\.")]
        public void WhenLogInAppGirisYapButonunaTiklanir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().GirisYap();
        }

        [Then(@"logInApp  Email ""(.*)"" girilir\.")]
        public void ThenLogInAppEmailGirilir_(string Eposta)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage.As<loginPage>().Eposta(Eposta);
        }

        [Then(@"logInApp  Sifre ""(.*)"" girilir\.")]
        public void ThenLogInAppSifreGirilir_(string Password)
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage.As<loginPage>().Password(Password);
        }

        [Then(@"logInApp  Güvenli Giris butonuna tiklanir\.")]
        public void ThenLogInAppGuvenliGirisButonunaTiklanir_()
        {
            Thread.Sleep(1000);
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().LoginButton();
        }

        [Then(@"logInApp  Alert Mesaji onaylanir\.")]
        public void ThenLogInAppAlertMesajiOnaylanir_()
        {
            PageFactory.Instance.CurrentPage = GetInstance<loginPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<loginPage>().ConfirmAlert();
        }




        #endregion
    }
}