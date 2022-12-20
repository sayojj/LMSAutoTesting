using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class GroupsPage : AbstractPage
    {
        public IWebElement ButtonEditList => _driver.FindElement(By.XPath("//a[@href='/']"));
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void PressButton(IWebElement button)
        {
            Actions actions = new Actions(_driver);
            actions.Click(button).Perform();
        }
    }
}
