Feature: MarsSpecflowBDD

As a mars Portal sellerI would like Add My profile details like 
my availbility, description, languages and my edcation and certifications
so that people who seeking some skills can see my detaills  

@tag1
Scenario:1) Login to Mars portal
	Given with valid credentials like user name and Password
	When I enter the valid valid credentials
	Then i should be able to see Mars portal with Mars Logo

	Scenario:2) Add description summery and my availbilty to profile page
	Given Logged in to Mars portal and navigate decription box
	When I enter my description and availbility
	Then i should be able to see my added description and availbility

	
	Scenario:3) Add languaages to my profile page
	Given Logged in to Mars portal and navigate Languages button
	When I enter my languages
	Then i should be able to see my added languages with levels

	Scenario:4) Edit languaages in my profile page
	Given Logged in to Mars portal and navigate to Languages Edit icon
	When I edit my languages
	Then i should be able to see my edit languages record with levels

	Scenario:5) Delete languaage record in my profile page
	Given Logged in to Mars portal and navigate Languages delete icon
	When I choose language for delete
	Then Languages record should be deleted successfully

	Scenario:6) Add education to my profile page
	Given I Logged in to Mars portal and navigate Education button
	When I enter my education details
	Then i should be able to see my added education details

	Scenario:7) Edit education record in my profile page
	Given Logged in to Mars portal and navigate to education Edit icon
	When I edit my education record
	Then i should be able to see my edit education record 

	Scenario:8) Delete education record in my profile page
	Given Logged in to Mars portal and navigate education delete icon
	When I choose education record for delete
	Then Education record should be deleted successfully

	Scenario:9) Add certifications to my profile page
	Given I Logged in to Mars portal and navigate certifications button
	When I enter my certifications details
	Then i should be able to see my added certifications details

	Scenario:10) Edit certifications record in my profile page
	Given I Logged in to Mars portal and navigate certifications button
	When I edit my certifications record
	Then i should be able to see my edit certifications record 

	Scenario:11) Delete certifications record in my profile page
	Given I Logged in to Mars portal and navigate certifications button
	When I choose certifications record for delete
	Then Certifications record should be deleted successfully