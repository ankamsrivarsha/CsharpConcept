using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConscept
{
    internal class Bank
    {
        public static void Mai8n(String[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";


            //frames
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='Login_page']")));

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("test123");
            //click on continur
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //click on signup
            driver.SwitchTo().DefaultContent();




        }
    }
}
