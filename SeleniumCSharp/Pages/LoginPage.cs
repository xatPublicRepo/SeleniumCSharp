using OpenQA.Selenium;
using SeleniumCSharp.Pages;
using SeleniumCSharp.Utilities;

namespace SeleniumCSharp
{
	public class LoginPage
	{
		private IWebDriver driver;


        public LoginPage(IWebDriver driver)
		{
			this.driver = driver;
		}

        
        private IWebElement userNameTxtBox => driver.FindElement(By.Name("UserName"));
        private IWebElement passwordTxtBox => driver.FindElement(By.XPath("//input[@type='password']"));
        private IWebElement loginBtn => driver.FindElement(By.XPath("//input[@type='submit'][@value='Log in']"));
        private IWebElement inValidLoginMsg => driver.FindElement(By.XPath("//*[contains(text(),'Invalid login attempt.')]"));


        public HomePage LoginToPortal(string uname, string pwd)
        {
            userNameTxtBox.EAType(uname);
            passwordTxtBox.EAType(pwd);
            loginBtn.EACLick();
            return new HomePage(driver);
        }

        public Boolean isErrorDisplayed()
        {
            return inValidLoginMsg.Displayed;
        }



    }
}

