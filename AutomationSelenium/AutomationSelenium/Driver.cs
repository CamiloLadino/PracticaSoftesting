using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSelenium;


public class DriverChrome
{
    protected IWebDriver driver = null!;

    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("https://qa-practice.netlify.app/bugs-form");

    }
    // Add driver related methods and properties here
}
