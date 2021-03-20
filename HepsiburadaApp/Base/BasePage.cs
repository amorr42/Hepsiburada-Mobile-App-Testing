using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiburadaApp.Base
{
    public class BasePage : Base
    {
        public AppiumDriver<AppiumWebElement> AppiumDriver;

        public BasePage() => AppiumDriver = DriverFactory.Instance.AppiumDriver;

        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            var T = Activator.CreateInstance(typeof(TPage));
            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

    }
}
