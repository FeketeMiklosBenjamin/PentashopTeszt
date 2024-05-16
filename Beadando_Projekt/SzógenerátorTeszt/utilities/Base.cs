using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SzógenerátorTeszt.utilities
{
    public class Base
    {
        public static jsonReader reader { get; set; } = new jsonReader();
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver("chromedriver.exe");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();

            string? actUrl = ConfigurationManager.AppSettings["Url"];
            driver.Url = actUrl;
        }

        [TearDown]
        public void StopBrowser()
        {
            driver.Dispose(); // Az összes megnyitott ablakot bezárja
            //driver.Quit(); // Az összes megnyitott ablakot bezárja
            //driver.Close(); // Az aktuális ablakot bezárja 
        }
    }
}
