namespace LMSAutoTesting.Drivers
{
    public class DriverStorage
    {
        public WebDriver Driver { get; private set; }

        private static DriverStorage _instance;

        private DriverStorage() 
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static DriverStorage GetInstance()
        {
            if (_instance is null)
            {
                _instance = new DriverStorage();
            }
            return _instance;
        }
    }
}