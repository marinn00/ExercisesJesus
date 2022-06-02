using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Collections.Generic;
namespace ExercisesJesus
{
    [TestFixture]
    public class Exercise10
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)) {
                PollingInterval = TimeSpan.FromSeconds(1)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(drv => driver.FindElement(By.XPath("//input[@name='q']")).Displayed);
            IWebElement search = driver.FindElement(By.XPath("//input[@name='q']"));
            search.Click();
            search.SendKeys("treant");
            search.SendKeys(Keys.Enter);
            wait.Until(drv => driver.FindElement(By.ClassName("Wo6ZAEmESLNUuWBkbMxx")).Displayed);
            var results = driver.FindElements(By.ClassName("Wo6ZAEmESLNUuWBkbMxx"));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(results[i].Text);
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}