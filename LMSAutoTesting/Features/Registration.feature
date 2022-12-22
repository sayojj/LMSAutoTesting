Feature: Registrations
@taggg
Scenario: Registration
	Given open register web page
	When first name is <first name>
	When last name is <last name>
	When patronymic is <patronymic>
	When birthDate is <data>
	When email is <email>
	When password is <password>
	When Repeat <password>
	When phone number is <phone number>
	When click registrate
	Given Open Auth web page
	Then student <registrated>

 Examples: 
 | first name | last name  | patronymic | data      |email           | password   | repeat password | phone number | registr
 | Антон    | Алиев         |Сергеевич  | 20.12.2000| anton11@mail.ru | 123454321 | 123454321       | +712345678   | registrated |
 