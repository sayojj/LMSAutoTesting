using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LMSAutoTesting.Pages
{
    public class RegistrationPage : AbstractPage
    {
        public IWebElement ButtonLoginInMenu => _driver.FindElement(By.XPath("//a[text()='Вход']"));
        public IWebElement Name
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='firstName']")));
            }
        }
        public IWebElement Surname => _driver.FindElement(By.XPath(@"//input[@class='form-input']"));
        public IWebElement BirthDate => _driver.FindElement(By.XPath(@"//div[@class='date-picker form-input']"));
        public IWebElement Email => _driver.FindElement(By.XPath(@"//div[@class='date-picker form-input']"));
        public IWebElement Patronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement Password => _driver.FindElement(By.XPath(@"//input[@class='custom-password form-input']"));
        public IWebElement RepeatPassword => _driver.FindElement(By.XPath(@"//input[@name='=> _driver.FindElement(By.XPath(@']"));
        public IWebElement Phone => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement ClickRegistrate => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);
        }

        public void EnterInfo(string surname,string name, string patronymic,string birthdate,string password,string repeatpassword,string email,string phone)
        {
            Actions actions = new Actions(_driver);
            actions.Click(Name).SendKeys(name).Build().Perform();
            actions.Click(Surname).SendKeys(surname).Build().Perform();
            actions.Click(Patronymic).SendKeys(patronymic).Build().Perform();
            actions.Click(Email).SendKeys(email).Build().Perform();
            actions.Click(BirthDate).SendKeys(birthdate).Build().Perform();
            actions.Click(Password).SendKeys(password).Build().Perform();
            actions.Click(RepeatPassword).SendKeys(repeatpassword).Build().Perform();
            actions.Click(Phone).SendKeys(phone).Build().Perform();
        }
    }
}
