using LMSAutoTesting.Drivers;
using LMSAutoTesting.Pages;
using LMSAutoTesting.Support;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class ChangePasswordStepDefinitions
    {
       AuthPage authPage=new AuthPage();
       HomePage homePage=new HomePage();  
       SettingsPage settingsPage=new SettingsPage();
       ChangePasswordPage changePasswordPage=new ChangePasswordPage();

        [Given(@"Open Auth webpage")]
        public void GivenOpenAuthWebpage()
        {
            authPage.Open();
        }

        [When(@"Enter email '([^']*)'")]
        public void WhenEnterEMail(string eMail)
        {
            authPage.EnterEmail(eMail);
        }

        [When(@"Enter password '([^']*)'")]
        public void WhenEnterPassword(string password)
        {
            authPage.EnterPassword(password);
        }

        [When(@"Click login button")]
        public void WhenClickLoginButton()
        {
            authPage.PressButton(authPage.ButtonLogin);
        }

        [When(@"Open settings web page")]
        public void WhenOpenSettingsWebPage()
        {
            homePage.PressButton(homePage.ButtonSettings);
        }

        [When(@"Click edit password")]
        public void WhenClickEditPassword()
        {
           settingsPage.PressButton(settingsPage.ButtonEditPassword);
        }

        [When(@"Enter old password again '([^']*)'")]
        public void WhenEnterOldPassword(string oldPassword)
        {
            changePasswordPage.PressButton(changePasswordPage.OldPassword);
            changePasswordPage.EnterOldPassword(oldPassword);
        }

        [When(@"Enter new password '([^']*)'")]
        public void WhenEnterNewPassword(string newPassword)
        {
            changePasswordPage.PressButton(changePasswordPage.NewPassword);
            changePasswordPage.EnterNewPassword(newPassword);
        }

        [When(@"Repeat new password '([^']*)'")]
        public void WhenRepeatPassword(string newPassword)
        {
            changePasswordPage.PressButton(changePasswordPage.RepeatNewPassword);
            changePasswordPage.EnterRepeatNewPassword(newPassword);
        }


        [When(@"Click save")]
        public void WhenClickSave()
        {
            changePasswordPage.PressButton(changePasswordPage.ButtonSaveNewPassword);
        }

        [When(@"Log out from the web page")]
        public void WhenLogOutFromTheWebPage()
        {
            homePage.PressButton(homePage.Logout);
        }

        [When(@"Enter email again '([^']*)'")]
        public void WhenEnterEMailNew(string eMail)
        {
            authPage.EnterEmail(eMail);
        }

        [When(@"Enter new password again '([^']*)'")]
        public void WhenEnterPasswordNew(string password)
        {
            authPage.EnterPassword(password);
        }

        [When(@"Click login button again")]
        public void WhenClickLoginButtonNew()
        {
            authPage.PressButton(authPage.ButtonLogin);
        }

        [Then(@"Password changed")]
        public void ThenPasswordChanged()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.HomePage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}