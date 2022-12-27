Feature: AddGroupMember
@editgroup
Scenario: Add member to group
Given Registrate students with Api
| firstName | lastName | patronimyc | email                  | username | password     | city | birthDate  | gitHubAccount | phoneNumber  |
| Ken       | Miles    | John       | milesmiles@example.com | knmls    | qwerty123456 | Baku | 22.12.2002 | github.com    | +71234567890 |
| Keanu     | Reeves   | Morphius   | keanureeves@example.com| knrvs    | qwerty123456 | Baku | 22.12.2002 | github.com    | +71234567890 |
| Yasemen   | xanim    | Sasha      | yasemenxnm@example.com | ysmnx    | qwerty123456 | Baku | 22.12.2002 | github.com    | +71234567890 |
And Auth as admin with api
 | Email              | Password     |
 | marina@example.com | marina123456 |
And Give second student teacher role as admin
And Give third student tutor role as admin
And Create courses as  admin
| name    | description |
| C# QA&A | abcdefu     |
And Create group as  admin
| name | courseId | groupStatusId | startData | endDate   | timetable | paymentPerMonth | paymentsCount |
|string| 2993     |   Forming     |10.10.2022 |22.10.2022 |  string   |      0          |     20        |
And Open auth web page
And Ignore security warning
And Auth as admin 
 | Email              | Password     |
 | marina@example.com | marina123456 |
And Click login button
And Click groups on HomePage
And Click to edit list of group
Then Page of students should be opened