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
    internal class GotoWeb
    {
        public static void Main88(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.goto.com/meeting";

            //click on accecpt recomended
            driver.FindElement(By.Id("truste - consent - button")).Click();

            //click on try free
            driver.FindElement(By.XPath("//a[@class ='go-button go-button--secondary go-button--large']")).Click();

            //enter firstname as john

            driver.FindElement(By.Id("first - name")).SendKeys("john");

            //enter lastname as wick
            driver.FindElement(By.Id("last-name")).SendKeys("wick");

            //enter the mail
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");

            //company size
            SelectElement selectSize = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            selectSize.SelectByText("10-99");

            //click on signup

             driver.FindElement(By.XPath("//button[@class='common - button__button']")).Click();
        }
    }
}
