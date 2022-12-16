using LMSAutoTesting.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement eMailBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input']"));
        public IWebElement passwordBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input custom-password']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }
    }
}
