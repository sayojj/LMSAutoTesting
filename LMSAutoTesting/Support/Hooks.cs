using LMSAutoTesting.Drivers;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LMSAutoTesting.Support
{
    [Binding]
    public sealed class Hooks
    {
        private string _email = "anton11@example.com";
        private const string CONNECTIONSTRING = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverStorage.GetInstance().Driver.Close(); //driver?
        }

        [AfterScenario]
        public void ClientDelete()
        {
            using (IDbConnection dbConnection = new SqlConnection(CONNECTIONSTRING))
            {
                dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = '{_email}');");
                dbConnection.Query($"Delete FROM [DevEdu].[dbo].[User] where Email = '{_email}'");
            }
        }
    }
}




//using System.Data;
//using System.Data.SqlClient;
//using System.Globalization;
//using Dapper;
//using LMSTestingProjectQAABaku.StepDefinitions;

//namespace LMSTestingProjectQAABaku.Support
//{
//    [Binding]
//    public sealed class Hooks
//    {
//        [BeforeScenario]
//        public void BeforeScenario()
//        {

//            //List<string> emails = new List<string>();
//            //emails.Add(CreateTeacherStepDefinitions.Email);
//            //emails.Add(WatchHomeWorksAsStudentStepDefinitions.Email);
//            //emails.Add(ViewListOfStudentsAsManagerStepDefinitions.Email);
//            //emails.Add(AddNewGroupStepDefinitions.Email1);
//            //emails.Add(AddNewGroupStepDefinitions.Email2);
//            //emails.Add(EditCoursesAsMethodologistStepDefinitions.Email);
//            //emails.AddRange(CreateHomeworkStepDefinitions.Emails);

//            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
//            IDbConnection dbConnection = new SqlConnection(connectionString);
//            dbConnection.Open();
//            dbConnection.Query($"delete from Course_Material");
//            dbConnection.Query($"delete from Course_Topic");
//            dbConnection.Query($"delete from Material");
//            dbConnection.Query($"delete from Course_Task");
//            dbConnection.Query($"delete from StudentRating");
//            dbConnection.Query($"delete from User_Group");
//            dbConnection.Query($"delete from Group_Lesson");
//            dbConnection.Query($"delete from Comment");
//            dbConnection.Query($"delete from Student_Homework");
//            dbConnection.Query($"delete from Homework");
//            dbConnection.Query($"delete from Task");
//            dbConnection.Query($"delete from [Group]");
//            dbConnection.Query($"delete from Course");
//            dbConnection.Close();
//        }
//        [AfterScenario]
//        public void AfterScenario()
//        {
//            //List<string> emails = new List<string>();
//            //emails.Add(CreateTeacherStepDefinitions.Email);
//            //emails.Add(WatchHomeWorksAsStudentStepDefinitions.Email);
//            //emails.Add(ViewListOfStudentsAsManagerStepDefinitions.Email);
//            //emails.Add(AddNewGroupStepDefinitions.Email1);
//            //emails.Add(AddNewGroupStepDefinitions.Email2);
//            //emails.Add(EditCoursesAsMethodologistStepDefinitions.Email);
//            //emails.AddRange(CreateHomeworkStepDefinitions.Emails);
//            //DriverStorage.GetInstance().Driver.Close();
//            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
//            IDbConnection dbConnection = new SqlConnection(connectionString);
//            dbConnection.Open();
//            /*dbConnection.Query($"delete from Course_Material");
//            dbConnection.Query($"delete from Course_Topic");
//            dbConnection.Query($"delete from Material");
//            dbConnection.Query($"delete from Course_Task");
//            dbConnection.Query($"delete from StudentRating");
//            dbConnection.Query($"delete from User_Group");
//            dbConnection.Query($"delete from Group_Lesson");
//            dbConnection.Query($"delete from Comment");
//            dbConnection.Query($"delete from Student_Homework");
//            dbConnection.Query($"delete from Homework");
//            dbConnection.Query($"delete from Task");
//            dbConnection.Query($"delete from [Group]");
//            dbConnection.Query($"delete from Course");*/

//            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
//            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
//            dbConnection.Query($"delete from [User] where Email = 'rodionraskol30@gmail.com';");

//            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
//            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
//            dbConnection.Query($"delete from [User] where Email = 'willywonka30@gmail.com';");

//            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
//            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
//            dbConnection.Query($"delete from [User] where Email = 'chuchu30@gmail.com';");

//            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
//            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
//            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'dazai30@gmail.com');");
//            dbConnection.Query($"delete from [User] where Email = 'dazai30@gmail.com';");
//            dbConnection.Close();
//        }
//    }
//}