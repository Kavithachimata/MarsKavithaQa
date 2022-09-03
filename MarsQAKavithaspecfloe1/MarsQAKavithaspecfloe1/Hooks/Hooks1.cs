using MarsQAspecflow1.Utilities;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsQAspecflow1.Hooks
{
    [Binding]    
        
        public sealed class Hooks1 : Commondriver
        {
            [BeforeScenario]
            public void BeforeScenario()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }

            [AfterScenario]
            public void AfterScenario()
            {
                driver.Quit();
            }
        }
    }