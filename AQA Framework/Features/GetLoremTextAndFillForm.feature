Feature: GetLoremTextAndFillForm
	


Scenario: Get lorem ipsum text, and fill worm with it
	Given I go to lipsum.com 
	When I generate the lorem ipsum text
	Then i navigated to page with BBC form and fill it
