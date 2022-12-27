using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public class ChangePasswordPage : AbstractPage
    {
        public IWebElement OldPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input"));
        public IWebElement NewPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[2]/input"));
        public IWebElement RepeatNewPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[3]/input"));
        public IWebElement ButtonSaveNewPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/button[1]"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.ChangePasswordPage);
        }

        public void EnterOldPassword(string oldPassword)
        {
            Actions actions = new Actions(_driver);
            actions.SendKeys(oldPassword).Build().Perform();    
        }

        public void EnterNewPassword(string newPassword)
        {
            Actions actions = new Actions(_driver);
            actions.SendKeys(newPassword).Build().Perform();
        }

        public void EnterRepeatNewPassword(string repeatNewPassword)
        {
            Actions actions = new Actions(_driver);
            actions.SendKeys(repeatNewPassword).Build().Perform();
        }
    }
}
