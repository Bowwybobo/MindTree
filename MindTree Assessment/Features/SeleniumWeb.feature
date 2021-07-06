Feature: SeleniumWeb
	Navigate to Selenium


Scenario: Navigate to the download page
	Given I Navigate to "https://www.selenium.dev/"
	And I Click on download
	Then I Should see the download page




Scenario: Learn more
	Given I Navigate to "https://www.selenium.dev/"
	And I Click on About
	And I Click on Govermance
	And I Validate that am on Govermance
	And I Click on learn more
	Then I Should see the sponsors page




Scenario: Search
	Given I Navigate to "https://www.selenium.dev/"
	And I Click on documentation
	And I Search for "Grid"
	And I Select the second option
	Then I Can validate the result