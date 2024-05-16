using SzógenerátorTeszt.pages;
using SzógenerátorTeszt.utilities;

namespace SzógenerátorTeszt
{
    public class E2ETest : Base
    {

        [Test]
        [TestCaseSource("testDatas")]
        public void Test1(string be, List<string> ki)
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.popup.Click();
            mainPage.input.SendKeys(be);
            mainPage.gomb.Click();
            // Két lista egyezőségének vizsgálata:
            // 1. Igaz-e, hogy ha a két lista metszetének elemszáma megegyezik a visszakapott listával,
            // és a két lista azonos elemszámú, akkor a két lista egyenlő
            // 2. 
            bool egyenlőElemszám = ki.Count == mainPage.talalatok.Count;
            bool egyenlőE = ki.Intersect(mainPage.talalatok.Select(x => x.Text)).Count() == ki.Count;

            Assert.That(egyenlőE && egyenlőElemszám, Is.True);

            //foreach (var item in mainPage.talalatok)
            //{
            //    Console.WriteLine(item.Text);
            //}
            //Assert.Pass();
        }

        public static TestCaseData[] testDatas =
        {
            new TestCaseData("dillr", reader.extractDataList("dillr")),
            new TestCaseData("aprsy", reader.extractDataList("aprsy")),
            new TestCaseData("dnoor", reader.extractDataList("dnoor")),
            new TestCaseData("almmo", reader.extractDataList("almmo"))
        };
    }
}