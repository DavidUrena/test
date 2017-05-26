using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Test.POM.Steps
{
    [Binding]
    public class FormSteps
    {
        [Given(@"I open the URL")]
        public void GivenIOpenTheURL()
        {
            BasePage.OpenURL();
        }
        
        [Given(@"I successfully complete all the fields with valid information")]
        public void GivenISuccessfullyCompleteAllTheFieldsWithValidInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I successfully complete all the fields with invalid information")]
        public void GivenISuccessfullyCompleteAllTheFieldsWithInvalidInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I successfully leave all the fields  blank")]
        public void GivenISuccessfullyLeaveAllTheFieldsBlank()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on guardar")]
        public void WhenIClickOnGuardar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should access the form page")]
        public void ThenIShouldAccessTheFormPage()
        {
            Assert.IsTrue(BasePage.PageSourceContains("page-wrapper"));
        }

        [Then(@"I should be directed to the success page")]
        public void ThenIShouldBeDirectedToTheSuccessPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Error validations should appear")]
        public void ThenErroValidationsShouldAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
