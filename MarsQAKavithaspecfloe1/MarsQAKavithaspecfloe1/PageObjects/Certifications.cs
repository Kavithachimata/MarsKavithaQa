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
    internal class Certifications
    {
        public void CertificationsPageSteps(IWebDriver driver)
        {

            // Click on Certification button
            IWebElement clickOnCertificationsButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[4]"));
            clickOnCertificationsButton.Click();
            Thread.Sleep(4000);

            // Add New Certification button
            IWebElement addNewCertifications = driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
            addNewCertifications.Click();
            Thread.Sleep(4000);

            //Input Certificate name
            IWebElement inputCertificateName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            inputCertificateName.SendKeys("Jira7");
            Thread.Sleep(4000);

            // Input Certificate from
            IWebElement inputCertificateFrom = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/input[1]"));
            inputCertificateFrom.SendKeys("SCRUM Study");
            Thread.Sleep(3000);

            // Input Certificate year
            IWebElement clickCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            Thread.Sleep(1000);
            IWebElement selectCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']/child::option[9]"));
            selectCertYear.Click();
            Thread.Sleep(1000);

            // click on Add Certfications button
            IWebElement addQualificationButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            addQualificationButton.Click();
            Thread.Sleep(6000);
                   
                      

            // click on Certfications Edit icon
            IWebElement certiUpdateIcon = driver.FindElement(By.XPath("//tbody/tr[1]/td[4]/span[1]/i[1]"));
            certiUpdateIcon.Click();
            Thread.Sleep(3000);

            IWebElement editclickCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            Thread.Sleep(1000);
            IWebElement editselectCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']/child::option[6]"));
            selectCertYear.Click();
            Thread.Sleep(1000);

            // click on Certfications Update button
            IWebElement clickonupdateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            clickonupdateButton.Click();
            Thread.Sleep(3000);
                         
              
            //SelectCertfications Text for Delete
            IWebElement choosecertificateFordelete = driver.FindElement(By.XPath("[contains(text(),'Jira7')]"));
            choosecertificateFordelete.Click();
            Thread.Sleep(8000);

            // click on  Certfications Delete icon
            IWebElement certiDeleteIcon = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
            certiDeleteIcon.Click();
            Thread.Sleep(3000);

        }
        public string DeleteCertficationRecord(IWebDriver driver)

        {
            IWebElement GetDeletecertificationsRecord = driver.FindElement(By.XPath("contains(text(),'Jira7')]"));
            return GetDeletecertificationsRecord.Text;

        }
    }
}
