using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebSite
{
    class ResultsPage
    {
        public ResultsPage()
        {
            PageFactory.InitElements(DriverInstance.driver, this);
        }
        [FindsBy(How = How.ClassName,Using ="searchSummary")]
        public IWebElement SearchSummary{get;set;}
    }
}
