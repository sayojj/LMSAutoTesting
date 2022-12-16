namespace LMSAutoTesting.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        [Given(@"first name is Anton")]
        public void GivenFirstNameIsAnton()
        {
            throw new PendingStepException();
        }

        [Given(@"last name is Efremenkov")]
        public void GivenLastNameIsEfremenkov()
        {
            throw new PendingStepException();
        }

        [Given(@"birthDate is (.*)")]
        public void GivenBirthDateIs(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"email is anton(.*)@mail\.ru")]
        public void GivenEmailIsAntonMail_Ru(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"password is антонмантон(.*)")]
        public void GivenPasswordIsАнтонмантон(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"phone number is \+(.*)")]
        public void GivenPhoneNumberIs(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"new usser is registrated")]
        public void WhenNewUsserIsRegistrated()
        {
            throw new PendingStepException();
        }

        //[Then(@"student registrated")]
        //public void ThenStudentRegistrated()
        //{
        //    throw new PendingStepException();
        //}
    }
}