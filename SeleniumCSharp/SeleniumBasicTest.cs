using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp;

public class SeleniumBasicTest
{
    IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {
       
        driver.Navigate().GoToUrl("http://www.google.com");
        driver.FindElement(By.Name("q")).SendKeys("Selenium" + Keys.Enter);
        Thread.Sleep(3000);
        


    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
        driver.Quit();
    }
}
