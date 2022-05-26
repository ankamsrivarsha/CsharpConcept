using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Task2
    {
        public static void Main24(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.db4free.net/phpMyAdmin/";

            String currenturl = driver.Url;
            Console.WriteLine(currenturl);

            String title = driver.Title;
            Console.WriteLine(title);

            string pageSource = driver.PageSource;
            Console.WriteLine(pageSource);


            driver.FindElement(By.TagName("title")).Click();
            driver.FindElement(By.Id("input_username")).SendKeys("db123");
            driver.FindElement(By.Id("input_password")).SendKeys("test123");

            driver.FindElement(By.Id("input_go")).Click();

        }


    }
}
