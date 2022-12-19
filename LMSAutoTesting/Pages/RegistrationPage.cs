using LMSAutoTesting.Support;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LMSAutoTesting.Pages
{
    public class RegistrationPage : AbstractPage
    {
        public IWebElement firstName => _driver.FindElement(By.XPath(@"//input[@name='firstName']"));
        public IWebElement lastName => _driver.FindElement(By.XPath(@"//input[@class='form-input']"));
        public IWebElement birthDate => _driver.FindElement(By.XPath(@"//div[@class='date-picker form-input']"));
        public IWebElement Email => _driver.FindElement(By.XPath(@"//div[@class='date-picker form-input']"));
        public IWebElement Patronymic => _driver.FindElement(By.XPath(@"//input[@name='patronymic']"));
        public IWebElement Password => _driver.FindElement(By.XPath(@"//input[@class='custom-password form-input']"));
        public IWebElement repeatPassword => _driver.FindElement(By.XPath(@"//input[@name='=> _driver.FindElement(By.XPath(@']"));
        public IWebElement phoneNumber => _driver.FindElement(By.XPath(@"//input[@name='phoneNumber']"));
        public IWebElement clickRegistrate => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(Urls.RegistrationPage);
        }

        public void Enterfirstname(string firstname)
        {
            Actions actions = new Actions(_driver);
            actions.Click(firstName).SendKeys(firstname).Build().Perform();
        }
        public void Enterlastname(string lastname)
        {
            Actions actions = new Actions(_driver);
            actions.Click(lastName).SendKeys(lastname).Build().Perform();
        }
        public void Enterpatronymic(string patronymic)
        {
            Actions actions = new Actions(_driver);
            actions.Click(Patronymic).SendKeys(patronymic).Build().Perform();
        }
        public void Enteremail(string email)
        {
            Actions actions = new Actions(_driver);
            actions.Click(Email).SendKeys(email).Build().Perform();
        }
        public void Enterbirthdate(string birthdate)
        {
            Actions actions = new Actions(_driver);
            actions.Click(birthDate).SendKeys(birthdate).Build().Perform();
        }
        public void Enterpassword(string password)
        {
            Actions actions = new Actions(_driver);
            actions.Click(Password).SendKeys(password).Build().Perform();
        }
        public void Enterrepeatpassword(string repeatpassword)
        {
            Actions actions = new Actions(_driver);
            actions.Click(repeatPassword).SendKeys(repeatpassword).Build().Perform();
        }
        public void Enterphonenumber(string phonenumber)
        {
            Actions actions = new Actions(_driver);
            actions.Click(phoneNumber).SendKeys(phonenumber).Build().Perform();
        }
         public void clickregistrate()
        {
            Actions actions = new Actions(_driver);
            actions.Click(clickRegistrate).Perform();
        }
    }
}
