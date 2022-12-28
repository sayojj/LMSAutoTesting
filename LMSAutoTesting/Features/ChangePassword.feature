Feature: ChangePassword
@editpassword
Scenario: ChangePassword
	Given Open Auth webpage
	Given Ignore security warning
	When Enter email <email>
	When Enter password <old password> 
	When Click login button
	And Open settings web page 
	And Click edit password
	And Enter old password again <old password>
	And Enter new password <new password>
	And Repeat new password <new password>
	And Click save
	And Log out from the web page
	And Enter email again <email>
	And Enter new password again <new password>
	When Click login button again
	Then Password changed
	Examples: 
	| old password	  | new password  |       email          |
	| 'marina123456'  | 'marina12345' | 'marina@example.com' |