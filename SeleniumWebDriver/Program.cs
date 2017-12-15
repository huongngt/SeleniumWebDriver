using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\MyProject\Test\SeleniumWebDriver\Drivers");
            driver.Url = "http://www.google.com";

            var searchbox = driver.FindElement(By.Name("q"));
            searchbox.SendKeys("pluralsight");
            searchbox.Submit();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var imagesLink = driver.FindElements(By.CssSelector("a.q.qs"))[1];
            imagesLink.Click();
        }
    }
}
