using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            //Navigate to time and material page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            Wait.WaitToBeClickable(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",10);

            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }
    }
}
