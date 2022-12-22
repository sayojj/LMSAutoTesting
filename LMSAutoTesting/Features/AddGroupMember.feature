Feature: AddGroupMember

A short summary of the feature

@tag1
Scenario: Add member to group
	Given Open Auth web page
	Given Ignore security warning
	When Enter email "marina@example.com"
	And Enter password "marina123456"
	And Click enter button
	When press groups on HomePage
	And edit students of group list
	Then page of students should be opened
