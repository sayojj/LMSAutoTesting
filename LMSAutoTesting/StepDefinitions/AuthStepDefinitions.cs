using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {
        [Given(@"Open Auth web page")]
        public void GivenOpenAuthWebPage()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        [When(@"Enter email ""([^""]*)""")]
        public void WhenEnterEmail(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Enter password ""([^""]*)""")]
        public void WhenEnterPassword(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Click enter button")]
        public void WhenClickEnterButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I have go to go to the site")]
        public void ThenIHaveGoToGoToTheSite()
        {
            throw new PendingStepException();
        }
    }
}
