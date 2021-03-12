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
        SeleniumSetup seleniumSetup = new SeleniumSetup();
        IWebDriver driver;

        [Given(@"I open the SHEdevelopment homepage")]
        public void GivenIOpenTheSHEdevelopmentHomepage()
        {
            seleniumSetup.GoToURL();
        }
        
        [Then(@"I successfully login")]
        public void ThenISuccessfullyLogin()
        {
            Thread.Sleep(2000);
            seleniumSetup.EnterUsername();
            seleniumSetup.EnterPassword();
            seleniumSetup.ClickLoginButton();
        }
        
        [Then(@"I navigate to Air Emissions module")]
        public void ThenINavigateToAirEmissionsModule()
        {
            Thread.Sleep(4000);
            seleniumSetup.openModulesDropdown();
            seleniumSetup.openEnvironmentsDropdown(); 
            seleniumSetup.SelectAirEmissions();
        }
        
        [Then(@"I click new record")]
        public void ThenIClickNewRecord()
        {
            Thread.Sleep(2000);
            seleniumSetup.AddNewRecordBTN();

        }
        
        [Then(@"I enter date and description")]
        public void ThenIEnterDateAndDescription()
        {
            seleniumSetup.AddDescription();
            seleniumSetup.SelectDate();
        }
        
        [Then(@"I save and close")]
        public void ThenISaveAndClose()
        {
            seleniumSetup.SaveAndClose();
            Thread.Sleep(3000);
        }
        
        [Then(@"I delete the record")]
        public void ThenIDeleteTheRecord()
        {
            seleniumSetup.deleteRecord();
        }
        
        [Then(@"verify record successfully deleted")]
        public void ThenVerifyRecordSuccessfullyDeleted()
        {
            seleniumSetup.verifyRecordDeleted();
        }
        
        [Then(@"log out")]
        public void ThenLogOut()
        {
            seleniumSetup.logout();
        }
    }
}
