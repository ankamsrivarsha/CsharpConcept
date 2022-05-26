using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConscept
{
    internal class Facebook
    {
        static void Main00(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.facebook.com/";
            //click on create account
            driver.FindElement(By.LinkText("Create New Account")).Click();
            // enetr first name as john
            driver.FindElement(By.Name("firstname")).SendKeys("John");
            //enetr lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            //enter the password
            driver.FindElement(By.Id("passwors_step_input")).SendKeys("welcome@123");

            //select 15 date
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("15");

            //select dec month
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");

            //select 2000 year
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectMonth.SelectByText("2000");

            //click on radio buttons"
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on sign up
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();


        }
    }
}
