using LMSAutoTesting.Drivers;
using LMSAutoTesting.Models;
using LMSAutoTesting.Pages;
using LMSAutoTesting.RequestModels;
using LMSAutoTesting.Support;
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
            var tab = table.CreateInstance<AuthorizeModel>();
            authPage.EnterEmail(tab.Email);
            authPage.EnterPassword(tab.Password);
        }

        [Given(@"Click login button")]
        public void GivenClickLoginButton()
        {
            authPage.PressButton(authPage.ButtonLogin);
        }

        [Given(@"Click groups on HomePage")]
        public void GivenClickGroupsOnHomePage()
        {
            homePage.PressButton(homePage.ButtonGroups);
        }

        [Given(@"Click to edit list of group")]
        public void GivenClickToEditListOfGroup()
        {
            groupPage.PressButton(groupPage.ButtonEditList);
        }

        [Then(@"Page of students should be opened")]
        public void ThenPageOfStudentsShouldBeOpened()
        {
            DriverStorage storage = DriverStorage.GetInstance();
            string expected = Urls.StudentsListPage;
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }
    }
}
