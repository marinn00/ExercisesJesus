using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExercisesJesus
{
    internal class Exercise8
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
            driver.Url = "https://duckduckgo.com/";
        }

        [Test]
        public void SearchTest()
        {
            String actualTitle;
            String expectedTitle = "Google";
            actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(expectedTitle);
            Console.WriteLine(actualTitle);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
