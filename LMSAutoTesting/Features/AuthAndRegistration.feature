 Feature:AuthAndRegistration
Scenario:Registration 
	Given Open Registration web page
	And Ignore security warning
	When Fill the form
	| Surname | Name  | Patronymic  | BirthDate |Password      | RepeatPassword | Email              | Phone       |
	| Алиев   | Антон | Сергеевич   | 20.12.2000|qwerty123456  | qwerty123456   | anton11@example.com| +71234567890|
	And Click registrate
	And Click authorize(menu on the left)
	When Enter email "anton11@example.com"
	When Enter  password "qwerty123456"
	When Click enter button
	Then Menu should be opened