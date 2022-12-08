Feature: Registration
@registration
Scenario: Registrate new student
	Given first name is <first name>
	And last name is <last name> 
	And age is <age>
	And email is <email>
	And password is антонмантон123
	And phone number is +712345678
	When new usser is registrated
	Then student registrated
	Examples: 
	| first name | last name | age | email | password | phone number |registrated  | 
	| Anton | Efremenkov | 30 | anton1@mail.ru | антонмантон123 |+712345678  |registrated  | 