using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebSite
{
    public static class WebDriverWaitForElement
    {
        public static IWebElement WaitForElementVisible(IWebDriver driver, IWebElement element)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(d => (element as IWebElement).Displayed);
                return element;
            }
            catch (NoSuchElementException) { element = null; }
            catch (WebDriverTimeoutException) { element = null ; }
            catch (TimeoutException) { element = null; }
            return element;
        }
    }
}
