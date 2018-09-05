Feature: Login
	Checking whether valid/invalid credentials test cases work fine
@mytag
Scenario Outline: Valid credentials check
	Given I go to automationpractice website
	And I go to SignIn page
	When I enter '<username>' and '<password>'
	Then I should be naviagted to MyAccount page
	Examples: 
	| username             | password      |
	| nannuruk30@gmail.com | Automation123 |
	