Feature: GetStudentsList

@StudentList
Scenario: Get list of students
	Given Login as manager
	When Click on <button name> button
	Then I have to go <page url> page
	| button name      | page url                              |
	| Список студентов | piter-education.ru:7074/students-list |