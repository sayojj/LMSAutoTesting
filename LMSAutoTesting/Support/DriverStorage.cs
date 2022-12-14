using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Support
{
    public class DriverStorage
    {
        public WebDriver driver { get; set; }

        private static DriverStorage _driverStorage;

        private DriverStorage()
        {
        }

        public static DriverStorage GetInstance()
        {
            if (_driverStorage is null)
            {
                _driverStorage = new DriverStorage();
            }
            return _driverStorage;
        }
    }
}
