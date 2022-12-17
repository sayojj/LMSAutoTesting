using LMSAutoTesting.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class ChangePasswordPage : AbstractPage
    {
        public IWebElement OldPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[1]/input"));
        public IWebElement NewPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[2]/input"));
        public IWebElement RepeatNewPassword => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[1]/div[3]/input"));
        public IWebElement ButtonSave => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[2]/button[1]"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.ChangePasswordPage);
        }
    }
}
