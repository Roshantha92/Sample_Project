using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project.Pages
{
    public class AccountCreatedPage
    {
        public IWebDriver driver;
        By Continue_btn = By.XPath("//a[@class='btn btn-primary']");

        public AccountCreatedPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public AccountCreatedPage AccountVerification(String text)
        {
            IWebElement Text = driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            ClassicAssert.IsTrue(Text.Displayed);
            return new AccountCreatedPage(driver);
        }

        public AccountCreatedPage ClickCreateAccountButton()
        {
            driver.FindElement(Continue_btn).Click();
            return new AccountCreatedPage(driver);
        }


    }
}
