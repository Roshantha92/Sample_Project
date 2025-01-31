using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project.Pages
{
    public class DeleteAccountPage
    {
        public IWebDriver driver;
        By delete_continue_btn = By.XPath("//a[@class='btn btn-primary']");
        public DeleteAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public DeleteAccountPage AccountDEleteVerification(String text)
        {
            IWebElement Text = driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            ClassicAssert.IsTrue(Text.Displayed);
            return new DeleteAccountPage(driver);
        }

        public HomePage SignUpButtonClick()
        {

            driver.FindElement(delete_continue_btn).Click();
            return new HomePage(driver);
        }
    }
}
