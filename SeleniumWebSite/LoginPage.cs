using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebSite
{
    class LoginPage
    {
        
        public LoginPage()
        {
            PageFactory.InitElements(DriverInstance.driver, this);
        }

        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.Id, Using = "signInButton")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Id, Using = "errors1")]
        public IWebElement ErrorsText { get; set; }

        [FindsBy(How = How.Id, Using = "modal_window")]
        public IWebElement LoginFrame { get; set; }

    }
}
