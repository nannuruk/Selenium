Feature: Place an order
	Place an order, check the cart and proceed to checkout
@mytag
Scenario Outline: Place an order to proceed to checkout
	Given I go to automationpractice website
	And I go to Womens and Evening Dresses section
	And I go to Cateogry page to Add to Cart
	And I go to Proceed to checkout on pop-up page
	And I go to SignIn page
	And I enter '<username>' and '<password>'
	And I enter Add a new address
	When I go to Order page to Proceed to checkout
	Then I go to Pay Bank Wire
	Examples: 
	| username             | password      |
	| nannuruk30@gmail.com | Automation123 |

