using LMSAutoTesting.Pages;
using LMSAutoTesting.RequestModels;
using LMSAutoTesting.Support;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class AddGroupMemberStepDefinitions
    {
        public string _adminToken;
        public int _teacherId;
        public int _studentId;
        public int _tutorId;
        HomePage homePage=new HomePage();
        GroupsPage groupPage=new GroupsPage();
        WebClient client = new WebClient();
        

        [Given(@"Registrate students with Api")]
        public void GivenRegistrateStudentsWithApi(Table table)
        {
            var tab = table.CreateSet<RegistrationRequestModel>().ToList();
            _studentId = client.GetUserId(tab[0]);
            _teacherId = client.GetUserId(tab[1]);
            _teacherId = client.GetUserId(tab[2]);

        }

        [Given(@"Auth as admin with api")]
        public void GivenAuthAsAdminWithApi(Table table)
        {
            
        }

        [Given(@"Give second student teacher role as admin")]
        public void GivenGiveSecondStudentTeacherRoleAsAdmin()
        {
            throw new PendingStepException();
        }

        [Given(@"Give third student tutor role as admin")]
        public void GivenGiveThirdStudentTutorRoleAsAdmin()
        {
            throw new PendingStepException();
        }

        [Given(@"Create courses as admin")]
        public void GivenCreateCoursesAsAdmin()
        {
            throw new PendingStepException();
        }

        [Given(@"Create group as admin")]
        public void GivenCreateGroupAsAdmin()
        {
            throw new PendingStepException();
        }

        [Given(@"Open auth web page")]
        public void GivenOpenAuthWebPage()
        {
            throw new PendingStepException();
        }

        [Given(@"Auth as admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"Click groups on HomePage")]
        public void GivenClickGroupsOnHomePage()
        {
            throw new PendingStepException();
        }

        [Given(@"Click to edit list of group")]
        public void GivenClickToEditListOfGroup()
        {
            throw new PendingStepException();
        }

        [Then(@"Page of students should be opened")]
        public void ThenPageOfStudentsShouldBeOpened()
        {
            throw new PendingStepException();
        }
    }
}
