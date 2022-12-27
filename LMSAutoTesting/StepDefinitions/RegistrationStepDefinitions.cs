using LMSAutoTesting.Support;
using LMSAutoTesting.Drivers;
using LMSAutoTesting.Pages;
using TechTalk.SpecFlow.Assist;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        AuthPage authPage = new AuthPage();
        SecurityWarningPage securityPage = new SecurityWarningPage();
        HomePage homePage = new HomePage();
        RegistrationPage registrationPage = new RegistrationPage();

        [Given(@"Open Registration web page")]
        public void GivenOpenRegistrationWebPage()
        {
            registrationPage.Open(); 
        }

        [Given(@"Ignore security warning")]
        public void GivenIgnoreSecurityWarning()
        {
            securityPage.IgnoreAndPass();
        }

        [When(@"Fill the form")]
        public void WhenFillTheForm(Table table)
        {
            authPage.PressButton(authPage.ButtonRegisterInMenu);
            var form = table.CreateInstance<Models.RegistrationModel>();
            registrationPage.EnterInfo(form.Surname, form.Name, form.Patronymic, form.BirthDate, form.Password, form.RepeatPassword, form.Email, form.Phone);
        }

        [When(@"Click registrate")]
        public void WhenClickRegistrate()
        {
            registrationPage.PressButton(registrationPage.ClickRegistrate);
        }

        [When(@"Click authorize\(menu on the left\)")]
        public void WhenClickAuthorizeMenuOnTheLeft()
        {
            registrationPage.PressButton(registrationPage.ButtonLoginInMenu);
        }

        [When(@"Enter email ""([^""]*)""")]
        public void WhenEnterEmail(string email)
        {
            authPage.EnterEmail(email);
        }

        [When(@"Enter  password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            authPage.EnterPassword(password);
        }

        
        [When(@"Click enter button")]
        public void WhenClickEnterButton()
        {
            authPage.PressButton(authPage.ButtonLogin);
        }

        [Then(@"Menu should be opened")]
        public void ThenMenuShouldBeOpened()
        {
            string expected = "Антон";
            string actual = homePage.Username.Text;
            Assert.Equal(expected, actual);
        }
    }
}