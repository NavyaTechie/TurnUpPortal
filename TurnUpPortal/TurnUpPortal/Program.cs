using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TurnUpPortal.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        
        //Open web browser
        IWebDriver driver = new ChromeDriver();
        
        
        //Login page object initialization and defintion
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TM page object initialization and definition
        TMPage tMPageObj= new TMPage();
        tMPageObj.CreateTimeRecord(driver);

        // Edit Time Record
        tMPageObj.EditTimeRecord(driver);
       
        //Delete Time Record 
        tMPageObj.DeleteTimeRecord(driver);



           
        

        
        

    }
}