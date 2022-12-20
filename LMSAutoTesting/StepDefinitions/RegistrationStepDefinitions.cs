using LMSAutoTesting.Drivers;
using LMSAutoTesting.Pages;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        HomePage homePage=new HomePage();
        AuthPage authPage=new AuthPage();
        RegistrationPage registrationPage = new RegistrationPage();
        SecurityWarningPage securityPage = new SecurityWarningPage();
        [Given(@"open register web page")]
        public void GivenOpenRegisterWebPage()
        {
            registrationPage.Open();
        }

        [When(@"first name is <first name>")]
        public void WhenFirstNameIsFirstName(string firstname)
        {
            registrationPage.Enterfirstname(firstname);
        }

        [When(@"last name is <last name>")]
        public void WhenLastNameIsLastName(string lastname)
        {
            registrationPage.Enterfirstname(lastname);
        }

        [When(@"patronymic is <patronymic>")]
        public void WhenPatronymicIsPatronymic(string patronymic)
        {
            registrationPage.Enterpatronymic(patronymic);
        }


        [When(@"birthDate is <data>")]
        public void WhenBirthDateIsData(string BirthDate)
        {
            registrationPage.Enterbirthdate(BirthDate);
        }

        [When(@"email is <email>")]
        public void WhenEmailIsEmail(string email)
        {
            registrationPage.Enteremail(email);
        }

        [When(@"password is <password>")]
        public void WhenPasswordIsPassword(string password)
        {
            registrationPage.Enterpassword(password);
        }

        [When(@"Repeat password")]
        public void WhenRepeatPassword(string repeatpassword)
        {
            registrationPage.Enterrepeatpassword(repeatpassword);
        }

        [When(@"phone number is <phone number>")]
        public void WhenPhoneNumberIsPhoneNumber(string PhoneNumber)
        {
            registrationPage.Enterphonenumber(PhoneNumber);
        }

        [When(@"click registrate")]
        public void WhenClickRegistrate()
        {
            throw new PendingStepException();
        }

        [When(@"auth web page")]
        public void WhenAuthWebPage()
        {
            authPage.Open();
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
            string expected = "Марина";
            string actual = homePage.Username.Text;
            Assert.Equal(expected, actual);
        }

        [Then(@"student <registrated>")]
        public void ThenStudentRegistrated()
        {
            registrationPage.Clickregistrate();
        }
    }
}