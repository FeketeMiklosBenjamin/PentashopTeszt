using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Pentashop_Teszt_Fekete_Miklos.pages;
using Pentashop_Teszt_Fekete_Miklos.utilities;
using SeleniumExtras.WaitHelpers;
using System.Reflection.PortableExecutable;

namespace Pentashop_Teszt_Fekete_Miklos
{
    public class PagesTests : Base
    {

        [Test]
        [TestCaseSource("testDatas")]
        public void Tests(string testPlatform, string testStreamer, List<string> expectedProducts)
        {
            MainPage mainPage = new MainPage(driver);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            foreach (var expectedproduct in expectedProducts)
            {
                foreach (var platform in mainPage.Platforms)
                {
                    if (platform.Text == testPlatform)
                    {
                        platform.Click();
                        break;
                    }
                }
                foreach (var streamer in mainPage.Streamers)
                {
                    Console.WriteLine(streamer.Text);
                    if (streamer.Text == testStreamer)
                    {
                        streamer.Click();
                        break;
                    }
                }
                foreach (var product in mainPage.Products)
                {
                    if (product.GetAttribute("innerHTML") == expectedproduct)
                    {
                        product.Click();
                        mainPage.AddToCartButton.Click();
                        wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("checkout")));
                        mainPage.ExitButton.Click();
                        break;
                    }
                }
            }
            mainPage.CartButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("checkout")));
            mainPage.CartCheckerButton.Click();
            CheckoutPage checkoutPage = new CheckoutPage(driver);
            List<string> AddedProducts = new List<string>();
            foreach (var item in checkoutPage.checkoutProductsNames)
            {
                AddedProducts.Add(item.Text);
            }
            Assert.That(AddedProducts, Is.EqualTo(expectedProducts));
        }

        public static TestCaseData[] testDatas =
        {
            new TestCaseData("YOUTUBE" ,"NESSAJ", reader.productsDataList("NessajTest1")),
            new TestCaseData("YOUTUBE" ,"NESSAJ", reader.productsDataList("NessajTest2")),
            new TestCaseData("YOUTUBE" ,"STARK PANZER", reader.productsDataList("StarkPanzerTest1")),
            new TestCaseData("TWITCH" ,"AVID IS ODD", reader.productsDataList("AvidIsOddTest1"))
        };
    }
}