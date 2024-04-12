using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp.Utilities
{
	/*
	 * Here we are creating Extension methods
	 *  Rules For extension method, we need to make the class sttaic and the Type,
	 *  for which we want extension method has to be the first parameter with this keyword.
	 * 
	 */
	public static class SeleniumActions
	{
		public static void EACLick(this IWebElement locator)
		{
			locator.Click();
		}
        public static void EAType(this IWebElement locator,string data)
        {
			locator.Clear();
			locator.SendKeys(data);
        }
		public static string EAGetElementText(this IWebElement locator)
		{
			return locator.Text;
		}
		public static void WaitForElementToBeVissible(this By locator , IWebDriver driver, WebDriverWait wait)
		{
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
		}
    }
}

