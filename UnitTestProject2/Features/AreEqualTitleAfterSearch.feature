Feature: AreEqualTitleAfterSearch
	


Scenario: Check are equal title of first article after search to hardcoded text
	Given I go to BBC home page and click on News
	When I fill the search form with category of main article and navigated to search results page
	Then Check are equal title of first article to hardcoded 
