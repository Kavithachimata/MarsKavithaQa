using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MarsQAspecflow1.Utilities;


namespace MarsQAspecflow1.PageObjects
{
    public class Education: Commondriver
    {
        public void educationepageSteps()
        {
            // Education button
            Thread.Sleep(3000);
            IWebElement clickOnEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            clickOnEducationButton.Click();
           
            // Add New Education button
            IWebElement addNeweducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNeweducationButton.Click();
            

            //Input University or collage name
            IWebElement collageOrUniversityName = driver.FindElement(By.Name("instituteName"));
            collageOrUniversityName.SendKeys("Krishna Collage");
            
            // Select country from the Dropdown list
            IWebElement selectCountry = driver.FindElement(By.Name("country"));
            SelectElement elementcountry = new SelectElement(selectCountry);
            elementcountry.SelectByValue("India");
            Thread.Sleep(1000);

            // Add title
            WebElement selecttitle = (WebElement)driver.FindElement(By.Name("title"));
            SelectElement elementtitle = new SelectElement(selecttitle);
            elementtitle.SelectByValue("M.Tech");
            Thread.Sleep(1000);

            // Qualification degree textbox
            IWebElement addtitleAchived = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            addtitleAchived.SendKeys("Degree");          

            // Passedout year
            WebElement passedoutYear = (WebElement)driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            SelectElement elementpassedout = new SelectElement(passedoutYear);
            elementpassedout.SelectByValue("2005");           

            // click on Add qualification button
            IWebElement addEducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducation.Click();
            Thread.Sleep(1000);
        }            
        public string GetUniversityName() // The newly added university
        {
           
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();
           
            IWebElement UniversityName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return UniversityName.Text;
        }
        public string GetNewCountryOfUniversity() // The newly added country of university
        {
            IWebElement newCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newCountryOfUniversity.Text;
        }
        public string GetNewTitle() // The newly added title
        {
            IWebElement newTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return newTitle.Text;
        }
        public string GetNewDegree() // The newly added degree
        {
            IWebElement newDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return newDegree.Text;
        }
        public string GetNewYearOfGraducation() // The newly added year of graduation
        {
            Thread.Sleep(4000);
            IWebElement newYearOfGraducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return newYearOfGraducation.Text;
        }
        public void EditEducation()// Edit a record of education

        {
            // Education button
            Thread.Sleep(3000);
            IWebElement clickOnEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            clickOnEducationButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // click on qualification edit icon
            IWebElement EducationEditIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            EducationEditIcon.Click();       
                       
            // Edit university name
            IWebElement editUniversityTextBox = driver.FindElement(By.Name("instituteName"));
            editUniversityTextBox.Clear();
            editUniversityTextBox.SendKeys("Sri University");

            // Select country from the Dropdown list for Edit
            IWebElement selectCountry = driver.FindElement(By.Name("country"));
            SelectElement elementcountry = new SelectElement(selectCountry);
            elementcountry.SelectByValue("Malaysia");
           
            // Add title education edit
            WebElement selecttitle = (WebElement)driver.FindElement(By.Name("title"));
            SelectElement elementtitle = new SelectElement(selecttitle);
            elementtitle.SelectByValue("PHD");
            Thread.Sleep(1000);

            // Edit Degree
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.Clear();
            degreeTextBox.SendKeys("degree");

            // EditPassedout year
            WebElement editpassedoutYear = (WebElement)driver.FindElement(By.Name("yearOfGraduation"));
            SelectElement elementpassedout = new SelectElement(editpassedoutYear);
            elementpassedout.SelectByValue("2008");
            Thread.Sleep(1000);

            // click on Edit qualification button
            IWebElement editEducationDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            editEducationDegree.Click();
            Thread.Sleep(1000);            
        }
        public string GetEditedCountryOfUniversity() // Get the edited country of university
        {
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement editedCountryOfUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editedCountryOfUniversity.Text;
        }
        public string GetEditedUniversity() // Get the edited university
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement editedUniversity = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editedUniversity.Text;          
        }
        public string GetEditedYearOfGraducation() // Get edited year of graduation
        {         
            
            IWebElement editedYearOfGraducation = driver.FindElement(By.XPath("//tbody/tr[1]/td[5]"));
            return editedYearOfGraducation.Text;
        }
        public string GetEditedTitle() // Get edited Title
        {           
            IWebElement editedTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return editedTitle.Text;
        }
        public string GetEditedDegree() // Get edited degree
        {            
            IWebElement editedDegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return editedDegree.Text;
        }
        public void DeleteEducation()  // Delte an existing education record
        {
            Thread.Sleep(1000);

            //Click on education button            
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();
            Thread.Sleep(2000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Delete University or collage record
            IWebElement deleteEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deleteEducationButton.Click();
            Thread.Sleep(2000);
        }
        public string GetEducationDeleteAlertMessage() // Get the alert message
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement deletedEducationAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedEducationAlertmMssage.Text;
        
        }
    }
}

    

