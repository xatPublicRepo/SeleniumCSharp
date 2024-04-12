Selenium C#

Nuget manager is used to manage the packages.



//Selenium <br>
IWebDriver driver = new ChromeDriver();<br>
driver.Manage().Window.Maximize();<br><br>

//Launch URL<br>
driver.Navigate().GoToUrl("url");<br><br>

//Store Locator<br>
IWebElement element = By.Id("locator");<br><br>

//Type<br>
driver.FindElement(element).SendKeys("Hello");<br><br>

//Click<br>
driver.FindElement(element).Click();<br><br>

//Dropdown<br>
SelectElement dd = new SelectElement(driver.FindElement(By.Xpath("sdf")));<br>
dd.SelectByText("ABC");<br>
dd.SelectByValue("abc");<br>
dd.SelectByIndex(2);<br>
dd.SelectedOption.Text;<br>
dd.AllSelectedOptions<br>
dd.DeselectByText("ac");<br>
dd.DeselectByValue();<br>
dd.DeselectByIndex();<br>
dd.DeselectAll();<br>
<br>

//Extension method<br>
Using Extension method we can creat our custom methods which can be seen under the autosuggestion of specific type.<BR>
Example: Like when we press dot(.) after webelement , we can see all the methdos applicable to that webElement.<br>
Now, lets say I want to wrap selenium Click with my custom method called as MyClick() and I want see this in autosuggestion when I press dot(.) after the web element. <br>
so instead of element.Click(), it should be element.MyClick();<br>
The above can be achieved by using Extesion method.<br>
Rules<br>
1. The Class where we are wrtiing our custom methods should be <b>static.</b> <br>
2. The custom methods should have the first parameter as the Type for which we want to create an Extension method eg IWebElement <br>
3. The first parameter should have <b> this </b> keyword.<br>
<i> For Reference please check the <b>SeleliumActions</b> class inside Utilities folder. </i>
<br><br>

