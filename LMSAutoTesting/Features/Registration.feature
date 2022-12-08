Feature: Registration
@registration
Scenario: Registrate new student
	Given first name is <first name>
	And last name is <last name> 
	And birthDate is <data>
	And email is <email>
	And password is <password>
	And phone number is <phone number>
	When new usser is registrated
	Then student <registrated>
	Examples: 
	| first name | last name | data | email         |       password | phone number |registrated  | 
	| Anton      | Efremenkov| 30  | anton1@mail.ru | антонмантон123 |+712345678    |registrated  | 