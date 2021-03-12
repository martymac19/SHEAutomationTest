using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SHEAutomationTest1.Pages
{
    public class ModuleSelector
    {
        IWebDriver driver;

        public void SelectAirEmissions()
        {
            //driver = new ChromeDriver();
            IWebElement airEmissions = driver.FindElement(By.XPath("//a[@href='/automation/Environment/AirEmissions/Page/1']"));
            airEmissions.Click();
        }
    }
}
