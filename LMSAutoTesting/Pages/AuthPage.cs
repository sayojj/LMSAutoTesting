using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement EmailBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input']"));
        public IWebElement ButtonRegisterInMenu => _driver.FindElement(By.XPath(@"//a[text()='Регистрация']"));
        public IWebElement PasswordBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input custom-password']"));
        public IWebElement ButtonLogin => _driver.FindElement(By.XPath(@"//button[@class = 'sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        public void EnterEmail(string email)
        {
            Actions actions= new Actions(_driver);
            actions.Click(EmailBox).SendKeys(email).Build().Perform();
        }

        public void EnterPassword(string password)
        {
            Actions actions = new Actions(_driver);
            PasswordBox.Clear();
            actions.Click(PasswordBox). SendKeys(password).Build().Perform();
        }
    }
}