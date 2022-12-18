using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public class SecurityWarningPage : AbstractPage
    {
        public IWebElement moreInfo => _driver.FindElement(By.XPath(@"//button[@class = 'secondary-button small-link']"));
        public IWebElement goTo => _driver.FindElement(By.XPath(@"//a[@class='small-link']"));

        public override void Open() 
        {
        }

        public void IgnoreAndPass()
        {
            Actions actions= new Actions(_driver);
            actions.Click(moreInfo).Click(goTo).Build().Perform();
        }
    }
}