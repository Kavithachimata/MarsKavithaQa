using FluentAssertions;
using MarsQAspecflow1.PageObjects;
using MarsQAspecflow1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQAspecflow1.StepDefenation
{
    [Binding]
    public class MarsSpecflowBDDStepDefinitions : Commondriver
    {
        
        [Given(@"with valid credentials like user name and Password")]
        public void GivenWithValidCredentialsLikeUserNameAndPassword()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I enter the valid valid credentials")]
        public void WhenIEnterTheValidValidCredentials()
        {
            ProfilePage1 ProfilePage1Obj = new ProfilePage1();
            ProfilePage1Obj.ProfilepageSteps(driver);


        }

        [Then(@"i should be able to see Mars portal with Mars Logo")]
        public void ThenIShouldBeAbleToSeeMarsPortalWithMarsLogo()
        {
            ProfilePage1 ProfilePage1Obj = new ProfilePage1();
           
        }

        [Given(@"Logged in to Mars portal and navigate decription box")]
        public void GivenLoggedInToMarsPortalAndNavigateDecriptionBox()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);

        }

        [When(@"I enter my description and availbility")]
        public void WhenIEnterMyDescriptionAndAvailbility()
        {
            ProfilePage1 ProfilePage1Obj = new ProfilePage1();
            ProfilePage1Obj.ProfilepageSteps(driver);


        }

        [Then(@"i should be able to see my added description and availbility")]
        public void ThenIShouldBeAbleToSeeMyAddedDescriptionAndAvailbility()
        {

            ProfilePage1 ProfilePage1Obj = new ProfilePage1();
            


        }

        [Given(@"Logged in to Mars portal and navigate Languages button")]
        public void GivenLoggedInToMarsPortalAndNavigateLanguagesButton()
        {

            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);

        }
        [When(@"I enter my languages")]
        public void WhenIEnterMyLanguages()
        {
            Languages LanguagesPageObj = new Languages();
            LanguagesPageObj.LanuagePageSteps(driver);


        }

        [Then(@"i should be able to see my added languages with levels")]
        public void ThenIShouldBeAbleToSeeMyAddedLanguagesWithLevels()
        {

            Languages LanguagesPageObj = new Languages();
            


        }

        [Given(@"Logged in to Mars portal and navigate to Languages Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToLanguagesEditIcon()
        {

            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I edit my languages")]
        public void WhenIEditMyLanguages()
        {
            Languages LanguagesPageObj = new Languages();
            LanguagesPageObj.LanuagePageSteps(driver);


        }

        [Then(@"i should be able to see my edit languages record with levels")]
        public void ThenIShouldBeAbleToSeeMyEditLanguagesRecordWithLevels()
        {
            Languages LanguagesPageObj = new Languages();
            


        }

        [Given(@"Logged in to Mars portal and navigate Languages delete icon")]
        public void GivenLoggedInToMarsPortalAndNavigateLanguagesDeleteIcon()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I choose language for delete")]
        public void WhenIChooseLanguageForDelete()
        {
            Languages LanguagesPageObj = new Languages();
            LanguagesPageObj.LanuagePageSteps(driver);

        }

        [Then(@"Languages record should be deleted successfully")]
        public void ThenLanguagesRecordShouldBeDeletedSuccessfully()
        {
            Languages LanguagesPageObj = new Languages();
            string GetlanguageRecord = LanguagesPageObj.LanguageDeleterecord(driver);
            Assert.That(GetlanguageRecord == "Language recoord should be deleted");

        }

        [Given(@"I Logged in to Mars portal and navigate Education button")]
        public void GivenILoggedInToMarsPortalAndNavigateEducationButton()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);


        }

        [When(@"I enter my education details")]
        public void WhenIEnterMyEducationDetails()
        {
            Education EducationPageObj = new Education();
            EducationPageObj.educationepageSteps(driver);
        }

        [Then(@"i should be able to see my added education details")]
        public void ThenIShouldBeAbleToSeeMyAddedEducationDetails()
        {
            Education EducationPageObj = new Education();
           

        }

        [Given(@"Logged in to Mars portal and navigate to education Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToEducationEditIcon()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I edit my education record")]
        public void WhenIEditMyEducationRecord()
        {
            Education EducationPageObj = new Education();
            EducationPageObj.educationepageSteps(driver);
        }

        [Then(@"i should be able to see my edit education record")]
        public void ThenIShouldBeAbleToSeeMyEditEducationRecord()
        {
            Education EducationPageObj = new Education();
           

        }

        [Given(@"Logged in to Mars portal and navigate education delete icon")]
        public void GivenLoggedInToMarsPortalAndNavigateEducationDeleteIcon()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I choose education record for delete")]
        public void WhenIChooseEducationRecordForDelete()
        {
            Education EducationPageObj = new Education();
            EducationPageObj.educationepageSteps(driver);
        }

        [Then(@"Education record should be deleted successfully")]
        public void ThenEducationRecordShouldBeDeletedSuccessfully()
        {

            Education EducationPageObj = new Education();
            
            string GetdeleteEducationRecord = EducationPageObj.DeleteEduRecord(driver);
            Assert.That(GetdeleteEducationRecord == "Education recoord should be Deleted successfully");

        }

        [Given(@"I Logged in to Mars portal and navigate certifications button")]
        public void GivenILoggedInToMarsPortalAndNavigateCertificationsButton()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);

        }

        [When(@"I enter my certifications details")]
        public void WhenIEnterMyCertificationsDetails()
        {
            Certifications CertificationsPageObj = new Certifications();
            CertificationsPageObj.CertificationsPageSteps(driver);
        }

        [Then(@"i should be able to see my added certifications details")]
        public void ThenIShouldBeAbleToSeeMyAddedCertificationsDetails()
        {
            Certifications CertificationsPageObj = new Certifications();
           
        }

        [Given(@"Logged in to Mars portal and navigate to certifications Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToCertificationsEditIcon()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I edit my certifications record")]
        public void WhenIEditMyCertificationsRecord()
        {
            Certifications CertificationsPageObj = new Certifications();
            CertificationsPageObj.CertificationsPageSteps(driver);
        }

        [Then(@"i should be able to see my edit certifications record")]
        public void ThenIShouldBeAbleToSeeMyEditCertificationsRecord()
        {
            Certifications CertificationsPageObj = new Certifications();
            
        }

        [Given(@"I Logged in to Mars portal and navigate certifications delete icon")]
        public void GivenILoggedInToMarsPortalAndNavigateCertificationsDeleteIcon()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);
        }

        [When(@"I choose certifications record for delete")]
        public void WhenIChooseCertificationsRecordForDelete()
        {

            Certifications CertificationsPageObj = new Certifications();
            CertificationsPageObj.CertificationsPageSteps(driver);

        }

        [Then(@"Certifications record should be deleted successfully")]
        public void ThenCertificationsRecordShouldBeDeletedSuccessfully()
        {
            Certifications CertificationsPageObj = new Certifications();
            string GetDeletecertificationsRecord = CertificationsPageObj.DeleteCertficationRecord(driver);
            Assert.That(GetDeletecertificationsRecord == "Certification recoord should be deleted successfully");


        }
    }
}