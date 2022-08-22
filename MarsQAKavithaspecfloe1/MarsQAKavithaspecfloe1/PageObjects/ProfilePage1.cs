using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAspecflow1.PageObjects
{
    public class ProfilePage1
    {

        public void ProfilepageSteps(IWebDriver driver)
        {
            // Check if the user has logged in successfully
            IWebElement marsLogo = driver.FindElement(By.CssSelector("body:nth-child(2) div.ui:nth-child(1) div:nth-child(1) div.ui.secondary.menu:nth-child(1) > a.item"));
            Thread.Sleep(4000);


            if (marsLogo.Text == "Mars Logo")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

                         

            // click on Dexcription button
            IWebElement descriptionIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            descriptionIcon.Click();
            Thread.Sleep(2000);

            //Adding description summery in description field
            Thread.Sleep(3000);
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]"));
            descriptionTextbox.SendKeys("Selenium, C#, Spec flow");

            // click on description save button
            IWebElement descriptionsaveButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
            descriptionsaveButton.Click();
            Thread.Sleep(3000);


            //Adding availblity/ click on availbilty icom
            IWebElement availbityIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
            availbityIcon.Click();
            Thread.Sleep(3000);

            // Adding availbility
            IWebElement addAvailbilitySelecttype = driver.FindElement(By.Name("availabiltyType"));
            SelectElement element = new SelectElement(addAvailbilitySelecttype);
            element.SelectByText("Full Time");
            Thread.Sleep(3000);

            //Adding availble hours/ click on hours icom
            IWebElement availbleHoursIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/i[1]"));
            availbleHoursIcon.Click();
            Thread.Sleep(3000);

            // Adding hours inprofilepage
            IWebElement availbleHours = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/select[1]"));
            SelectElement elementHours = new SelectElement(availbleHours);
            elementHours.SelectByValue("1");
            Thread.Sleep(3000);

            //Click on earn target 
            IWebElement earnTargetIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]"));
            earnTargetIcon.Click();
            Thread.Sleep(2000);

        }

           
            }


        }
    
    

