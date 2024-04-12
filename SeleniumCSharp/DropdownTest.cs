using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp
{
	public class DropdownTest
	{
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationtesting.co.uk/dropdown.html");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        By dropdown = By.Id("cars");

        [Test]
        public void HandleDropdownTest()
        {
            //Select by Text
            SelectElement dropdownElement = new SelectElement(driver.FindElement(dropdown));
            dropdownElement.SelectByText("Jeep");
            string selectedOption = dropdownElement.SelectedOption.Text;
            Console.WriteLine(selectedOption);
            Assert.AreEqual("Jeep", selectedOption);

            //Select By Value
            dropdownElement.SelectByValue("ford");
            selectedOption = dropdownElement.SelectedOption.Text;
            Console.WriteLine(selectedOption);
            Assert.AreEqual("Ford", selectedOption);

            //Select By Option
            dropdownElement.SelectByIndex(6);
            selectedOption = dropdownElement.SelectedOption.Text;
            Console.WriteLine(selectedOption);
            Assert.AreEqual("Suzuki", selectedOption);
            Console.WriteLine("All verification completed.");



        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}

