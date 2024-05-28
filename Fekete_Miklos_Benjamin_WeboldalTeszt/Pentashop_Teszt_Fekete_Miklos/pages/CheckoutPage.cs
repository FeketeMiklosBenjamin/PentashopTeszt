using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentashop_Teszt_Fekete_Miklos.pages
{
    public class CheckoutPage
    {
        IWebDriver driver { get; set; }

        public CheckoutPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        // Checkout Products Checker

        [FindsBy(How = How.ClassName, Using = "woocommerce-mini-cart-item-title")]
        public IList<IWebElement> checkoutProductsNames { get; set; } = new List<IWebElement>();
    }
}
