Feature: GetUserFeature
In order to get user information from the API
As an API Consumer
I want to get user by Id


Scenario: Get User by Id
	Given that a user exists in the system
	When I request to get the user by Id
	Then the user should be returned in the response
	And  the response status code is '200 Ok'

Scenario: Get none-existing user by Id
	Given that a user does not exists in the system
	When I request to get the user by Id 
	Then no user should be returned in the response
	And the response status code is '404 Not Found'
