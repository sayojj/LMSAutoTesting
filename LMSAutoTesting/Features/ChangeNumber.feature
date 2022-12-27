﻿Feature: ChangeNumber

@tag1
Scenario: ChangeNumber
	Given Open Auth webpage 
	When Enter email <email>
	When Enter password <password> 
	When Click login button
	And Click settings
	And Click number
	And Enter new number <new number>
	And Click save
	And Log out from the web page
	When Enter email <email>
	When Enter password <password> 
	When Click login button
	And Click settings
	Then Number changed
	Examples: 
	| password	     | new number       |       email          |
	| 'marina123456' | '32432142123123' | 'marina@example.com' |