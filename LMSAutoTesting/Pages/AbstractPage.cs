using LMSAutoTesting.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;

        public AbstractPage()
        {
           _driver=DriverStorage.GetInstance().Driver;
        }
    }
}
