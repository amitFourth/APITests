Feature: Baskets
	In order to access Baskets
	As a user
	I want to be able to get the baskets information throught the Purchasing API

@smoke 
Scenario: Get the Locations Current Baskets
	Given the /locations/{LocationId}/Baskets/Current/ resource
	#When a GET request using {LocationId} = $LocationId is executed
	#Then HTTP Code is 200
	#And the response returns all current baskets
