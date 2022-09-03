using MarsQAspecflow1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQAspecflow1.PageObjects
{
    public class ProfilePage1 : Commondriver
    {
        public void ProfilepageSteps()
        {
            Thread.Sleep(3000);
            // click on Dexcription button
            IWebElement descriptionIcon = driver.FindElement(By.XPath("//html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            descriptionIcon.Click();
           
            //Adding description summery in description field
            Thread.Sleep(1000);
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]"));
            descriptionTextbox.SendKeys("Selenium, C#, Spec flow");

            // click on description save button
            IWebElement descriptionsaveButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
            descriptionsaveButton.Click();
        }
        public string GetNewDescriptionAlertMessage() // Get the alaert message
            {
                WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);
                string alertMessageXPath = "//div[@class='ns-box-inner']";
                IWebElement newDescriptionAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                return newDescriptionAlertmMssage.Text;
            }
        public void AddAvailbility() // Add availability, hours and earn target on profile
        {
            //Adding availblity/ click on availbilty icom
            IWebElement availbityIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
            availbityIcon.Click();
           
            // Adding availbility
            IWebElement addAvailbilitySelecttype = driver.FindElement(By.Name("availabiltyType"));
            SelectElement element = new SelectElement(addAvailbilitySelecttype);
            element.SelectByText("Full Time");
          
            //Adding availble hours/ click on hours icom
            IWebElement availbleHoursIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/i[1]"));
            availbleHoursIcon.Click();
            
            // Adding hours inprofilepage
            IWebElement availbleHours = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/select[1]"));
            SelectElement elementHours = new SelectElement(availbleHours);
            elementHours.SelectByValue("1");
            Thread.Sleep(2000);

            //Click on earn target 
            IWebElement earnTargetIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]"));
            earnTargetIcon.Click();
        }
        public string GetNewAvailabilityAlertMessage() // Get the alert message 
        {
            Thread.Sleep(1000);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement newAvailablityAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
            return newAvailablityAlertmMssage.Text;


        }

           
        }


        }
    
    

