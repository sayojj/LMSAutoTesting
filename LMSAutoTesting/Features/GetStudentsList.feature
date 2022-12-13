Feature: GetStudentsList

@StudentList
Scenario: Get list of students
	Given Open Auth  web page
	When Enter email  "marina@example.com"
	And Enter password  "marina123456"
	And Click Enter buttom
	When Click on <button name> button
	Then I have to go <page url> page
	| button name      | page url                              |
	| Список студентов | piter-education.ru:7074/students-list |