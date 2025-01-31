using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Sample_Project.Pages;
using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace Selenium_Reports.StepDefinitions
{
    [Binding]
    public class RegisterNewUserStepDefinitions
    {
        private IWebDriver driver;
        HomePage homePage;

        public RegisterNewUserStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

     
        [Given(@"I navigate to the URL")]
        public void GivenINavigateToTheURL()
        {
            driver.Url = "https://automationexercise.com/";
            Thread.Sleep(2000);
        }

        [Then(@"I verify that the home page is visible successfully")]
        public void ThenIVerifyThatTheHomePageIsVisibleSuccessfully()
        {
            homePage = new HomePage(driver);
            homePage.PageVerification();
            
        }

        [When(@"I click on the Signup button")]
        public void WhenIClickOnTheSignupButton()
        {
            homePage = new HomePage(driver);
            homePage.SignUpButtonClick();
            
        }

        [Then(@"I verify that New User Signup ""([^""]*)"" is visible")]
        public void ThenIVerifyThatNewUserSignupIsVisible(string expectedText)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.PageVerification(expectedText);
        }


        [When(@"I enter name ""([^""]*)"" and email address ""([^""]*)""")]
        public void WhenIEnterNameAndEmailAddress(string name_return, string email_return)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterNameAndEmailAddress(name_return, email_return);
        }



        [When(@"I click the Signup button")]
        public void WhenIClickTheSignupButton()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickSignUpButton();

        }

        [Then(@"I verify that Enter Account Information ""([^""]*)"" is visible")]
        public void ThenIVerifyThatEnterAccountInformationIsVisible(string p0)
        {

            SignupPage signupPage = new SignupPage(driver);
            signupPage.PageVerification(p0);
        }

        [When(@"I fill in details: Title, Name, Email, Password, Date of Birth")]
        public void WhenIFillInDetailsTitleNameEmailPasswordDateOfBirth()
        {
            SignupPage signupPage = new SignupPage(driver);
            signupPage.GenderSelection();
            signupPage.DaySelection();
            signupPage.MonthSelection();
            signupPage.YearSelection();
         
        }



        [When(@"I select the checkbox Sign up for our newsletter")]
        public void WhenISelectTheCheckboxSignUpForOurNewsletter()
        {
            SignupPage signupPage = new SignupPage(driver);
            signupPage.NewsletterSelection();
            signupPage.SpecialOfferSelection();
       
        }


        [When(@"I fill in details: First Name, Last Name, Company, Address, Address (.*), Country, State, City, Zipcode, Mobile Number")]
        public void WhenIFillInDetailsFirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber(int p0)
        {

            SignupPage signupPage = new SignupPage(driver);
            signupPage.EnterPassword();
            signupPage.EnterFirstName();
            signupPage.EnterLastName();
            signupPage.EnterCompany();
            signupPage.EnterAddress_1();
            signupPage.EnterAddress_2();
            signupPage.CountrySelection();
            signupPage.EnterState();
            signupPage.EnterCity();
            signupPage.EnterZipCode();
            signupPage.EnterMobileNumber();
       

        }

        [When(@"I click the Create Account button")]
        public void WhenIClickTheCreateAccountButton()
        {
            SignupPage signupPage = new SignupPage(driver);
            signupPage.ClickCreateAccountButton();
        }

        [Then(@"I verify that Account  Created ""([^""]*)"" is visible")]
        public void ThenIVerifyThatAccountCreatedIsVisible(string p0)
        {
            AccountCreatedPage accountareatedPage = new AccountCreatedPage(driver);
            accountareatedPage.AccountVerification(p0);
            
        }

        [Then(@"I click the Continue button")]
        public void ThenIClickTheContinueButton()
        {
            AccountCreatedPage accountareatedPage = new AccountCreatedPage(driver);
            accountareatedPage.ClickCreateAccountButton();
            
        }

        [Then(@"I verify that Logged in as username ""([^""]*)"" is visible")]
        public void ThenIVerifyThatLoggedInAsUsernameIsVisible(string p0)
        {
            HomePage homePage = new HomePage(driver);
            homePage.ProfileVerification(p0);
          

        }

        [When(@"I click the Delete Account button")]
        public void WhenIClickTheDeleteAccountButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.DeleteAccountButtonClick();
            
        }

        [Then(@"I verify that Account Deleted ""([^""]*)"" is visible")]
        public void ThenIVerifyThatAccountDeletedIsVisible(string p0)
        {
            IWebElement element5 = driver.FindElement(By.XPath("//*[contains(text(),'" + p0 + "')]"));
            ClassicAssert.IsTrue(element5.Displayed);

            AccountCreatedPage accountcreatedPage = new AccountCreatedPage(driver);
            accountcreatedPage.AccountVerification(p0);
        }

        [Then(@"I click the Continue button after account deleted")]
        public void ThenIClickTheContinueButtonAfterAccountDeleted()
        {
            AccountCreatedPage accountcreatedPage = new AccountCreatedPage(driver);
            accountcreatedPage.ClickCreateAccountButton();
        }

    }
}
