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
            BasePage.OpenUrl();
        }
        
        [Given(@"I successfully complete all the fields with valid information")]
        public void GivenISuccessfullyCompleteAllTheFieldsWithValidInformation()
        {
            BasePage.TypeDate("05/31/2018");
            BasePage.TypePatientDocument("80759224");
            BasePage.TypeDoctorDocument("80759224");
            BasePage.TypeObervation("Lorem Ipsum");
        }
        
        [Given(@"I successfully complete all the fields with invalid information in the documents")]
        public void GivenISuccessfullyCompleteAllTheFieldsWithInvalidInformation()
        {
            BasePage.TypeDate("05/31/2018");
            BasePage.TypePatientDocument("1");
            BasePage.TypeDoctorDocument("1");
        }
        
        [When(@"I click on guardar")]
        public void WhenIClickOnGuardar()
        {
            BasePage.SaveButtonClick();
        }

        [Then(@"I should access the form page")]
        public void ThenIShouldAccessTheFormPage()
        {
            Assert.IsTrue(BasePage.PageSourceContains("page-wrapper"));
        }

        [Then(@"I should be directed to the success page")]
        public void ThenIShouldBeDirectedToTheSuccessPage()
        {
            Assert.IsTrue(BasePage.PageSourceContains("Datos guardados correctamente"));
        }
        
        [Then(@"Error validations should appear")]
        public void ThenErroValidationsShouldAppear()
        {
            Assert.IsTrue(BasePage.PageSourceContains("no se encuentra entre nuestros doctores"));
            Assert.IsTrue(BasePage.PageSourceContains("no se encuentra entre nuestros pacientes"));
        }
    }
}
