Feature: Form
As a user I can complete this testing
So I can be hired by PSL

Scenario: Access to the form
	Given I open the URL
    Then I should access the form page

Scenario: Successfully complete the form
	Given I open the URL
	And I successfully complete all the fields with valid information
	When I click on guardar
	Then I should be directed to the success page

Scenario: Verify not valid information 
	Given I open the URL
	And I successfully complete all the fields with invalid information
	When I press add
	Then Error validations should appear

Scenario: Verify blank field validation
	Given I open the URL
	And I successfully leave all the fields  blank
	When I press add
	Then Error validations should appear