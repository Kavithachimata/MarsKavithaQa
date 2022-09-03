using MarsQAspecflow1.PageObjects;
using MarsQAspecflow1.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;
using MarsQAspecflow1.Hooks;

namespace MarsQAspecflow1.StepDefenation
{
    [Binding]
    public class MarsSpecflowBDDStepDefinitions : Commondriver

    {
        LoginPage LogingpageObj;
        ProfilePage1 ProfilePage1Obj;
        Education EducationPageObj;
        readonly Certifications CertificationsPageObj;
        Languages LanguagesPageObj;

        //Constructor
        public MarsSpecflowBDDStepDefinitions()
        {
            LogingpageObj = new LoginPage();
            ProfilePage1Obj  = new ProfilePage1();
            EducationPageObj = new Education();
            CertificationsPageObj = new Certifications ();
            LanguagesPageObj  = new Languages();           

        }
        [Given(@"with valid credentials like user name and Password")]
        public void GivenWithValidCredentialsLikeUserNameAndPassword()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I enter the valid valid credentials")]
        public void WhenIEnterTheValidValidCredentials()
        {
            
        }

        [Then(@"i should be able to see Mars portal with Mars Logo")]
        public void ThenIShouldBeAbleToSeeMarsPortalWithMarsLogo()
        {
            string GetMarsLogo = LogingpageObj.GetMarsLogo();
            Assert.That(GetMarsLogo == "MarsLogo", "Actual record and expected record do not match.");
        }

        [Given(@"Logged in to Mars portal and navigate decription box")]
        public void GivenLoggedInToMarsPortalAndNavigateDecriptionBox()
        {
            LogingpageObj.LoginSteps();            
        }

        [When(@"I enter my description and availbility")]
        public void WhenIEnterMyDescriptionAndAvailbility()
        {
            ProfilePage1Obj.ProfilepageSteps();
        }

        [Then(@"i should be able to see my added description and availbility")]
        public void ThenIShouldBeAbleToSeeMyAddedDescriptionAndAvailbility()
        {
            // Assert the pop-up alart message for description
            string newDescriptionAlertmMssage = ProfilePage1Obj.GetNewDescriptionAlertMessage();
            Assert.That(newDescriptionAlertmMssage == "Description has been saved successfully", "Description has not been added.");

            // Assert the pop-up alart message for avaibility       
            string newAvailablityAlertmMssage = ProfilePage1Obj.GetNewAvailabilityAlertMessage();
            Assert.That(newAvailablityAlertmMssage == "Availability updated", "Experted alert message and actual message do not match.");
        }

        [Given(@"Logged in to Mars portal and navigate Languages button")]
        public void GivenLoggedInToMarsPortalAndNavigateLanguagesButton()
        {
            LogingpageObj.LoginSteps();
        }
        [When(@"I enter my languages")]
        public void WhenIEnterMyLanguages()
        {            
            LanguagesPageObj.LanuagePageSteps();
        }

        [Then(@"i should be able to see my added languages with levels")]
        public void ThenIShouldBeAbleToSeeMyAddedLanguagesWithLevels()
        {           
            // Assert the the newly added language and language level
            string newLanguage = LanguagesPageObj.GetNewLanguage();
            string newLanguageLevel = LanguagesPageObj.GetNewLanguageLevel();
            Assert.That(newLanguage == "Spanish3", "Actual record and expected record do not match.");
            Assert.That(newLanguageLevel == "Basic", "Actual record and expected record do not match.");
                        
        }

        [Given(@"Logged in to Mars portal and navigate to Languages Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToLanguagesEditIcon()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I edit my languages")]
        public void WhenIEditMyLanguages()
        {           
            LanguagesPageObj.EditLanguage();
        }

        [Then(@"i should be able to see my edit languages record with levels")]
        public void ThenIShouldBeAbleToSeeMyEditLanguagesRecordWithLevels()
        {           
            // Assert the edited languages and levels
            string editedLanguage = LanguagesPageObj.GetEditedLanguage();
            string editedLanguageLevel = LanguagesPageObj.GetEditedLanguageLevel();
            Assert.That(editedLanguage == "Latin", "Actual record and expected record do not match.");
            Assert.That(editedLanguageLevel == "Native/Bilingual",  "Actual record and expected record do not match.");
        }

        [Given(@"Logged in to Mars portal and navigate Languages delete icon")]
        public void GivenLoggedInToMarsPortalAndNavigateLanguagesDeleteIcon()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I choose language for delete")]
        public void WhenIChooseLanguageForDelete()
        {           
            LanguagesPageObj.DeleteLanguage();
        }
        [Then(@"Languages record should be deleted successfully")]
        public void ThenLanguagesRecordShouldBeDeletedSuccessfully()
        {
            // Assert the alert message to confirm the deletion
            string deletedLaguageAlertmessage = LanguagesPageObj.GetLanguageDeleteAlertMessage();
            Assert.That(deletedLaguageAlertmessage == "Latin has been deleted from your languages", "Expected pop up message is not detected.");
            //// Assert the last record of language
            //string deletedLanguage = LanguagesPageObj.GetdeletedLanugage(driver);
            //Assert.That(deletedLanguage != "Latin", "Expected language record has not been deleted successfully.");
        }
        [Given(@"I Logged in to Mars portal and navigate Education button")]
        public void GivenILoggedInToMarsPortalAndNavigateEducationButton()
        {
            LogingpageObj.LoginSteps();
        }
        [When(@"I enter my education details")]
        public void WhenIEnterMyEducationDetails()
        {           
            EducationPageObj.educationepageSteps();
        }
        [Then(@"i should be able to see my added education details")]
        public void ThenIShouldBeAbleToSeeMyAddedEducationDetails()
        {          
            // Assert the the newly added education
            string newUniversity = EducationPageObj.GetUniversityName();
            string newCountryOfUniversity = EducationPageObj.GetNewCountryOfUniversity();
            string newTitle = EducationPageObj.GetNewTitle();
            string newDegree = EducationPageObj.GetNewDegree();
            string newYearOfGraducation = EducationPageObj.GetNewYearOfGraducation();
            Assert.That(newUniversity == "Krishna Collage", "Actual record and expected record should be match.");
            Assert.That(newCountryOfUniversity == "India", "Actual record and expected record should be match.");
            Assert.That(newTitle == "M.Tech", "Actual record and expected record should be match.");
            Assert.That(newDegree == "Degree", "Actual record and expected record should be match.");
            Assert.That(newYearOfGraducation == "2005", "Actual record and expected record should match.");

        }
        [Given(@"Logged in to Mars portal and navigate to education Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToEducationEditIcon()
        {
            LogingpageObj.LoginSteps();
        }
        [When(@"I edit my education record")]
        public void WhenIEditMyEducationRecord()
        {
            EducationPageObj.EditEducation();
        }
        [Then(@"i should be able to see my edit education record")]
        public void ThenIShouldBeAbleToSeeMyEditEducationRecord()
        {           
            // Assert the newly edited education
            string editedUniversity = EducationPageObj.GetEditedUniversity();
            string editedCountryOfUniversity = EducationPageObj.GetEditedCountryOfUniversity();
            string editedTitle = EducationPageObj.GetEditedTitle();
            string editedDegree = EducationPageObj.GetEditedDegree();
            string editedYearOfGraducation = EducationPageObj.GetEditedYearOfGraducation();
            Assert.That(editedCountryOfUniversity == "Malaysia", "Actual record and expected record do not match.");
            Assert.That(editedUniversity == "Sri University", "Actual record and expected record do not match.");
            Assert.That(editedTitle == "PHD", "Actual record and expected record do not match.");
            Assert.That(editedDegree == "Degree", "Actual record and expected record do not match.");
            Assert.That(editedYearOfGraducation == "2008", "Actual record and expected record do not match.");

        }

        [Given(@"Logged in to Mars portal and navigate education delete icon")]
        public void GivenLoggedInToMarsPortalAndNavigateEducationDeleteIcon()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I choose education record for delete")]
        public void WhenIChooseEducationRecordForDelete()
        {
            EducationPageObj.DeleteEducation();
        }

        [Then(@"Education record should be deleted successfully")]
        public void ThenEducationRecordShouldBeDeletedSuccessfully()

        {
            // Assert the alart message to confirm the new education has been deleted
            string deletedEducationAlertmMssage = EducationPageObj.GetEducationDeleteAlertMessage();
            Assert.That(deletedEducationAlertmMssage == "Education entry successfully removed", "Expected pop up message is not matched.");
           
        }

        [Given(@"I Logged in to Mars portal and navigate certifications button")]
        public void GivenILoggedInToMarsPortalAndNavigateCertificationsButton()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I enter my certifications details")]
        public void WhenIEnterMyCertificationsDetails()
        {
             CertificationsPageObj.CertificationsPageSteps();
        }

        [Then(@"i should be able to see my added certifications details")]
        public void ThenIShouldBeAbleToSeeMyAddedCertificationsDetails()
        {     

            // Assert the newly added certfication details on profile            
            string newCertification = CertificationsPageObj.GetNewCertification();
            string newCertificationFrom = CertificationsPageObj.GetNewCertificationFrom();
            string newCertificationYear = CertificationsPageObj.GetNewCertificationYear();
            Assert.That(newCertification == "Degree", "Description has not been added.");
            Assert.That(newCertificationFrom == "Andhra University", "Description has not been added.");
            Assert.That(newCertificationYear == "2010", "Description has not been added.");
        }

        [Given(@"Logged in to Mars portal and navigate to certifications Edit icon")]
        public void GivenLoggedInToMarsPortalAndNavigateToCertificationsEditIcon()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I edit my certifications record")]
        public void WhenIEditMyCertificationsRecord()
        {
            CertificationsPageObj.EditCertification();
        }

        [Then(@"i should be able to see my edit certifications record")]
        public void ThenIShouldBeAbleToSeeMyEditCertificationsRecord()
        {
            // Assert the edited certification details on profile            
            string editedCertification = CertificationsPageObj.GetEditedCertification();
            string editedCertificationFrom = CertificationsPageObj.GetEditedCertificationFrom();
            string editedCertificationYear = CertificationsPageObj.GetEditedCertificationYear();
            Assert.That(editedCertification == "Diploma", "Actual record and expected record do not match.");
            Assert.That(editedCertificationFrom == "Nagarjuna University", "Actual record and expected record do not match.");
            Assert.That(editedCertificationYear == "2012", "Actual record and expected record do not match.");                        
        }
        [Given(@"I Logged in to Mars portal and navigate certifications delete icon")]
        public void GivenILoggedInToMarsPortalAndNavigateCertificationsDeleteIcon()
        {
            LogingpageObj.LoginSteps();
        }

        [When(@"I choose certifications record for delete")]
        public void WhenIChooseCertificationsRecordForDelete()
        {           
            CertificationsPageObj.DeleteCertification();
        }

        [Then(@"Certifications record should be deleted successfully")]
        public void ThenCertificationsRecordShouldBeDeletedSuccessfully()
        {
            // Assert the alart message to confirm the certification has been deleted
            string certificationDeleteAlertmMssage = CertificationsPageObj.GetCertificationDeleteAlertMessage(driver);
            Assert.That(certificationDeleteAlertmMssage == "Certificate has been deleted from your certification", "Expected pop up message is not matched.");
                       

        }
    }
}