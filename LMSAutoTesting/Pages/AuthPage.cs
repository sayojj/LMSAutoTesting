using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement emailBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input']"));
        public IWebElement passwordBox => _driver.FindElement(By.XPath(@"//input[@class = 'form-input custom-password']"));
        public IWebElement buttonEnter => _driver.FindElement(By.XPath(@"//button[@class = 'sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.AuthPage);
        }

        public void EnterInfo(string email, string password)
        {
            Actions actions= new Actions(_driver);
            actions.Click(emailBox).SendKeys(email).Build().Perform();
            actions.Click(passwordBox).SendKeys(password).Build().Perform();
        }

        public void PressEnter()
        {
            Actions actions = new Actions(_driver);
            actions.Click(buttonEnter).Perform();
        }
    }
}
