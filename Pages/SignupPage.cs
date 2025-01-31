using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sample_Project.Pages
{
    public class SignupPage
    {
        public IWebDriver driver;

        By gender = By.Id("id_gender1");
        By password = By.Id("password");
        By Fname = By.Id("first_name");
        By Lname = By.Id("last_name");
        By company = By.Id("company");
        By address_1 = By.Id("address1");
        By address_2 = By.Id("address2");
        By NewsLetter = By.Id("newsletter");
        By SpecialOffers = By.Id("optin");
        By State = By.Id("state");
        By City = By.Id("city");
        By Zipcode = By.Id("zipcode");
        By Mobile = By.Id("mobile_number");
        By CreateAccount_btn = By.XPath("//form[@action='/signup'] //button[@type='submit']");

        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public SignupPage PageVerification(String heading)
        {
            IWebElement Heading = driver.FindElement(By.XPath("//*[contains(text(),'" + heading + "')]"));
            ClassicAssert.IsTrue(Heading.Displayed);
            return new SignupPage(driver);
        }

        public SignupPage GenderSelection()
        {
            driver.FindElement(gender).Click();
            return new SignupPage(driver);
        }

        public SignupPage DaySelection()
        {
            IWebElement Day = driver.FindElement(By.Id("days"));
            var selectElement_1 = new SelectElement(Day);
            selectElement_1.SelectByValue("11");
            return new SignupPage(driver);
        }

        public SignupPage MonthSelection()
        {
            IWebElement Month = driver.FindElement(By.Id("months"));
            var selectElement_1 = new SelectElement(Month);
            selectElement_1.SelectByText("December");
            return new SignupPage(driver);
        }

        public SignupPage YearSelection()
        {
            IWebElement Year = driver.FindElement(By.Id("years"));
            var selectElement_1 = new SelectElement(Year);
            selectElement_1.SelectByValue("1992");
            return new SignupPage(driver);
        }

        public SignupPage CountrySelection()
        {
            IWebElement Year = driver.FindElement(By.Id("country"));
            var selectElement_1 = new SelectElement(Year);
            selectElement_1.SelectByValue("United States");
            return new SignupPage(driver);
        }

        public SignupPage EnterPassword()
        {
            driver.FindElement(password).SendKeys("!QAZ2wsx");
            return new SignupPage(driver);
        }
        public SignupPage EnterFirstName()
        {
            driver.FindElement(Fname).SendKeys("ENR");
            return new SignupPage(driver);
        }
        public SignupPage EnterLastName()
        {
            driver.FindElement(Lname).SendKeys("Automation");
            return new SignupPage(driver);
        }
        public SignupPage EnterCompany()
        {
            driver.FindElement(company).SendKeys("IFS");
            return new SignupPage(driver);
        }
        public SignupPage EnterAddress_1()
        {
            driver.FindElement(address_1).SendKeys("Colombo09");
            return new SignupPage(driver);
        }
        public SignupPage EnterAddress_2()
        {
            driver.FindElement(address_2).SendKeys("Dematagoda");
            return new SignupPage(driver);
        }

        public SignupPage NewsletterSelection()
        {
            driver.FindElement(NewsLetter).Click();
            return new SignupPage(driver);
        }

        public SignupPage SpecialOfferSelection()
        {
            driver.FindElement(SpecialOffers).Click();
            return new SignupPage(driver);
        }

        public SignupPage EnterState()
        {
            driver.FindElement(State).SendKeys("Colombo");
            return new SignupPage(driver);
        }

        public SignupPage EnterCity()
        {
            driver.FindElement(City).SendKeys("Colombo09");
            return new SignupPage(driver);
        }
        public SignupPage EnterZipCode()
        {
            driver.FindElement(Zipcode).SendKeys("20032");
            return new SignupPage(driver);
        }
        public SignupPage EnterMobileNumber()
        {
            driver.FindElement(Mobile).SendKeys("711595151");
            return new SignupPage(driver);
        }
        public AccountCreatedPage ClickCreateAccountButton()
        {
            driver.FindElement(CreateAccount_btn).Click();
            return new AccountCreatedPage(driver);
        }
    }
}
