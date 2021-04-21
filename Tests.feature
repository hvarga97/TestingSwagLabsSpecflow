Feature: Tests
	Testing the https://www.saucedemo.com/ website

@mytag
Scenario: Test_01
	Given Navigate to Login Page
	And Enter UserName
	And Enter PassWord
	When Click on Login button 
	Then Should open Home Page
	And Close browser

Scenario: Test_02
	Given Navigate to Login Page
	And Enter UserName
	And Enter PassWord
	When Click on Login button 
	And Home Page
	Then Click Add to cart for Sauce Labs Backpack
	And Click Add to cart for Sauce Sauce Labs Bike Light
	And Click Add to cart for Sauce Labs Bolt T-Shirt
	And Click Add to cart for Sauce Labs Fleece Jacket
	And Click Add to cart for Sauce Labs Onesie
	And Click Add to cart for Test.allTheThings() T-Shirt (Red)
	And Close browser

Scenario: Test_03
	Given Navigate to Login Page
	And Enter UserName
	And Enter PassWord
	When Click on Login button 
	And Home Page
	Then Click Add to cart for Sauce Labs Backpack
	And Click Add to cart for Sauce Sauce Labs Bike Light
	And Click Add to cart for Sauce Labs Bolt T-Shirt
	And Click Add to cart for Sauce Labs Fleece Jacket
	And Click Add to cart for Sauce Labs Onesie
	And Click Add to cart for Test.allTheThings() T-Shirt (Red)
	And Click Remove for Sauce Labs Backpack
	And Click Remove for Sauce Sauce Labs Bike Light
	And Click Remove for Sauce Labs Bolt T-Shirt
	And Click Remove for Sauce Labs Fleece Jacket
	And Click Remove for Sauce Labs Onesie
	And Click Remove for Test.allTheThings() T-Shirt (Red)
	And Close browser

Scenario: Test_04
	Given Navigate to Login Page
	And Enter UserName
	And Enter PassWord
	When Click on Login button 
	And Home Page
	When Click on shopping cart
	Then Should open shopping cart page 
	And Close browser