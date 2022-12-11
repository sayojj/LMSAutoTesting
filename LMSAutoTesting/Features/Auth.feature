 Feature:Auth

Scenario:Auth 
Given Open Auth web page
And Ignore security warning
When Enter email "marina@example.com"
When Enter password "marinamarina"
When Click enter button
Then Menu should be opened

#Scenario:other Auth 
#Given :Open Auth web page
#When : Fill phorme
#| email          | password       |
#| anton1@mail.ru | антонмантон123 |
#And : Click enter button
#Then : I have go to go to the site

