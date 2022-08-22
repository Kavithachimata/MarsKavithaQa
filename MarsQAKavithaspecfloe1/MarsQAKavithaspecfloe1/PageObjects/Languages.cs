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
    public class Languages
    {
        public void LanuagePageSteps(IWebDriver driver)
        {

            //Clickon language
            IWebElement clickOnLanguageButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
            clickOnLanguageButton.Click();
            Thread.Sleep(4000);


            // Adding language/ Clickon Add new
            IWebElement addNewLanuage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewLanuage.Click();
            Thread.Sleep(3000);

            //Input Language Text
            IWebElement languageTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            languageTextbox.SendKeys("Spanish");
            Thread.Sleep(3000);

            //Choose language level from the Dropdown list
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement elementLevel = new SelectElement(chooseLanguageLevel);
            elementLevel.SelectByText("Basic");
            Thread.Sleep(3000);


            // click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
       
            
            // click on  Language Update icon
            IWebElement updateSymbel = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            updateSymbel.Click();
            Thread.Sleep(3000);


            //Input Language Text for update
            IWebElement chooseLevelOfLanguageForupdate = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            chooseLevelOfLanguageForupdate.Click();
            Thread.Sleep(2000);


            //Choose language level from the Dropdown list for update
            IWebElement updateLanguageLevel = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            SelectElement elementLevelup = new SelectElement(updateLanguageLevel);
            elementLevelup.SelectByText("Native/Bilingual");
            Thread.Sleep(3000);


            // click on Update button
            IWebElement clickonupdateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            clickonupdateButton.Click();
            Thread.Sleep(3000);
                        
           
            //Select Language Text for Delete
            IWebElement chooseLanguageFordelete = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            chooseLanguageFordelete.Clear();
            Thread.Sleep(2000);

            // click on Language Delete icon
            IWebElement lanuagedeleteicon = driver.FindElement(By.CssSelector("body"));
            lanuagedeleteicon.Click();
            Thread.Sleep(2000);

        }
        public string LanguageDeleterecord(IWebDriver driver)

        {
            IWebElement GetDeleteLanguageRecord = driver.FindElement(By.XPath("body"));
            return GetDeleteLanguageRecord.Text;



        }



    }
    }

