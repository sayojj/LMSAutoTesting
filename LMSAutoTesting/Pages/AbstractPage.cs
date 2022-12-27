using LMSAutoTesting.Drivers;
using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;   

        public AbstractPage()
        {
           _driver=DriverStorage.GetInstance().Driver;
        }

        public abstract void Open();

        public virtual void PressButton(IWebElement button)
        {
            Actions actions = new Actions(_driver);
            actions.Click(button).Perform();
        }
    }
}