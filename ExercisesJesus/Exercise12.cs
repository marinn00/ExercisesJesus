using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Collections.Generic;

namespace ExercisesJesus
{
    internal class Exercise12
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.c-sharpcorner.com/register";
        }

        [Test]
        public void SelectCheckbox()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            IWebElement email = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxEmail"));
            jse.ExecuteScript("arguments[0].value='candidatex@qaisfun.com';", email);
            IWebElement firstName = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxFirstName"));
            jse.ExecuteScript("arguments[0].value='jesse';", firstName);
            IWebElement lastName = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxLastName"));
            jse.ExecuteScript("arguments[0].value='james';", lastName);
            IWebElement password = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxPassword"));
            jse.ExecuteScript("arguments[0].value='Qa1sfun';", password);
            IWebElement confirmPassword = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxPasswordConfirm"));
            jse.ExecuteScript("arguments[0].value='Qa1sfun';", confirmPassword);
            IWebElement country = driver.FindElement(By.Id("ctl00_ContentMain_DropdownListCountry"));
            jse.ExecuteScript("arguments[0].value='Mexico';", country);
            IWebElement zip = driver.FindElement(By.Id("TextBoxZip"));
            jse.ExecuteScript("arguments[0].value='97000';", zip);
            IWebElement city = driver.FindElement(By.Id("TextBoxCity"));
            jse.ExecuteScript("arguments[0].value='Merida';", city);
            IWebElement question = driver.FindElement(By.Id("ctl00_ContentMain_DropdownListSecurityQuesion"));
            jse.ExecuteScript("arguments[0].options[1];", question);
            IWebElement answer = driver.FindElement(By.Id("ctl00_ContentMain_TextBoxAnswer"));
            jse.ExecuteScript("arguments[0].value='A secret answer';", answer);
            IWebElement updates = driver.FindElement(By.Id("ctl00_ContentMain_CheckBoxNewsletter"));
            jse.ExecuteScript("arguments[0].click();", updates);
            IWebElement terms = driver.FindElement(By.Id("cbxIsGDPRAccepted"));
            jse.ExecuteScript("arguments[0].click();", terms);
            IWebElement submit = driver.FindElement(By.Id("ctl00_ContentMain_ButtonSave"));
            //jse.ExecuteScript("arguments[0].click();", submit);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
