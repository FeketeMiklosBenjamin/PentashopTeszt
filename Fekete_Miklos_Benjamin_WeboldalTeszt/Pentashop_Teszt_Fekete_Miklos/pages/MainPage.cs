using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentashop_Teszt_Fekete_Miklos.pages
{
    public class MainPage
    {
        IWebDriver driver { get; set; }

        public MainPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        // Platforms

        [FindsBy(How = How.ClassName, Using = "rey-toggleBox-text-main")]
        public IList<IWebElement> Platforms { get; set; } = new List<IWebElement>();

        // Streamers

        [FindsBy(How = How.ClassName, Using = "menu-item-type-taxonomy")]
        public IList<IWebElement> Streamers { get; set; } = new List<IWebElement>();

        //Products

        [FindsBy(How = How.XPath, Using = "//h2[contains(@class, \"woocommerce-loop-product__title\")]/a")]
        public IList<IWebElement> Products { get; set; } = new List<IWebElement>();

        // Navigation Buttons

        [FindsBy(How = How.Name, Using = "add-to-cart")]
        public IWebElement AddToCartButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "button--cart")]
        public IWebElement CartCheckerButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[1]/button")]
        public IWebElement ExitButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/header/div[1]/section[2]/div/div[3]/div/div[2]/div/div/button/span[1]")]
        public IWebElement CartButton { get; set; }
    }
}
