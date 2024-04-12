using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Pages;

namespace SeleniumCSharp.Tests
{
	//[Parallelizable(ParallelScope.Children)] // All Tests inside this class will run in parallel
	public class LoginTestPOM
	{
		ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        [SetUp]
		public void Setup()
		{
			
            driver.Value = new ChromeDriver();
            driver.Value.Navigate().GoToUrl(ConfigurationManager.AppSettings["appUrl"]);
            driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

		[Test,Category("Regression"),Order(2)]//Test will execute twice as there are 2 [TestCase]
		[TestCase("admin","password")]
        //[TestCase("admin1", "password1")]
        //[Parallelizable(ParallelScope.All)]
        public void LoginTest(string username, string pwd)
		{
			string actualMsg = new LandingPage(driver.Value).ClickLoginLink()
				.LoginToPortal(username, pwd).GetGreetingMessage();

			Assert.AreEqual("Hello admin!", actualMsg);

		}
		[Test,Category("Smoke"),Order(1)]
        //[TestCaseSource("getTestData")]
        //public void LoginTest2(string username, string pwd)
        [TestCase("admin1", "password")]
        [Parallelizable(ParallelScope.All)]
        public void InvalidLoginTest(string username, string pwd)
        {
            new LandingPage(driver.Value).ClickLoginLink()
                .LoginToPortal(username, pwd);
            Assert.True(new LoginPage(driver.Value).isErrorDisplayed());

        }

        [TearDown]
		public void TearDown()
		{
            driver.Value.Close();
            driver.Value.Quit();

		}

		public static IEnumerable<TestCaseData> getTestData()
		{
			yield return new TestCaseData("admin0", "password");
            yield return new TestCaseData("admin1", "password");
            yield return new TestCaseData("admin2", "password");
        }
	}
}

