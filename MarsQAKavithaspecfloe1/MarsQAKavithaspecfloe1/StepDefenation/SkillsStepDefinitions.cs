using MarsQAspecflow1.PageObjects;
using MarsQAspecflow1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQAspecflow1.StepDefenation
{
    [Binding]
    public class SkillsStepDefinitions : Commondriver
    {
        LoginPage LogingpageObj;
        SkillsPage SkillsPageObj;

        //Constructor
        public SkillsStepDefinitions()
        {
            LogingpageObj = new LoginPage();
            SkillsPageObj = new SkillsPage();
        }
               
        [Given(@"I Loged into Mars portal")]
        public void GivenILogedIntoMarsPortal()
        {
            LogingpageObj.LoginSteps();           
        }

        [When(@"I add my skills on my profile")]
        public void WhenIAddMySkillsOnMyProfile()
        {            
            SkillsPageObj.AddSkill();
        }
        [Then(@"the skills should added successfully")]
        public void ThenTheSkillsShouldAddedSuccessfully()
        {
            // Assert the newly added skill
            string newSkill = SkillsPageObj.GetNewSkill();
            string newSkillLevel = SkillsPageObj.GetNewSkillLevel();
            Assert.That(newSkill == "Java", "Actual record and expected record do not match.");
            Assert.That(newSkillLevel == "Beginner", "Actual record and expected record do not match.");           

        }
        [When(@"I edit my '([^']*)' and '([^']*)'on the existing record")]
        public void WhenIEditMyAndOnTheExistingRecord(string skill, string level)
        {
            SkillsPageObj.EditSkill(skill, level);
         }

        [Then(@"the skills record should edited '([^']*)' and '([^']*)'")]
        public void ThenTheSkillsRecordShouldEditedAnd(string skill, string level)
        {
            // Assert the edited skill
            string editedSkill = SkillsPageObj.GetEditedSkill();
            string editedSkillLevel = SkillsPageObj.GetEditedSkillLevel();
            Assert.That(editedSkill == skill, "Actual record and expected record should match.");
            Assert.That(editedSkillLevel == level, "Actual record and expected record do not match.");
        }
        [When(@"I delete the skill on my profile")]
        public void WhenIDeleteTheSkillOnMyProfile()
        {           
            SkillsPageObj.DeleteSkill();
        }
        [Then(@"the skills should deleted successfully")]
        public void ThenTheSkillsShouldDeletedSuccessfully()
        {
            // Assert deleted skill
            string deletedSkill = SkillsPageObj.GetdeletedSkill();
            Assert.That(deletedSkill != "Intermediate", "Actual record and expected record do not match.");

        }
    }
}
