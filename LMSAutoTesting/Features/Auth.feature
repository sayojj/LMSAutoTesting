 Feature:Auth

Scenario:Auth 
Given Open Auth web page
And Ignore security warning
When Enter email "marina@example.com"
When Enter password "marina123456"
When Click enter button
Then Menu should be opened



