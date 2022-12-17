using LMSAutoTesting.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class HomePage : AbstractPage
    {
        public IWebElement Logout => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/div[3]/button/span"));
        public IWebElement buttonSetting => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/nav/a[7]/span"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }
    }
}
