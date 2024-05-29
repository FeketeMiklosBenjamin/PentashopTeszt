using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace Pentashop_Teszt_Juhasz_Dominik.utilities
{
    public class Base
    {
        public static jsonReader reader { get; set; } = new jsonReader();
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();

            string? actUrl = ConfigurationManager.AppSettings["Url"];
            driver.Url = "https://shop.pentamedia.hu/";
        }

        [TearDown]
        public void StopBrowser()
        {
            driver.Dispose();
        }
    }
}
