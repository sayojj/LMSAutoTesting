using LMSAutoTesting.Drivers;
using OpenQA.Selenium.Interactions;

namespace LMSAutoTesting.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;   
        public abstract void Open();

        public AbstractPage()
        {
           _driver=DriverStorage.GetInstance().Driver;
        }

        public virtual void PressButton(IWebElement button)
        {
            Actions actions = new Actions(_driver);
            actions.DoubleClick(button).Perform();
        }
    }
}