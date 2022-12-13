Feature: ChangePassword

@tag1
Scenario: ChangePassword
	Given Open your profil
	When Click edit password
	And zapolnit formu
	And  click "soxranit"
	Then  Password changed
