Feature: AreEqualMainTitileOfArticle
	


Scenario: checkMainArticle 
	Given I go to BBC HomePage
	When I click on button News
	Then Title of main article will be equal to hardcoded
