using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;


namespace SHEAutomationTest1.Pages
{
    public class SeleniumSetup
    {
        string test_url = "https://stirling.she-development.net/automation";
        string createRecordURL = "https://stirling.she-development.net/automation/Environment/AirEmissions/Create#/information";
        IWebDriver driver;

        public void GoToURL()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        public void EnterUsername()
        {
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("MartinM");
        }

        public void EnterPassword()
        {
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("1234!MartinM");
        }

        public void ClickLoginButton()
        {
            IWebElement loginBTN = driver.FindElement(By.Id("login"));
            loginBTN.Click();
        }

        public void openModulesDropdown()
        {
            IWebElement openModules = driver.FindElement(By.LinkText("Modules"));
            openModules.Click();
        }

        public void openEnvironmentsDropdown()
        {
            Actions actions = new Actions(driver);

            IWebElement openEmissions = driver.FindElement(By.LinkText("Environment"));

            actions.MoveToElement(openEmissions).Perform();
        }

        public void SelectAirEmissions()
        {
            IWebElement airEmissions = driver.FindElement(By.XPath("//a[@href='/automation/Environment/AirEmissions/Page/1']"));
            airEmissions.Click();
        }

        public void AddNewRecordBTN()
        {
            //driver.Url = createRecordURL;

            //IWebElement addNewRecord = driver.FindElement(By.XPath("//i[@class='fa fa-plus fa-inverse fa-lg']"));
            //addNewRecord.Click();
        }

        public void AddDescription()
        {
            //IWebElement addDescription = driver.FindElement(By.Id("SheAirEmissions_Description"));
            //addDescription.SendKeys("This is a test description");
        }

        public void SelectDate()
        {
            //IWebElement selectDate = driver.FindElement(By.Id("SheAirEmissions_SampleDate"));
            //selectDate.SendKeys("12032021");
        }

        public void SaveAndClose()
        {
            //IWebElement addNewRecord = driver.FindElement(By.XPath("//button[@value='Close']"));
            //addNewRecord.Click();
        }

        public void deleteRecord()
        {
            //IWebElement clickCog =  driver.FindElements(By.XPath("//Button[@class='btn btn-large dropdown-toggle']"))[2];
            //clickCog.Click();

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement deleteRecord = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Delete")));
            //deleteRecord.Click();

            //IWebElement confirmDelete = driver.FindElement(By.XPath("//button[contains(text(), 'Confirm')]"));
            //confirmDelete.Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void verifyRecordDeleted()
        {
            if (IsElementPresent(By.Id("element name")))
            {
                //do if exists
            }
            else
            {
                //do if does not exists
            }

            string text = "";

            List<IWebElement> list = driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));
            Assert.assertTrue("Text not found!", list.size() > 0);
        }

        public void logout()
        {
            IWebElement clickUsername = driver.FindElement(By.Id("uservoice-activation"));
            clickUsername.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement logout = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='/automation/Logout']")));
            logout.Click();
        }
    }
}
