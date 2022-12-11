Feature: ChangePassword

@tag1
Scenario: ChangePassword
	Given Open your profil 
	When Click edit password
	And : Text "stariy parol,noviy i povtor"
	And : click "soxranit"
	Then : Password changed
