using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public class SettingsPage : AbstractPage
    {
        public IWebElement ButtonEditPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/div[1]/div/a/svg"));
        public IWebElement NumberBox => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.SettingsPage);
        }

        public void PressChangePassword()
        {
            Actions actions = new Actions(_driver);
            actions.Click(ButtonChangePassword).Perform();
        }
    }
}