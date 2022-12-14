using LMSAutoTesting.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LMSAutoTesting.Pages
{
    public class HomePage : AbstractPage
    {
        public IWebElement Logout => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/div[3]/button/span"));
        public IWebElement ButtonStudentsList => _driver.FindElement(By.XPath(@"//a[@href='/students-list']"));
        public IWebElement ButtonGroups
        {
            get
            {
                WebDriverWait driverWait=new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@href='/groups']")));
            }
        }
        public IWebElement ButtonSettings
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists((By.XPath(@"//span[text()='Максина']"))));
            }
        }
        public IWebElement Username
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists((By.XPath(@"//span[text()='Антон']"))));
            }
        }

        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.HomePage);
        }
    }
}
