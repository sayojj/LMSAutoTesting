using LMSAutoTesting.Pages;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class ChangeNumberStepDefinitions
    {
        SettingsPage settingsPage = new settingsPage();

        [When(@"Click number")]
        public void WhenClickNumber()
        {
            settingsPage.PressNumber();
        }

        [When(@"Enter new number '([^']*)'")]
        public void WhenEnterNewNumber(string p0)
        {
            throw new PendingStepException();
        }
    }
}
