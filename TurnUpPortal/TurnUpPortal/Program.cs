using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        //Open web browser
        IWebDriver driver = new ChromeDriver();
        // Launch TurnUp Portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        
        //Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //Identify password textbox and enter valid password

        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        //Identify login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        // Check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if(helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully. Test passed!");
        }
        else
        {
            Console.WriteLine("User has not logged in. Test failed");
        }
        //Create a new time record

        //Navigate to time and material page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();

        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialOption.Click();


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
        
        //Click on Save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        //Check if Time record has been created succesfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        if(newCode.Text == "TA Programme")
        {
            Console.WriteLine("Time record created successfully!");
        }
        else
        {
            Console.WriteLine("New time has not been created!");
        }

    }
}