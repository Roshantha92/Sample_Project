using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project.Pages
{
    public class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
        }
        By logo = By.XPath("//*[@alt='Website for automation practice']");
        By signup_login_btn = By.XPath("//*[@class='fa fa-lock']");
        By delete_btn = By.XPath("//a[@href='/delete_account']");

                public HomePage PageVerification() {
            
            IWebElement logo1 = driver.FindElement(logo);
            ClassicAssert.IsTrue(logo1.Displayed);
            return new HomePage(driver);  
        
        }

        public LoginPage SignUpButtonClick()
        {
           
            driver.FindElement(signup_login_btn).Click();
            return new LoginPage(driver);
        }


        public HomePage ProfileVerification(String profile)
        {
            IWebElement ProfileName = driver.FindElement(By.XPath("//*[contains(text(),'" + profile + "')]"));
            ClassicAssert.IsTrue(ProfileName.Displayed);
            return new HomePage(driver);
        }

        public HomePage DeleteAccountButtonClick()
        {
            driver.FindElement(delete_btn).Click();
            return new HomePage(driver);
        }
    }
}
