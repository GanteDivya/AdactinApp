using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AdactinApp.TestDataAccess;
using AdactinApp.Extenions;


namespace AdactinApp.PageObjects
{
    class Loginpage
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        private IWebElement uname { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]

        private IWebElement pwd { get; set; }
        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]

        private IWebElement loginbtn { get; set; }


        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginAction()
        {
            //var userData = ExcelDataAccess.GetTestData(testName);
            //uname.SendKeys(userData.Username);
            //pwd.SendKeys("userData.Password");
            uname.EnterText("vasuvespag","username");
            pwd.EnterText("vasu1234","password");
            loginbtn.ClickOnIt("loginbutton");
        }



    }
}
