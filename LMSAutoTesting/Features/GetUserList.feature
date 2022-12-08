Feature: GetUserList

A short summary of the feature

@tag1
Scenario: Get user list as manager
	Given Authorize as manager
	When Click on <button name> button
	Then I have to go <page url> page
	| button name      | page url                          |
	| Все пользователи | piter-education.ru:7074/all-users |