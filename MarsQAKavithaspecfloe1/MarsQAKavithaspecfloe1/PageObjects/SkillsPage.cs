using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MarsQAspecflow1.Utilities;


namespace MarsQAspecflow1.PageObjects
{
    public class SkillsPage : Commondriver
    {                        
        public void AddSkill() // Add new skill on profile
        {           
            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillAddNewButton.Click();
            Thread.Sleep(1000);

            IWebElement addSkilltextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkilltextBox.Clear();
            addSkilltextBox.SendKeys("Java");
            Thread.Sleep(1000);

            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();

            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            chooseSkillLevel.Click();

            IWebElement skillAddButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddButton.Click();
        }
        public string GetNewSkill() // Get the newly added skill
        {
            Thread.Sleep(1000);
                        
            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkill.Text;
        }
        public string GetNewSkillLevel() // Get the newly added skill level
        {
            Thread.Sleep(1000);

            IWebElement newSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newSkillLevel.Text;
        }
        public void EditSkill(string skill, string level) // Edit an existing Skill record
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement skillEditButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            skillEditButton.Click();

           IWebElement skillTextBox = driver.FindElement(By.Name("name"));
            skillTextBox.Clear();
            skillTextBox.SendKeys(skill);
           
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillLevelDropdown.Click();
            Thread.Sleep(1000);

            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            chooseSkillLevel.Click();

            IWebElement skillUpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            skillUpdateButton.Click();           
        }
        public string GetEditedSkill() // Get edited skill
        {
            Thread.Sleep(1000);

            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editedSkill.Text;
        }
        public string GetEditedSkillLevel()
        {        
            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editedSkillLevel.Text;
        }
        public void DeleteSkill() // Delete a record of skill
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteSkillButton.Click();
        }
        public string GetdeletedSkill() // Get the deleted skill
        {
            Thread.Sleep(1000);

            IWebElement deletedSkill = driver.FindElement(By.XPath("tr/td[3]/span[2]/i"));
            return deletedSkill.Text;
        }
    }
}
