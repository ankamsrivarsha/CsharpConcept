using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Saleforce
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/?d=70130000000Enyk";

            //enter the firstname
            driver.FindElement(By.Id("UserFirstName-93La")).SendKeys("john");

            //enter the lastname
            driver.FindElement(By.Id("UserLastName-HV5f")).SendKeys("wick");

            //enter the mail
            driver.FindElement(By.Id("UserEmail - e4dx")).SendKeys("john@gmail.com");

            //select job
            SelectElement selectJob = new SelectElement(driver.FindElement(By.Id("UserTitle - Etf7")));
            selectJob.SelectByText("IT Manager");

            //select employees
            SelectElement selectEmp = new SelectElement(driver.FindElement(By.Id("UserTitle-Etf7")));
            selectEmp.SelectByText("101-500");

            //select country
            SelectElement selectCou = new SelectElement(driver.FindElement(By.Id("CompanyEmployees-KA08")));
            selectCou.SelectByText("United Kingdom");

            //click on chek box
            driver.FindElement(By.XPath("//div[@class='checkbox-ui']")).Click();


            //click on start trial
            driver.FindElement(By.XPath("//button[@name='start my free trial']")).Click();


        }
    }
}
