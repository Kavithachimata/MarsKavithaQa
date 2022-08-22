using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAspecflow1.PageObjects
{
   public class Education
    {
        public void educationepageSteps(IWebDriver driver)
        {
            // Education button
            //IWebElement clickOnEducationButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
            IWebElement clickOnEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            clickOnEducationButton.Click();
            Thread.Sleep(5000);

            // Add New Education button
            IWebElement addNeweducationButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            addNeweducationButton.Click();
            Thread.Sleep(5000);

            //Input University or collage name
            IWebElement collageOrUniversityName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            collageOrUniversityName.SendKeys("Narayana collage");
            Thread.Sleep(5000);


            // Select country from the Dropdown list
            IWebElement selectCountry = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement elementcountry = new SelectElement(selectCountry);
            elementcountry.SelectByValue("India");
            Thread.Sleep(3000);


            // Add title
            WebElement selecttitle = (WebElement)driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            SelectElement elementtitle = new SelectElement(selecttitle);
            elementtitle.SelectByValue("M.Tech");
            Thread.Sleep(4000);

            // Qualification degree textbox
            IWebElement addtitleAchived = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            addtitleAchived.SendKeys("Degree");
            Thread.Sleep(3000);

            // Passedout year
            WebElement passedoutYear = (WebElement)driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            SelectElement elementpassedout = new SelectElement(passedoutYear);
            elementpassedout.SelectByValue("2010");
            Thread.Sleep(4000);

            // click on Add qualification button
            IWebElement addEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            addEducation.Click();
            Thread.Sleep(4000);


            // click on qualification edit icon
            IWebElement EducationEditIcon = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
            EducationEditIcon.Click();
            Thread.Sleep(4000);



            // Add title
            WebElement editselecttitle = (WebElement)driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            SelectElement editelementtitle = new SelectElement(selecttitle);
            editelementtitle.SelectByValue("PHD");
            Thread.Sleep(4000); ;

            // click on Edit qualification button
            IWebElement editEducationDegree = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]"));
            editEducationDegree.Click();
            Thread.Sleep(4000);

            //Delete University or collage record
            IWebElement collageOrUniversityDelete = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            collageOrUniversityDelete.Clear();
            Thread.Sleep(5000);


            // Click on qualification Delete icon 
            IWebElement educationDeleteIcon = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
            educationDeleteIcon.Click();
            Thread.Sleep(8000);
            //tbody/tr[1]/td[6]/span[2]/i[1]


        }
        public string DeleteEduRecord(IWebDriver driver)

        {
            IWebElement GetdeleteEducationRecord = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
            return GetdeleteEducationRecord.Text;

        }
    }


    }
    


