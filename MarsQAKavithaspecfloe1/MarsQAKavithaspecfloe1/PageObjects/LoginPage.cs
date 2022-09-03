using MarsQAspecflow1.Utilities;
using OpenQA.Selenium;

namespace MarsQAspecflow1.PageObjects
{
    public class LoginPage : Commondriver
    {
        public void LoginSteps()
        {
            //Open Chrome Browser

            // Lauch Mars Portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            Thread.Sleep(1000);

            // Identified signin button and click on sign in button
            IWebElement signinButton = driver.FindElement(By.XPath("//div/div/div[1]/div/a"));
            signinButton.Click();

            Thread.Sleep(1000);
            // Identified email address textbox and enter valid username
            IWebElement emailAddressTextbox = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddressTextbox.SendKeys("kavitha.chimata@gmail.com");

            //Identified password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]"));
            passwordTextbox.SendKeys("ganapathirao");
            Thread.Sleep(1000);

            //Identfy login button and clickon it
            IWebElement loginButton = driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]"));
            loginButton.Click();
            Thread.Sleep(1000);

            // Check if the user has logged in successfully
            IWebElement marsLogo = driver.FindElement(By.XPath("//div/div[1]/a"));
            Thread.Sleep(4000);
        }
        public string GetMarsLogo()   // Get the Marlogo
        {
            Thread.Sleep(1000);

            IWebElement GetMarsLogo = driver.FindElement(By.XPath("//div/div[1]/a"));
            return GetMarsLogo.Text;

        }
        }
}
