using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class SettingsPage : AbstractPage
    {
        public IWebElement ButtonChangePassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/div[1]/div/a/svg"));

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
