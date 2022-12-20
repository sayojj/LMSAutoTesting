using LMSAutoTesting.Pages;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AddGroupMemberStepDefinitions
    {
        HomePage homepage= new HomePage();
        [When(@"press groups on HomePage")]
        public void WhenPressGroupsOnHomePage()
        {
            homepage.PressButton(homepage.ButtonStudentsList);
        }

        [When(@"edit students of group list")]
        public void WhenEditStudentsOfGroupList()
        {
            throw new PendingStepException();
        }

        [Then(@"page of students should be opened")]
        public void ThenPageOfStudentsShouldBeOpened()
        {
            throw new PendingStepException();
        }
    }
}
