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
    internal class openemeWeb
    {
        public static void Main(String[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/";

            //Update User Name
            driver.FindElement(By.Id("authUser")).SendKeys("admin");

            //update password
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            //select language
            SelectElement selectLang = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            selectLang.SelectByText("English(Indian)");

            //click on login
            driver.FindElement(By.Id("login-button")).Click();

            //click on patient
            driver.FindElement(By.XPath("//div[@class='menuLabel px - 1 dropdown - toggle oe - dropdown - toggle']")).Click();

            //click on new search
            driver.FindElement(By.XPath("//div[@class = 'menuLabel px-1']")).Click();

            //add first name
            driver.FindElement(By.Id("form_fname")).SendKeys("john");

            //add last name
            driver.FindElement(By.Id("form_lname")).SendKeys("wick");

            //update DOB
            driver.FindElement(By.Id("form_DOB")).SendKeys("2022-05=30");

            //update gnder
            SelectElement selectGen = new SelectElement(driver.FindElement(By.Id("form_sex")));
            selectGen.SelectByText("Female");

            //click on create new patient
            driver.FindElement(By.Id("create")).Click();



        }
    }
}
