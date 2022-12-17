using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class Settings : AbstractPage
    {
        public IWebElement passwordBox => _driver.FindElement(By.XPath(@"//div[@class='form-input']));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }
    }
}
