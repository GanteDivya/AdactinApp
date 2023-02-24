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
namespace AdactinApp.PageObjects
{
    class SearchHotelpage
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "location")]
        [CacheLookup]
        public SelectElement locn { get; set; }
        [FindsBy(How = How.Id, Using = "hotels")]
        [CacheLookup]
        public SelectElement hotel { get; set; }
        [FindsBy(How = How.Id, Using = "room_type")]
        [CacheLookup]
        public SelectElement room { get; set; }
        [FindsBy(How = How.Id, Using = "room_nos")]
        [CacheLookup]
        public SelectElement  roomno{ get; set; }
        [FindsBy(How = How.Id, Using = "datepick_in")]
        [CacheLookup]

        public IWebElement checkin { get; set; }
        [FindsBy(How = How.Id, Using = "datepick_out")]
        [CacheLookup]

        public IWebElement checkout { get; set; }
        [FindsBy(How = How.Id, Using = "adult_room")]
        [CacheLookup]

        public SelectElement adultroom { get; set; }
        [FindsBy(How = How.Id, Using = "child_room")]
        [CacheLookup]

        public SelectElement childroom { get; set; }
        [FindsBy(How = How.Id, Using = "Submit")]
        [CacheLookup]

        public IWebElement searchbtn { get; set; }

        public SearchHotelpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SearchAction()
        {
            locn.SelectByIndex(2);
            hotel.SelectByIndex(2);
            room.SelectByIndex(2);
            roomno.SelectByIndex(2);
            checkin.SendKeys("14/02/2023");
            checkout.SendKeys("15/02/2023");
            adultroom.SelectByIndex(2);
            childroom.SelectByIndex(2);
            searchbtn.Click();

        }





    }
}
