 Feature:Auth

Scenario:Auth 
	Given Open Registration web page
	And Ignore security warning
	When Fill the form
	| Surname | Name  | Patronymic  | BirthDate |Password      | RepeatPassword | Email          | Phone      |
	| Алиев   | Антон | Сергеевич   | 20.12.2000|qwerty123456  | qwerty123456   | anton11@mail.ru| +712345678 |
	And Click registrate
	And Click authorize(menu on the left)
	And Ignore security warning
	When Enter email "anton11@mail.ru"
	When Enter password "qwerty123456"
	When Click enter button
	Then Menu should be opened