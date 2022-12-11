using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class ChangePasswordStepDefinitions
    {
        [Given(@"Open your profil")]
        public void GivenOpenYourProfil()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.PasswordPage);
        }

        [When(@"Click edit password")]
        public void WhenClickEditPassword()
        {
            throw new PendingStepException();
        }

        [When(@": Text ""([^""]*)""")]
        public void WhenText(string p0)
        {
            throw new PendingStepException();
        }

        [When(@": click ""([^""]*)""")]
        public void WhenClick(string soxranit)
        {
            throw new PendingStepException();
        }

        [Then(@": Password changed")]
        public void ThenPasswordChanged()
        {
            throw new PendingStepException();
        }
    }
}
