using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LMSAutoTesting.Pages
{
    public class HomePage : AbstractPage
    {
        public IWebElement Logout => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/div[3]/button/span"));
        public IWebElement ButtonStudentsList => _driver.FindElement(By.XPath(@"//a[@href='/students-list']"));
        public IWebElement ButtonSettings => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/nav/a[7]/span"));
        public IWebElement Username
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists((By.XPath(@"//span[@class='avatar-name transition-styles']"))));
            }
        }

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }

        public void PressSettings()
        {
            Actions actions = new Actions(_driver);
            actions.Click(ButtonSettings).Perform();
        }

        public void PressLogout()
        {
            Actions actions = new Actions(_driver);
            actions.Click(Logout).Perform();
        }
    }
}
