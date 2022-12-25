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