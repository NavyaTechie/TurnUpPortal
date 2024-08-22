using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on Create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            //Select Time from dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timeOption.Click();

            //Type code into Code textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("TA Programme");
            //Type description into Description textbox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("This is a description");

            //Type price into Price textbox
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("12");

            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);


            //Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //Check if Time record has been created succesfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "TA Programme")
            {
                Console.WriteLine("Time record created successfully!");
            }
            else
            {
                Console.WriteLine("New time has not been created!");
            }
        }
        public void EditTimeRecord(IWebDriver driver) 
        {
            //edit code
            
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Edit Code textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("New TA Programme");

            //Type description into Description textbox
            //IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            //descriptionTextBox.Clear();
            //descriptionTextBox.SendKeys("This is a  edited description");

            //Type price into Price textbox
            //IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //priceTagOverlap.Click();

            //IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            //priceTextBox.SendKeys("12");


            //Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            IWebElement eLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            eLastPageButton.Click();
            Thread.Sleep(1000);

            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editCode.Text == "New TA Programme")
            {
                Console.WriteLine("Time record edited successfully!");
            }
            else
            {
                Console.WriteLine("New time has not been edited!");
            }
            Thread.Sleep(2000);
        }
        public void DeleteTimeRecord(IWebDriver driver)
        {
            //delete code
            IWebElement eLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            eLastPageButton.Click();
            Thread.Sleep(1000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);

            //Clicking on OK to Delete

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);


            IWebElement deleteCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if(deleteCode.Text == "New TA Programme")
            {

                Console.WriteLine("Time record deleted successfully!");
            }
            else
            {
                Console.WriteLine("New time has not been deleted!");
            }

        }
    }
}
