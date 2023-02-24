using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AdactinApp.PageObjects;
using SeleniumExtras.PageObjects;
using System.Configuration;


namespace AdactinApp.Testcases
{
    class LoginTest
    {
        IWebDriver driver;
        [Test]
        public void Test()
        {
            driver = new ChromeDriver();
            //driver.Url = "http://adactinhotelapp.com";
            Console.WriteLine("Started the program");
            var url = ConfigurationManager.AppSettings["URL"];
            driver.Url = url;
            var loginpg = new Loginpage(driver);

            loginpg.LoginAction();
           
           
            var searchpg = new SearchHotelpage(driver);
            searchpg.SearchAction();
            

            //driver.FindElement(By.Id("username")).SendKeys("vasuvespag");
            //driver.FindElement(By.Id("password")).SendKeys("vasu1234");
            //driver.FindElement(By.Id("login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Logout")).Click();

        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Finally Executed");
            driver.Close();
        }
    }
}
