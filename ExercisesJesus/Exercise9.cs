using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;

namespace ExercisesJesus
{
    internal class Exercise9
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.microsoft.com/es-mx/";
        }

        [Test]
        public void SearchTest()
        {
            IWebElement first = driver.FindElement(By.Id("shellmenu_1"));
            first.Click();
            Assert.NotNull(first);
            IWebElement second = driver.FindElement(By.XPath("//*[@id=\"c-shellmenu_41\"]"));
            second.Click();
            Assert.NotNull(second);
            IWebElement third = driver.FindElement(By.ClassName("c-image"));
            third.Click();
            Assert.NotNull(third);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
