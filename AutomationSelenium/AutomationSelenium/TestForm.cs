
using OpenQA.Selenium;

namespace AutomationSelenium;


[TestFixture]
public class TestForm : DriverChrome
{
    By Nombre = By.Id("firstName");
    By Apellido = By.Id("lastName");
    By Telefono = By.Id("phone");
    By Pais = By.Id("countries_dropdown_menu");
    By SelectPais = By.XPath("//option[@value='Colombia']");
    By Email = By.Id("emailAddress");
    By Password = By.Id("password");
    By Enviar = By.Id("registerBtn");

    [Test]
    public void Test1_FormaOriginal()
    {
        driver.FindElement(Nombre).SendKeys("Cristian");
        driver.FindElement(Apellido).SendKeys("Ladino");
        driver.FindElement(Telefono).SendKeys("3224112767");
        driver.FindElement(Pais).Click();
        driver.FindElement(SelectPais).Click();
        driver.FindElement(Email).SendKeys("prueba@test.com");
        driver.FindElement(Password).SendKeys("123456789");
        driver.FindElement(Enviar).Click();
    }
    //[TearDown]
    //public void TearDown()
    //{
    //    driver?.Quit();
    //    driver?.Dispose();
    //}
}
