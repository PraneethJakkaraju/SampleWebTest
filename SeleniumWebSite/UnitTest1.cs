using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace SeleniumWebSite
{
    
    public class UnitTest1
    {
        [SetUp]
        public void SetUp()
        {
            DriverInstance.driver  = new ChromeDriver();
            DriverInstance.driver.Navigate().GoToUrl("https://www.cleartrip.com");
            DriverInstance.driver.Manage().Window.Maximize();
        }
        [Test]
        public void SignInTest()
        {
            HomePage home = new HomePage();
            LoginPage login = new LoginPage();
            home.YourTrips.Click();
            login.SignIn.Click();
            DriverInstance.driver.SwitchTo().Frame(login.LoginFrame);
            login.SignInButton.Click();
            string error = login.ErrorsText.Text;
            Assert.IsTrue(error.Contains("There were errors in your submission"));
        }
        [Test]
        public void HotelBookingTest()
        {
            HomePage home = new HomePage();
            ResultsPage result = new ResultsPage();
            home.HoteLink.Click();
            home.LocalityTextBox.SendKeys("Indiranagar, Bangalore");
            WebDriverWaitForElement.WaitForElementVisible(DriverInstance.driver, home.AutoCompleteFromTextBox);
            home.LocalityTextBox.SendKeys(Keys.Tab);
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverInstance.driver;
            js.ExecuteScript("document.getElementById('CheckInDate').value='2018-01-01'");
            js.ExecuteScript("document.getElementById('CheckOutDate').value='2018-01-02'");
            new SelectElement(home.TravellerSection).SelectByText("1 room, 2 adults");
            home.SearchHotelsButton.Click();
            ResultsPage res = new ResultsPage();
            Assert.IsNotNull(res.SearchSummary);
        }
        [Test]
        public void FlightBooking()
        {
            HomePage home = new HomePage();
            home.OneWayTag.Click();
            home.FromLocation.SendKeys("Bangalore");
            WebDriverWaitForElement.WaitForElementVisible(DriverInstance.driver, home.AutoCompleteFromTextBox);
            home.FromLocation.SendKeys(Keys.Tab);
            home.ToLocation.SendKeys("Delhi");
            WebDriverWaitForElement.WaitForElementVisible(DriverInstance.driver, home.AutoCompleteToTextBox);
            home.ToLocation.SendKeys(Keys.Tab);
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverInstance.driver;
            js.ExecuteScript("document.getElementById('DepartDate').value='01-01-2018'");
            home.SearchFlightsButton.Click();
            ResultsPage res = new ResultsPage();
            Assert.IsNotNull(res.SearchSummary);
        }

        [TearDown]
        public void CloseDriver()
        {
            DriverInstance.driver.Close();
        }


        
    }
}
