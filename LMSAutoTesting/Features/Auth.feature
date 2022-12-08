 Feature:Auth

Scenario:Auth 
Given :Open Auth web page
When : Enter email "anton1@mail.ru"
When : Enter password "антонмантон123"
When : Click enter button
Then : I have to go to the site

Scenario:other Auth 
Given :Open Auth web page
When : Fill phorme
| email          | password       |
| anton1@mail.ru | антонмантон123 |
And : Click enter button
Then : I have to go to the site

