using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LMSAutoTesting.Pages
{
    public class SettingsPage : AbstractPage
    {
        public IWebElement ButtonEditPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/div[1]/div/a/svg"));
        public IWebElement ButtonSaveSettings => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement NumberBox
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='phoneNumber']")));
            }
        }

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.SettingsPage);
        }

        public void PressChangePassword()
        {
            Actions actions = new Actions(_driver);
            actions.Click(ButtonEditPassword).Perform();
        }

        public void EnterNewNumber(string number)
        {
            Actions actions = new Actions(_driver);
            actions.SendKeys(number).Perform();
        }
    }
}