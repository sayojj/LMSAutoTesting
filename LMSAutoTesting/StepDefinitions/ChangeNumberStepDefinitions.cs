using LMSAutoTesting.Pages;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class ChangeNumberStepDefinitions
    {
        HomePage homePage = new HomePage();
        SettingsPage settingsPage = new SettingsPage();

        [When(@"Click settings")]
        public void WhenClickSettings()
        {
            homePage.PressButton(homePage.ButtonSettings);
        }

        [When(@"Click number")]
        public void WhenClickNumber()
        {
            settingsPage.PressButton(settingsPage.NumberBox);
        }

        [When(@"Enter new number '([^']*)'")]
        public void WhenEnterNewNumber(string newNumber)
        {
            settingsPage.EnterNewNumber(newNumber);
        }

        [When(@"Click save settings")]
        public void WhenClickSaveSettings()
        {
            settingsPage.PressButton(settingsPage.ButtonSaveSettings);
        }

        [Then(@"Number changed")]
        public void ThenNumberChanged()
        {
            string expected = "77788666699";
            string actual = settingsPage.NumberBox.Text;
            Assert.Equal(expected, actual);
        }
    }
}