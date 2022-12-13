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
        [Given(@"Open Auth webpage")]
        public void GivenOpenAuthWebpage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("ignore-certificate-errors");
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        [When(@"Enter email '([^']*)'")]
        public void WhenEnterEMail(string eMail)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement eMailBar = _driver.FindElement(By.XPath(xPath));
            eMailBar.Clear();
            eMailBar.SendKeys(eMail);
        }

        [When(@"Enter password '([^']*)'")]
        public void WhenEnterPassword(string password)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement passwordBar = _driver.FindElement(By.XPath(xPath));
            passwordBar.Clear();
            passwordBar.SendKeys(password);
        }

        [When(@"Click login button")]
        public void WhenClickLoginButton()
        {
            string xPath = @"//*[@id=""root""]/div/main/div[1]/form/div[3]/button[1]";
            _driver.FindElement(By.XPath(xPath)).Click();
        }

        [When(@"Open settings web page")]
        public void WhenOpenSettingsWebPage()
        {
            _driver.Navigate().GoToUrl(Urls.SettingsPage);
        }

        [When(@"Click edit password")]
        public void WhenClickEditPassword()
        {
            string xPath = @"//*[@id=""root""]/div/main/div[1]/form/div[2]/div[1]/div/a";
            _driver.FindElement(By.XPath(xPath)).Click();
        }

        [When(@"Enter old password again '([^']*)'")]
        public void WhenEnterOldPassword(string oldPassword)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.SendKeys(oldPassword);
        }

        [When(@"Enter new password '([^']*)'")]
        public void WhenEnterNewPassword(string newPassword)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.SendKeys(newPassword);
        }

        [When(@"Repeat new password '([^']*)'")]
        public void WhenRepeatPassword(string newPassword)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.SendKeys(newPassword);
        }


        [When(@"Click save")]
        public void WhenClickSave()
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input";
            IWebElement textBox = _driver.FindElement(By.XPath(xPath));
            textBox.Click();
        }

        [When(@"Log out from the web page")]
        public void WhenLogOutFromTheWebPage()
        {
            string xPath = "/html/body/div/div/aside/div/div[3]/button/span";
            IWebElement exitButton = _driver.FindElement(By.XPath(xPath));
            exitButton.Click();
        }

        [When(@"Open Auth webpage again")]
        public void GivenOpenAuthWebpageNew()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("ignore-certificate-errors");
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        [When(@"Enter email again '([^']*)'")]
        public void WhenEnterEMailNew(string eMail)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement eMailBar = _driver.FindElement(By.XPath(xPath));
            eMailBar.SendKeys(eMail);
        }

        [When(@"Enter new password again '([^']*)'")]
        public void WhenEnterPasswordNew(string password)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement passwordBar = _driver.FindElement(By.XPath(xPath));
            passwordBar.Clear();
            passwordBar.SendKeys(password);
        }

        [When(@"Click login button again")]
        public void WhenClickLoginButtonNew()
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[3]/button[1]";
            _driver.FindElement(By.XPath(xPath)).Click();
        }

        [Then(@"Password changed")]
        public void ThenPasswordChanged()
        {
            string expected = "https://piter-education.ru:7074/login";
            string actual = _driver.Url;
            Assert.Equal(expected, actual);
        }

    }
}
 