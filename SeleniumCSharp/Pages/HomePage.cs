using OpenQA.Selenium;
using SeleniumCSharp.Utilities;

namespace SeleniumCSharp.Pages
{
	public class HomePage
	{
        private IWebDriver driver;


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement greetUserMsg => driver.FindElement(By.XPath("//li/a[@title='Manage']"));

        public string GetGreetingMessage()
        {
            return greetUserMsg.EAGetElementText();
        }

    }
}

