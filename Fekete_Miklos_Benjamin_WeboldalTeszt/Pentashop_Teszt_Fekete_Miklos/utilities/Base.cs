using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Pentashop_Teszt_Fekete_Miklos.utilities
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
