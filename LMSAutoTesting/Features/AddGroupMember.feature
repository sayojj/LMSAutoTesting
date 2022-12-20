Feature: AddGroupMember

A short summary of the feature

@tag1
Scenario: Add member to group
	Given Open Auth web page
	Given Ignore security warning
	When Enter email "[string]"
	And Enter password "[string]"
	And Click enter button
	Given Group created
	When press groups on HomePage
	And Choose group from list of groups
	And edit students of group list
	Then page of students should be opened
