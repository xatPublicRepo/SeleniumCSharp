using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp
{
	public class EALoginTest
	{
		IWebDriver driver;


		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
			driver.Manage().Window.Maximize();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
		}

		By loginLink = By.Id("loginLink");
		By userNameTxtBox = By.Name("UserName");
		By passwordTxtBox = By.XPath("//input[@type='password']");
        By loginBtn = By.XPath("//input[@type='submit'][@value='Log in']");
		By greetUserMsg = By.XPath("//li/a[@title='Manage']");

        [Test]
		public void LoginTest()
		{
			driver.FindElement(loginLink).Click();
			driver.FindElement(userNameTxtBox).SendKeys("admin");
            driver.FindElement(passwordTxtBox).SendKeys("password");
            driver.FindElement(loginBtn).Click();
			string greetMsg= driver.FindElement(greetUserMsg).Text;
			Assert.AreEqual("Hello admin!", greetMsg);
        }

        [TearDown]
		public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

