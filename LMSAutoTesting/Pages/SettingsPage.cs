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
        public IWebElement buttonSetting => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/nav/a[7]/span"));
        public IWebElement passwordBox => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/div[1]/div/a/svg"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.SettingsPage);
        }
    }
}
