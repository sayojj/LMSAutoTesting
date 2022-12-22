 Feature:Auth

Scenario:Auth 
Given Open Registration web page
And Ignore security warning
When Fill the form
| first name | last name  | patronymic | data    |email             | password | repeat password | phone number|
| Антон      | Алиев      |Сергеевич | 20.12.2000|anton11@mail.ru   | 123454321| 123454321       | +712345678  |
 And Click registrate
And Click authorize
And Ignore security warning
When Enter email "marina@example.com"
When Enter password "marina123456"
When Click enter button
Then Menu should be opened