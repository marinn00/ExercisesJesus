using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Collections.Generic;

namespace ExercisesJesus
{
    internal class Exercise11
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SelectCheckbox()
        {
            driver.Url = "https://demoqa.com/checkbox";
            driver.FindElement(By.CssSelector("button[class='rct-collapse rct-collapse-btn']")).Click();
            driver.FindElement(By.XPath("//*[@id='tree-node']/ol/li/ol/li[2]/span/label/span[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='tree-node']/ol/li/ol/li[3]/span/label/span[3]")).Click();
        }

        [Test]
        public void SelectRadio()
        {
            driver.Url = "https://demoqa.com/radio-button";
            driver.FindElement(By.CssSelector("label[for='yesRadio']")).Click();
            driver.FindElement(By.CssSelector("label[for='impressiveRadio']")).Click();              
        }

        [Test]
        public void PullEmail()
        {
            driver.Url = "https://demoqa.com/webtables";
            string email = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[4]")).Text;
            Assert.AreEqual(email, "cierra@example.com");
        }

        [Test]
        public void SelectMenu()
        {
            driver.Url = "https://demoqa.com/select-menu";
            string menuOp;

            driver.FindElement(By.Id("withOptGroup")).Click();
            menuOp = driver.FindElement(By.Id("react-select-2-option-0-1")).Text;
            driver.FindElement(By.Id("react-select-2-option-0-1")).Click();
            Assert.AreEqual(menuOp, "Group 1, option 2");

            driver.FindElement(By.Id("selectOne")).Click();
            menuOp = driver.FindElement(By.Id("react-select-3-option-0-1")).Text;
            driver.FindElement(By.Id("react-select-3-option-0-1")).Click();
            Assert.AreEqual(menuOp, "Mr.");

            SelectElement OldSelect = new SelectElement(driver.FindElement(By.Id("oldSelectMenu")));
            OldSelect.SelectByIndex(1);
            Assert.AreEqual(OldSelect.SelectedOption.Text, "Blue");

            driver.FindElement(By.XPath("//*[@id='selectMenuContainer']/div[7]/div/div/div[1]/div[1]")).Click();
            menuOp = driver.FindElement(By.Id("react-select-4-option-1")).Text;
            driver.FindElement(By.Id("react-select-4-option-1")).Click();
            Assert.AreEqual(menuOp, "Blue");

            SelectElement SelectMulti = new SelectElement(driver.FindElement(By.Id("cars")));
            SelectMulti.SelectByIndex(1);
            Assert.AreEqual(SelectMulti.SelectedOption.Text, "Saab");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
