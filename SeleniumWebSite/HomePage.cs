using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebSite
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(DriverInstance.driver, this);
        }
        
        [FindsBy(How = How.LinkText, Using = "Hotels")]
        public IWebElement HoteLink { get; set; }

        [FindsBy(How = How.Id, Using = "Tags")]
        public IWebElement LocalityTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "SearchHotelsButton")]
        public IWebElement SearchHotelsButton { get; set; }

        [FindsBy(How = How.Id, Using = "travellersOnhome")]
        public IWebElement TravellerSection { get; set; }

        [FindsBy(How = How.Id, Using = "FromTag")]
        public IWebElement FromLocation { get; set; }

        [FindsBy(How = How.Id, Using = "OneWay")]
        public IWebElement OneWayTag { get; set; }

        [FindsBy(How = How.Id, Using = "ToTag")]
        public IWebElement ToLocation { get; set; }

        [FindsBy(How = How.Id, Using = "ui-id-1")]
        public IWebElement AutoCompleteFromTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "ui-id-2")]
        public IWebElement AutoCompleteToTextBox { get; set; }

        [FindsBy(How = How.LinkText, Using = "Your trips")]
        public IWebElement YourTrips { get; set; }
        
        [FindsBy(How =How.Id,Using = "SearchBtn")]
        public IWebElement SearchFlightsButton { get; set; }

        [FindsBy(How = How.Id, Using = "CheckInDate")]
        public IWebElement CheckInDate { get; set; }

    }
}
