using OpenQA.Selenium;
using SeleniumCSharp.Utilities;

namespace SeleniumCSharp.Pages
{
	public class LandingPage
	{
        private IWebDriver driver;


        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement loginLink => driver.FindElement(By.Id("loginLink"));

        public LoginPage ClickLoginLink()
        {
            loginLink.EACLick();
            return new LoginPage(driver);
        }
    }
}

