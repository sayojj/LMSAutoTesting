using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {
        public WebDriver _driver;
        [Given(@"Open Auth web page")]
        public void GivenOpenAuthWebPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        [Given(@"Ignore security warning")]
        public void GivenIgnoreSecurityWarning()
        {
            string xPathMore = @"/html/body/div/div[2]/button[3]";
            _driver.FindElement(By.XPath(xPathMore)).Click();
            string xPathGoTo = @"/html/body/div/div[3]/p[2]/a";
            _driver.FindElement(By.XPath(xPathGoTo)).Click();
        }

        [When(@"Enter email ""([^""]*)""")]
        public void WhenEnterEmail(string eMail)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement eMailBar = _driver.FindElement(By.XPath(xPath));
            eMailBar.SendKeys(eMail);
        }

        [When(@"Enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement passwordBar=_driver.FindElement(By.XPath(xPath));
            passwordBar.Clear();
            passwordBar.SendKeys(password);
        }

        [When(@"Click enter button")]
        public void WhenClickEnterButton()
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[3]/button[1]";
            _driver.FindElement(By.XPath(xPath)).Click();
        }

        [Then(@"Menu should be opened")]
        public void ThenIHaveGoToGoToTheSite()
        {
            //string xPath = @"/html/body/div/div/aside";
            //Assert.Is
        }
    }
}
