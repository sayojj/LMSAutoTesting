using LMSAutoTesting.Support;
using LMSAutoTesting.Drivers;
using LMSAutoTesting.Pages;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {

        AuthPage authPage = new AuthPage();
        SecurityWarningPage securityPage = new SecurityWarningPage();
        HomePage homePage = new HomePage();

        [Given(@"Open Registration web page")]
        public void GivenOpenRegistrationWebPage()
        {
            throw new PendingStepException();
        }

        [Given(@"Ignore security warning")]
        public void GivenIgnoreSecurityWarning()
        {
            securityPage.IgnoreAndPass();
        }

        [When(@"Fill the form")]
        public void WhenFillTheForm(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Click registrate")]
        public void WhenClickRegistrate()
        {
            throw new PendingStepException();
        }

        [When(@"Click authorize\(menu on the left\)")]
        public void WhenClickAuthorizeMenuOnTheLeft()
        {
            throw new PendingStepException();
        }

        [When(@"Enter email ""([^""]*)""")]
        public void WhenEnterEmail(string email)
        {
            authPage.EnterEmail(email);
        }

        [When(@"Enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            authPage.EnterPassword(password);
        }

        [When(@"Click enter button")]
        public void WhenClickEnterButton()
        {
            authPage.PressEnter();
        }

        [Then(@"Menu should be opened")]
        public void ThenIHaveGoToGoToTheSite()
        {
            string expected = "������";
            string actual = homePage.Username.Text;
            Assert.Equal(expected, actual);
        }
    }
}