using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Reflection.PortableExecutable;
using Pentashop_Teszt_Juhasz_Dominik.pages;
using Pentashop_Teszt_Juhasz_Dominik.utilities;
using NUnit.Framework;

namespace Pentashop_Teszt_Juhasz_Dominik
{
    public class UnitTests : Base
    {

        [Test]
        [TestCaseSource("testDatas")]
        public void Test_Users(string email, string password, List<string> expectedResults)
        {
            MainPage mainPage = new MainPage(driver);
            List<string> results = new List<string>();
            bool isGood = true;

            try
            {
                mainPage.link_to_login.Click();
                mainPage.email.SendKeys(email);
                mainPage.password.SendKeys(password);

                results.Add(email);
                results.Add(password);

                mainPage.login.Click();
                mainPage.log_out.Click();

                Assert.That(isGood, Is.True);

            }
            catch (Exception ex)
            {
                isGood = false;
                Assert.That(isGood, Is.False);
            }
        }

        public static TestCaseData[] testDatas =
        {
            new TestCaseData("jdomi04@gmail.com" ,"kecskepasztor05", reader.productsDataList("DominikTest")),
            new TestCaseData("fekete.miklos.b@gmail.com" ,"Miklos#Asztal24", reader.productsDataList("MiklosTest")),
            new TestCaseData("lajoskazsigmond@freemail.hu" ,"KisZsiga69", reader.productsDataList("LajosTest"))
        };



        [Test]
        public void Test_Searchbar()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.searchbar.Click();
            mainPage.searchbar.SendKeys("starkpanzer");
            mainPage.searchbar.SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            Assert.That(mainPage.search.Text, Is.EquivalentTo("Keresési eredmények: “starkpanzer”"));

        }

    }
}