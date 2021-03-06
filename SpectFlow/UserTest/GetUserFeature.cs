using SpecFlowApi.Controllers;
using TechTalk.SpecFlow;

namespace SpecFlowTest.UserTest
{
    public class GetUserFeature
    {
        UserController userController;

        [Given(@"that a user exists in the system")]
        public void GivenThatAUserExistsInTheSystem()
        {
            throw new PendingStepException();
        }

        [When(@"I request to get the user by Id")]
        public void WhenIRequestToGetTheUserById()
        {
            throw new PendingStepException();
        }

        [Then(@"the user should be returned in the response")]
        public void ThenTheUserShouldBeReturnedInTheResponse()
        {
            throw new PendingStepException();
        }

        [Then(@"the response status code is '([^']*)'")]
        public void ThenTheResponseStatusCodeIs(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"that a user does not exists in the system")]
        public void GivenThatAUserDoesNotExistsInTheSystem()
        {
            throw new PendingStepException();
        }

        [Then(@"no user should be returned in the response")]
        public void ThenNoUserShouldBeReturnedInTheResponse()
        {
            throw new PendingStepException();
        }

    }
}
