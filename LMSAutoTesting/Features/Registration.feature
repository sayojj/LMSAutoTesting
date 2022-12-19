Feature: Registration
@registration
Scenario: Registration
 Given open register web page
 When first name is <first name>
 When last name is <last name>
 When patronymic is <patronymic>
 When birthDate is <data>
 When email is <email>
 When password is <password>
 When phone number is <phone number>
 When click registrate
 Then student <registrated>