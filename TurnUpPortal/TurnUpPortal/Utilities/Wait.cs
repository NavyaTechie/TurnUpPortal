using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Utilities
{
    public class Wait
    {
        //Generic function to wait for an element to be clickable
        public static void WaitToBeClickable(IWebDriver driver,string locatorType,string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));
           
            if(locatorType =="XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username")));
            }
            if (locatorValue == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username")));
            }

        }
        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username")));
            }
            if (locatorValue == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username")));
            }

        }


    }
}
