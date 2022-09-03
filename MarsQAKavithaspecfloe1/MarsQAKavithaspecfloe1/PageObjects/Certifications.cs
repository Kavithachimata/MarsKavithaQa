using MarsQAspecflow1.Utilities;
using OpenQA.Selenium;

namespace MarsQAspecflow1.PageObjects
{
    public class Certifications: Commondriver
    {
        public void CertificationsPageSteps()        {

            // Click on Certification button
            Thread.Sleep(1000);
            IWebElement clickOnCertificationsButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            clickOnCertificationsButton.Click();            

            // Add New Certification button
            IWebElement addNewCertifications = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCertifications.Click();          

            //Input Certificate name
            IWebElement inputCertificateName = driver.FindElement(By.Name("certificationName"));
            inputCertificateName.SendKeys("Degree");
            Thread.Sleep(1000);

            // Input Certificate from
            IWebElement inputCertificateFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            inputCertificateFrom.SendKeys("Andhra University");          

            // Input Certificate year
           IWebElement clickCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            IWebElement selectCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[14]"));
            selectCertYear.Click();
            Thread.Sleep(1000);

            // click on Add Certfications button
            IWebElement addQualificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addQualificationButton.Click();               
          
        }
        public string GetNewCertification() // Get newly added certification
        {
            Thread.Sleep(2000);
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 10);
            IWebElement newCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return newCertification.Text;
        }
        public string GetNewCertificationFrom() // Get newly added certification from 
        {            
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 10);
            IWebElement newCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return newCertificationFrom.Text;
        }
        public string GetNewCertificationYear() // // Get newly added year of certification 
        {
            Thread.Sleep(1000);

            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]", 40);
            IWebElement newCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return newCertificationYear.Text;
        }
        public void EditCertification() // Edit an existing certification on profile
        {
            WaitHelpers.WaiToBeExistent(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            //click on Certfications Button
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();            

            // click on Certfications Edit icon
            IWebElement certiEditIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            certiEditIcon.Click();
            Thread.Sleep(1000);

            // input Certfications Edit 
            IWebElement editcertificationTextBox = driver.FindElement(By.Name("certificationName"));
            editcertificationTextBox.Clear();
            editcertificationTextBox.SendKeys("Diploma");
            Thread.Sleep(1000);

            // input Certfications Edit 
            IWebElement CertificationFromTextBox = driver.FindElement(By.Name("certificationFrom"));
            CertificationFromTextBox.Clear();
            CertificationFromTextBox.SendKeys("Nagarjuna University");

            // Edit Certification year
            IWebElement editclickCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
            Thread.Sleep(1000);
            IWebElement editselectCertYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[12]"));
            editselectCertYear.Click();
            Thread.Sleep(1000);

            // click on Certfications Update button
            IWebElement clickonupdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            clickonupdateButton.Click();
        }     
        public string GetEditedCertification() // Get newly edited certification
        {
            Thread.Sleep(1000);
            IWebElement editedCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return editedCertification.Text;
        }
        public string GetEditedCertificationFrom() // Get newly edited certification from
        {
            Thread.Sleep(1000);
            IWebElement editedCertificationFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return editedCertificationFrom.Text;
        }
        public string GetEditedCertificationYear() // Get newly edited year of certification
        {
            Thread.Sleep(1000);
            IWebElement editedCertificationYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return editedCertificationYear.Text;
        }
        public void DeleteCertification()  // Delete a record of certification
        {
            // click on  Certfications button
            Thread.Sleep(2000);
            IWebElement certificationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();
            Thread.Sleep(1000);

            // click on  Certfications Delete icon
            IWebElement certiDeleteIcon = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            certiDeleteIcon.Click();
            Thread.Sleep(1000);
        }
        public string GetCertificationDeleteAlertMessage(IWebDriver driver) // Get the alert message
       {
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
                string alertMessageXPath = "//div[@class='ns-box-inner']";
                IWebElement certificationDeleteAlertmMssage = driver.FindElement(By.XPath(alertMessageXPath));
                return certificationDeleteAlertmMssage.Text;


            }

        
        }
    }

