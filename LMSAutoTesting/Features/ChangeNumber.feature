Feature: ChangeNumber

@tag1
Scenario: ChangeNumber
	Given Open Auth webpage
	When Enter email <email>
	When Enter password <password> 
	When Click login button
	And Open settings web page 
	And Click number
	And Enter new number <new number>
	And Click save
	And Log out from the web page
	And Open Auth webpage again
	Examples: 
	| password	     | new number    |       email          |
	| 'marina123456' | 'marina12345' | 'marina@example.com' |