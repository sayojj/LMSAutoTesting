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
 When Repeat <password>
 When phone number is <phone number>
 When click registrate
 Then student <registrated>
 Examples: 
 | first name | last name  | patronymic | data | email          | password       | repeat password | phone number | registrated |
 | Anton      | Efremenkov | Сергеевич  | 30   | anton1@mail.ru | антонмантон123 | антонмантон123  | +712345678   | registrated |
 