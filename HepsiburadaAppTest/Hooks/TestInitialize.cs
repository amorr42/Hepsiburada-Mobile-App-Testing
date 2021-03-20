using HepsiburadaApp.Base;
using HepsiburadaApp.Config;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;


namespace HepsiburadaAppTest.Hooks
{
    [Binding]
    public class TestInitialize
    {
        [BeforeScenario]
        public void InitializeTest()
        {
            //Initialize Settings
            ConfigReader.InitializeSettings();

            DriverFactory.Instance.InitializeAppiumDriver<AppiumDriver<AppiumWebElement>>(MobileType.Native);
        }

        [TearDown]
        public void CleanUp()
        {
            DriverFactory.Instance.CloseAppiumContext();
        }

    }
}
