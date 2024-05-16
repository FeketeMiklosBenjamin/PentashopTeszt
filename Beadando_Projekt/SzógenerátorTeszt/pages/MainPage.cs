using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzógenerátorTeszt.utilities;

namespace SzógenerátorTeszt.pages
{
    public class MainPage
    {
        IWebDriver driver { get; set; }
        
        public MainPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div[1]/div[2]/div[2]/button[1]")]
        public IWebElement popup { get; set; }

        [FindsBy(How = How.Name, Using = "szo")]
        public IWebElement input { get; set;}

        [FindsBy(How = How.Name, Using = "kuld")]
        public IWebElement gomb { get; set; }

        [FindsBy(How = How.ClassName, Using = "talalat")]
        public IList<IWebElement> talalatok { get; set;} = new List<IWebElement>();
    }
}
