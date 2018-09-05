Feature: Place an order with new user account
	Place an order from homepage and create new user account 
	on fly to purchase and confirm the order

@mytag
Scenario: Place an order with new user account to finish the transaction
	Given I go to automationpractice website
	And I go to Womens and Evening Dresses section
	And I go to Cateogry page to Add to Cart
	And I go to Proceed to checkout on pop-up page
	And I go to LogIn page
	When I enter Add a new address
	And I go to Proceed to checkout on Order page
	Then I go to Pay Bank Wire