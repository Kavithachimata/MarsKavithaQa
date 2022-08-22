using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAspecflow1.PageObjects
{
    public class LoginPage
    {

        public void LoginSteps(IWebDriver driver)
        {

            //Open Chrome Browser

            driver.Manage().Window.Maximize();

            // Lauch Mars Portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            // Identified signin button and click on sign in button
            IWebElement signinButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]"));
            signinButton.Click();
            Thread.Sleep(3000);


            // Identified email address textbox and enter valid username
            IWebElement emailAddressTextbox = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            emailAddressTextbox.SendKeys("kavitha.chimata@gmail.com");
            Thread.Sleep(4000);


            //Identified password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]"));
            passwordTextbox.SendKeys("ganapathirao");
            Thread.Sleep(4000);


            //Identfy login button and clickon it
            IWebElement loginButton = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]"));
            loginButton.Click();
            Thread.Sleep(4000);
        }
        public string LanguageDeleterecord(IWebDriver driver)

        {
            IWebElement GetDeleteLanguageRecord = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
            return GetDeleteLanguageRecord.Text;





        }
    }
}
