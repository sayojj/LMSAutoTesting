using LMSAutoTesting.Drivers;

namespace LMSAutoTesting.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;   //Cделать public для SecurityWarningPage(open)

        public AbstractPage()
        {
           _driver=DriverStorage.GetInstance().Driver;
        }
        public abstract void Open();
    }
}