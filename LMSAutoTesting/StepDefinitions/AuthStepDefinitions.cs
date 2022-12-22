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

        [Given(@"Open Auth web page")]
        public void GivenOpenAuthWebPage()
        {
            authPage.Open();
        }

        [Given(@"Ignore security warning")]
        public void GivenIgnoreSecurityWarning()
        {
            securityPage.IgnoreAndPass();
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