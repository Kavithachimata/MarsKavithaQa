using MarsQAspecflow1.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V103.Profiler;

namespace MarsQAspecflow1.Utilities
   
    {
    public class Commondriver

    {
        public static IWebDriver driver;


        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();


            loginPageObj.LoginSteps(driver);
        }

        public void close()
        {
            driver.Quit(); 
            
         }

        }
    
      }



        

    






