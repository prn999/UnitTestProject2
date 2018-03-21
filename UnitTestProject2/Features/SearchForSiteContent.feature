Feature: Search developer.arm.com content with keywords
	Instead of browsing through the links, user should be able to search for content by keying in relevant text

Scenario: Search developer.arm.com for specific products information
	Given user is on developer.arm.com home page
	When they input specific product related word to search
	Then the results page is displayed with relevant products information
