
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



//Open Chrome Browser
IWebDriver driver = new ChromeDriver();
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

// Check if the user has logged in successfully
IWebElement marsLogo = driver.FindElement(By.CssSelector("body:nth-child(2) div.ui:nth-child(1) div:nth-child(1) div.ui.secondary.menu:nth-child(1) > a.item"));
Thread.Sleep(4000);


if (marsLogo.Text == "Mars Logo")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}


Thread.Sleep(4000);

// click on Dexcription button
IWebElement descriptionIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
descriptionIcon.Click();
Thread.Sleep(4000);


//Adding description summery in description field
Thread.Sleep(3000);
IWebElement descriptionTextbox = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]"));
descriptionTextbox.SendKeys("Selenium, C#, Spec flow");

// click on description save button
IWebElement descriptionsaveButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
descriptionsaveButton.Click();
Thread.Sleep(3000);


//Adding availblity/ click on availbilty icom
IWebElement availbityIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]"));
availbityIcon.Click();
Thread.Sleep(3000);

// Adding availbility
IWebElement addAvailbilitySelecttype = driver.FindElement(By.Name("availabiltyType"));
SelectElement element = new SelectElement(addAvailbilitySelecttype);
element.SelectByText("Full Time");
Thread.Sleep(3000);

//Adding availble hours/ click on hours icom
IWebElement availbleHoursIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/i[1]"));
availbleHoursIcon.Click();
Thread.Sleep(3000);

// Adding hours inprofilepage
IWebElement availbleHours = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]/select[1]"));
SelectElement elementHours = new SelectElement(availbleHours);
elementHours.SelectByValue("1");
Thread.Sleep(3000);

//Click on earn target 
IWebElement earnTargetIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/i[1]"));
earnTargetIcon.Click();
Thread.Sleep(2000);

/* Adding income target
IWebElement addingIncomeTarget = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/span[1]/select[1]"));
SelectElement elementincome = new SelectElement(addingIncomeTarget);
elementHours.SelectByValue("2");
Thread.Sleep(3000);*/

//Clickon language
IWebElement clickOnLanguageButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
clickOnLanguageButton.Click();
Thread.Sleep(4000);


// Adding language/ Clickon Add new
IWebElement addNewLanuage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
addNewLanuage.Click();
Thread.Sleep(3000);

//Input Language Text
IWebElement languageTextbox = driver.FindElement(By.XPath(".//*[@name='name']"));
languageTextbox.SendKeys("Tamil");
Thread.Sleep(3000);

//Choose language level from the Dropdown list
IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
SelectElement elementLevel = new SelectElement(chooseLanguageLevel);
elementLevel.SelectByText("Native/Bilingual");
Thread.Sleep(3000);


// click on add button
IWebElement addButton = driver.FindElement(By.XPath(".//*[@name='name']"));
addButton.Click();
Thread.Sleep(3000);

// click on  Language Update icon
IWebElement updateSymbel = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
updateSymbel.Click();
Thread.Sleep(3000);


//Input Language Text for update
IWebElement chooseLevelOfLanguageForupdate = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
chooseLevelOfLanguageForupdate.Click();
Thread.Sleep(2000);


//Choose language level from the Dropdown list for update
IWebElement updateLanguageLevel = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]"));
SelectElement elementLevelup = new SelectElement(updateLanguageLevel);
elementLevelup.SelectByText("Native/Bilingual");
Thread.Sleep(3000);


// click on Update button
IWebElement clickonupdateButton = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
clickonupdateButton.Click();
Thread.Sleep(3000);

       
    //Select Language Text for Delete
    IWebElement chooseLanguageFordelete = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
    chooseLanguageFordelete.Click();
    Thread.Sleep(2000);

    // click on Language Delete icon
    IWebElement lanuagedeleteicon = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
    lanuagedeleteicon.Click();
    Thread.Sleep(3000);

  
    //Skills button
    //IWebElement clickOnSkillsButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
    //clickOnSkillsButton.Click();
    //Thread.Sleep(2000);

    // Add New Skills
    //IWebElement addNewSkills = driver.FindElement(By.XPath(".//*[@class='right aligned']"));
    //addNewSkills.Click();
    //Thread.Sleep(5000);

    //Input skill Text
    //IWebElement skillsTextboxInput = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
    //skillsTextboxInput.Click();
    //skillsTextboxInput.SendKeys("Docker");
    //Thread.Sleep(3000);

    //Choose skill level from the Dropdown list
    //IWebElement chooseSkillLevelfromdropdown = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
    //SelectElement elementskill = new SelectElement(chooseSkillLevelfromdropdown);
    //elementskill.SelectByText("Intermediate");
    //Thread.Sleep(3000);

    // click on add skills button
    //IWebElement addSkillButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
    //addSkillButton.Click();
    //Thread.Sleep(3000);

    // click on skill Update button
    //IWebElement skillUpdateSymbel = driver.FindElement(By.TagName("i"));
    //skillUpdateSymbel.Click();
    //Thread.Sleep(3000);


    // Choose skill for update
    //IWebElement skillForUpdate = driver.FindElement(By.XPath(".//*[@value='Github']"));
    //skillForUpdate.Click();
    //Thread.Sleep(2000);

    // Choose skilllevel for update from dropdown
    //IWebElement skillLevelfromdropdown = driver.FindElement(By.XPath(".//*[@xpath='1']"));
    //SelectElement _ = new SelectElement(chooseSkillLevelfromdropdown);
    //element.SelectByText("Beginner");
    //Thread.Sleep(2000);

    // click on skill Update button
    //IWebElement skillUpdateButton = driver.FindElement(By.XPath(".//*[@value='Update']"));
    //skillUpdateButton.Click();
    //Thread.Sleep(3000);/*


    // Education button
    //IWebElement clickOnEducationButton = driver.FindElement(By.XPath(".//*[@class='item active']"));
    IWebElement clickOnEducationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
clickOnEducationButton.Click();
Thread.Sleep(5000);

// Add New Education button
IWebElement addNeweducationButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
addNeweducationButton.Click();
Thread.Sleep(5000);

//Input University or collage name
IWebElement collageOrUniversityName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
collageOrUniversityName.SendKeys("Narayana collage");
Thread.Sleep(5000);


// Select country from the Dropdown list
IWebElement selectCountry = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
SelectElement elementcountry = new SelectElement(selectCountry);
elementcountry.SelectByValue("India");
Thread.Sleep(3000);


// Add title
WebElement selecttitle = (WebElement)driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
SelectElement elementtitle = new SelectElement(selecttitle);
elementtitle.SelectByValue("M.Tech");
Thread.Sleep(4000);

// Qualification degree textbox
IWebElement addtitleAchived = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
addtitleAchived.SendKeys("Degree");
Thread.Sleep(3000);

// Passedout year
WebElement passedoutYear = (WebElement)driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
SelectElement elementpassedout = new SelectElement(passedoutYear);
elementpassedout.SelectByValue("2010");
Thread.Sleep(4000);

// click on Add qualification button
IWebElement addEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
addEducation.Click();
Thread.Sleep(4000);

// click on qualification edit icon
IWebElement EducationEditIcon = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
EducationEditIcon.Click();
Thread.Sleep(4000);


//Edit Degree name
IWebElement editDegreeName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
editDegreeName.SendKeys("Bachelors");
Thread.Sleep(4000);

// click on Edit qualification button
IWebElement editEducationDegree = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]"));
editEducationDegree.Click();
Thread.Sleep(4000);


// Delete qualification record
IWebElement deleteQualification = driver.FindElement(By.XPath("//td[contains(text(),'Chaitanya')]"));
deleteQualification.Click();
Thread.Sleep(4000);


// Click on qualification Delete icon 
IWebElement educationDeleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[6]/span[2]"));
educationDeleteIcon.Click();
Thread.Sleep(6000);


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

// Certification year
//IWebElement certificationYear = driver.FindElement(By.XPath("//select[@name='certificationYear']/child::option[9]"));
//SelectElement elementyrar = new SelectElement(certificationYear);
//elementyrar.SelectByValue("2021");
//Thread.Sleep(4000);

IWebElement clickCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
Thread.Sleep(1000);
IWebElement selectCertYear = driver.FindElement(By.XPath("//select[@name='certificationYear']/child::option[9]"));
selectCertYear.Click();
Thread.Sleep(1000);

// click on Add qualification button
IWebElement addQualificationButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
addQualificationButton.Click();
Thread.Sleep(4000);

//Update on Certifications
IWebElement upadateOnCertificationsIconIcon = driver.FindElement(By.XPath(".//*[@value='Jira']"));
upadateOnCertificationsIconIcon.Click();
Thread.Sleep(3000);

// Update Certificates input
IWebElement updateCetificateInput = driver.FindElement(By.Name(".//*[@name='certificationFrom']"));
updateCetificateInput.SendKeys("Jira5");
Thread.Sleep(4000);


// click on Upadate Certification button
IWebElement UpdateCertificationButton = driver.FindElement(By.XPath(".//*[@value='Update']"));
UpdateCertificationButton.Click();
Thread.Sleep(3000);



