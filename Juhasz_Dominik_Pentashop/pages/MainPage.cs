using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentashop_Teszt_Juhasz_Dominik.pages
{
    public class MainPage
    {
        IWebDriver driver { get; set; }

        public MainPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        //1. teszteset

        [FindsBy(How = How.CssSelector, Using = "#page > header > div.elementor.elementor-2236 > section.elementor-section.elementor-top-section.elementor-element.elementor-element-cda93bc.rey-section-bg--classic.rey-flexWrap.elementor-section-content-middle.elementor-section-height-min-height.elementor-hidden-tablet.elementor-hidden-phone.elementor-section-boxed.elementor-section-height-default.elementor-section-items-middle > div > div.elementor-column.elementor-col-33.elementor-top-column.elementor-element.elementor-element-e923a50.column-p-trg > div > div.elementor-element.elementor-element-ee58bfc.p-ani--underline.elementor-widget__width-auto.p-trg--column.elementor-widget.elementor-widget-heading > div > h6 > a")]

        public IWebElement link_to_login { get; set; }

        [FindsBy(How = How.Id, Using = "username")]

        public IWebElement email { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#password")]

        public IWebElement password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button")]

        public IWebElement login { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-2235 > div > div > section > div > div > div > div > div > div > div.woocommerce-MyAccount-content > div > p:nth-child(2) > a")]

        public IWebElement log_out { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-2235 > div > div > section > div > div > div > div > div > div > div.woocommerce-notices-wrapper > div > svg")]
        public IWebElement error { get; set; }


        // 2. teszteset

        [FindsBy(How = How.CssSelector, Using = "#search-form-1")]

        public IWebElement searchbar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main > header > h1")]

        public IWebElement search { get; set; }

    }
}
