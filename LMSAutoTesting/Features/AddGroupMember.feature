Feature: AddGroupMember
@tag1
Scenario: Add member to group
Given Registration as student1 api
And Auth as admin api
 | Email              | Password     |
 | marina@example.com | marina123456 |
And Give student2 teacher role as admin
And Give student3 tutor role as admin
And Create courses by admin
And Create group by admin
And Add users in group as admin
And Open auth web page
And Auth as admin 
 | Email              | Password     |
 | marina@example.com | marina123456 |
And Click to the role button
And Click to  the button admin
And Click to "groups"
And Click to "edit gruops list"
Then Page of students should be opened