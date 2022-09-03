using MarsQAspecflow1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQAspecflow1.PageObjects
{
    public class Languages: Commondriver
    {       
        public void LanuagePageSteps()
        {
            //Clickon language
            IWebElement clickOnLanguageButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
            clickOnLanguageButton.Click();
            Thread.Sleep(2000);

            // Adding language/ Clickon Add new
            IWebElement addNewLanuage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewLanuage.Click();
           
            //Input Language Text
            IWebElement languageTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            languageTextbox.SendKeys("Spanish3");
            
            //Choose language level from the Dropdown list
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement elementLevel = new SelectElement(chooseLanguageLevel);
            elementLevel.SelectByText("Basic");
           
            // click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(1000);
        }                 
        public string GetNewLanguage()   // Get the newly added language
        {
            Thread.Sleep(1000);

            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            return newLanguage.Text;
        }
        public string GetNewLanguageLevel() // Get the newly added language level
        {
            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newLanguageLevel.Text;
        }
        public void EditLanguage() // Edit the record of the existing Languages
        {
            //Click on Language
            IWebElement ClickonLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            ClickonLanguage.Click();
            
            // click on  Language Update icon
            IWebElement updateSymbel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            updateSymbel.Click();
           
            //Input Language Text
            IWebElement languageTextboxEdit = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            languageTextboxEdit.Clear();
            languageTextboxEdit.SendKeys("Latin");
                       
            //Choose language level from the Dropdown list for update
            IWebElement updateLanguageLevel = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            SelectElement elementLevelup = new SelectElement(updateLanguageLevel);
            elementLevelup.SelectByText("Native/Bilingual");
           
            // click on Update button
            IWebElement clickonupdateButton = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            clickonupdateButton.Click();
            Thread.Sleep(1000);        
        }
        public string GetEditedLanguage()     // Get edited language
        {
            Thread.Sleep(1000);

            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            return editedLanguage.Text;
        }
        public string GetEditedLanguageLevel() // Get edited language level
        {           
            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[2]"));
            return editedLanguageLevel.Text;
        }
        public void DeleteLanguage() // Delete the last record of existing languages
        {
            // click on Language Delete icon
            IWebElement lanuagedeleteButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            lanuagedeleteButton.Click();
           
            Thread.Sleep(1000);
            // click on Language Delete icon
            IWebElement lanuagedeleteicon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            lanuagedeleteicon.Click();           
        }
        public string GetLanguageDeleteAlertMessage() // Get the alert message 
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div[@class='ns-box-inner']", 5);

            string alertMessageXPath = "//div[@class='ns-box-inner']";
            IWebElement deletedLaguageAlertmessage = driver.FindElement(By.XPath(alertMessageXPath));
            return deletedLaguageAlertmessage.Text;
                       
        }
    }
    }

