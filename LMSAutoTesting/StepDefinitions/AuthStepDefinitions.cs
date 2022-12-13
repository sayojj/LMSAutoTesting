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
            string xPathMore = @"//button[@class = 'secondary-button small-link']";
            _driver.FindElement(By.XPath(xPathMore)).Click();
            string xPathGoTo = @"//a[@class='small-link']";
            _driver.FindElement(By.XPath(xPathGoTo)).Click();
        }

        [When(@"Enter email ""([^""]*)""")]
        public void WhenEnterEmail(string eMail)
        {
            string xPath = @"//input[@class = 'form-input']";
            IWebElement eMailBar = _driver.FindElement(By.XPath(xPath));
            eMailBar.SendKeys(eMail);
        }

        [When(@"Enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            string xPath = @"//input[@class = 'form-input custom-password']";
            IWebElement passwordBar=_driver.FindElement(By.XPath(xPath));
            passwordBar.Clear();
            passwordBar.SendKeys(password);
        }

        [When(@"Click enter button")]
        public void WhenClickEnterButton()
        {
            string xPath = @"/html/body/div/div/main/div[1]/form/div[3]/button[1]";
            _driver.FindElement(By.XPath(xPath)).Click();
            Thread.Sleep(500);
        }

        [Then(@"Menu should be opened")]
        public void ThenIHaveGoToGoToTheSite()
        {
            string expected = "Марина";
            string xPath = @"//span[@class = 'avatar-name transition-styles']";
            IWebElement firstName = _driver.FindElement(By.XPath(xPath));
            string actual = firstName.Text;
            Assert.Equal(expected, actual);
        }
    }
}
