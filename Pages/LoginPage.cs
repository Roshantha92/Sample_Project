using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project.Pages
{
   
    public class LoginPage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By Name = By.XPath("//*[@name='name']");
        By Email = By.XPath("//form[@action='/signup'] //*[@name='email']");
        By SignUpButton = By.XPath("//*[@data-qa='signup-button']");
        public LoginPage PageVerification(String heading)
        {
            IWebElement Heading = driver.FindElement(By.XPath("//*[contains(text(),'" + heading + "')]"));
            ClassicAssert.IsTrue(Heading.Displayed);
            return new LoginPage(driver);
        }

        public SignupPage EnterNameAndEmailAddress(String name , String email)
        {
            driver.FindElement(Name).SendKeys(name);
            driver.FindElement(Email).SendKeys(email);
            return new SignupPage(driver);
        }

        public SignupPage ClickSignUpButton()
        {
            driver.FindElement(SignUpButton).Click();
            return new SignupPage(driver);
        }
    }
}
