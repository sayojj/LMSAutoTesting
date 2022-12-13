using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class ChangePasswordStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Open your profil")]
        public void GivenOpenYourProfil()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }

        [When(@"Click edit password")]
        public void WhenClickEditPassword()
        {
            string xPath = @"/ html / body / div / div / main / div[1] / form / div[2] / div[1] / div / a / svg";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
        }

        [When(@"zapolnit formu")]
        public void WhenZapolnitFormu(string zapolnit)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.SendKeys(zapolnit);
        }

        [When(@"click ""([^""]*)""")]
        public void WhenClick(string soxranit)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.SendKeys(soxranit);
        }

        [Then(@"Password changed")]
        public void ThenPasswordChanged()
        {
            string expected = "https://piter-education.ru:7074/";
            string actual = _driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}
 