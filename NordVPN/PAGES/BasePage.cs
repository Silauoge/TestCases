using System;
using OpenQA.Selenium;

namespace NordVPN.PAGES
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private const string PageAddress = "https://nordvpn.com/";

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        private IWebElement _clickGetNordVPN => Driver.FindElement(By.CssSelector("#js-HeaderV3__mini-nav > li:nth-child(1) > a"));

        public void GetNordVPN()
        {
            _clickGetNordVPN.Click();
        }

        private IWebElement _chooseAYearPlan => Driver.FindElement(By.CssSelector("#pricing > span > div > div.col-xs-12 > div > div > ul > li:nth-child(2) > a"));
                                                                                    

        public void AYearPlanClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _chooseAYearPlan.Click();
        }

    }
}

