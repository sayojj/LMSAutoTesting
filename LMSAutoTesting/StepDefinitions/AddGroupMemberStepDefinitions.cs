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
        public int _courseId;
        HomePage homePage=new HomePage();
        AuthPage authPage=new AuthPage();
        GroupsPage groupPage=new GroupsPage();
        WebClient client = new WebClient();
        

        [Given(@"Registrate students with Api")]
        public void GivenRegistrateStudentsWithApi(Table table)
        {
            var tab = table.CreateSet<RegistrationRequestModel>().ToList();
            _studentId = client.GetUserId(tab[0]);
            _teacherId = client.GetUserId(tab[1]);
            _tutorId = client.GetUserId(tab[2]);

        }

        [Given(@"Auth as admin with api")]
        public void GivenAuthAsAdminWithApi(Table table)
        {
            var tab = table.CreateInstance<AuthRequestModel>();
            _adminToken = client.Auth(tab);
        }

        [Given(@"Give second student teacher role as admin")]
        public void GivenGiveSecondStudentTeacherRoleAsAdmin()
        {
            client.SetRole(_adminToken, _teacherId, "Teacher");
        }

        [Given(@"Give third student tutor role as admin")]
        public void GivenGiveThirdStudentTutorRoleAsAdmin()
        {
            client.SetRole(_adminToken, _tutorId, "Tutor");
        }

        [Given(@"Create courses as  admin")]
        public void GivenCreateCoursesAsAdmin(Table table)
        {
           var tab=table.CreateInstance<CourseRequestModel>();
            _courseId = client.GetIdCreatedCourse(_adminToken, tab);
        }


        [Given(@"Create group as  admin")]
        public void GivenCreateGroupAsAdmin(Table table)
        {
            var tab = table.CreateInstance<GroupRequestModel>();
            client.GetIdCreatedGroup(_adminToken, tab);
        }

        [Given(@"Open auth web page")]
        public void GivenOpenAuthWebPage()
        {
            authPage.Open();
        }

        [Given(@"Auth as admin")]
        public void GivenAuthAsAdmin(Table table)
        {
            var tab = table.CreateInstance<>();
            authPage.EnterEmail()
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
