using LMSAutoTesting.Drivers;
using LMSAutoTesting.Pages;
using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AddGroupMemberStepDefinitions
    {
        HomePage homepage= new HomePage();
        GroupsPage groupsPage= new GroupsPage();

        [When(@"press groups on HomePage")]
        public void WhenPressGroupsOnHomePage()
        {
            homepage.PressButton(homepage.ButtonGroups);
        }

        [When(@"edit students of group list")]
        public void WhenEditStudentsOfGroupList()
        {
            groupsPage.PressButton(groupsPage.ButtonEditList);
        }

        [Then(@"page of students should be opened")]
        public void ThenPageOfStudentsShouldBeOpened()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.StudentsListPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}
