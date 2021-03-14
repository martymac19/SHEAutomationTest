using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using SHEAutomationTest1.Pages;
using System.Threading;

namespace SHEAutomationTest1.StepDefinition
{
    [Binding]
    public class SHEAutomationTestSteps
    {
        Selenium selenium = new Selenium();
        IWebDriver driver;

        [Given(@"I open the SHEdevelopment homepage")]
        public void GivenIOpenTheSHEdevelopmentHomepage()
        {
            selenium.GoToURL();
        }
        
        [Then(@"I successfully login")]
        public void ThenISuccessfullyLogin()
        {
            Thread.Sleep(2000);
            selenium.EnterUsername();
            selenium.EnterPassword();
            selenium.ClickLoginButton();
        }
        
        [Then(@"I navigate to Air Emissions module")]
        public void ThenINavigateToAirEmissionsModule()
        {
            Thread.Sleep(4000);
            selenium.openModulesDropdown();
            selenium.openEnvironmentsDropdown(); 
            selenium.SelectAirEmissions();
        }
        
        [Then(@"I click new record")]
        public void ThenIClickNewRecord()
        {
            Thread.Sleep(2000);
            selenium.AddNewRecordBTN();

        }
        
        [Then(@"I enter date and description")]
        public void ThenIEnterDateAndDescription()
        {
            selenium.AddDescription();
            selenium.SelectDate();
        }
        
        [Then(@"I save and close")]
        public void ThenISaveAndClose()
        {
            selenium.SaveAndClose();
            Thread.Sleep(3000);
        }
        
        [Then(@"I delete the record")]
        public void ThenIDeleteTheRecord()
        {
            selenium.deleteRecord();
        }
        
        [Then(@"verify record successfully deleted")]
        public void ThenVerifyRecordSuccessfullyDeleted()
        {
            selenium.verifyRecordDeleted();
        }
        
        [Then(@"log out")]
        public void ThenLogOut()
        {
            selenium.logout();
            Thread.Sleep(2000);
            selenium.closeBrowser();
        }
    }
}
