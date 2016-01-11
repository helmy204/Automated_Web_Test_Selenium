using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new InternetExplorerDriver(@"C:\Libraries\");
            //IWebDriver driver = new ChromeDriver(@"C:\Libraries\");
            //driver.Url = "http://www.google.com";

            IWebDriver driver = new ChromeDriver(@"C:\Libraries\");
            driver.Url = "http://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("pluralsight");
            searchBox.Submit();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var imagesLink = driver.FindElements(By.ClassName("q"))[0];
            imagesLink.Click();
        }
    }
}
