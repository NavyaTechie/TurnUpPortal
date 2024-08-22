using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class LoginPage
    {
        // Functions that allow users to login to TurnUp portal
        public void LoginActions(IWebDriver driver)
        {
            // Launch TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            
            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver,"Id","Password",7);

            //Identify password textbox and enter valid password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
            
        }
    }
}
