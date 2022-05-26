using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConscept
{
    internal class Program
    {
        static void Main0(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://opensource-demo.orangehrmlive.com/index.php/dashboard";
            string currentUrl = driver.Url;
            Console.WriteLine(currentUrl);

            string title = driver.Title;
            Console.WriteLine(title);

            string pageSource = driver.PageSource;
            Console.WriteLine(pageSource);

            Console.WriteLine(pageSource.Contains("LOGIN Panel"));

            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();


        }
    }
}
