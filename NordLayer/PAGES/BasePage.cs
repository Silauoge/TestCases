using System;
using OpenQA.Selenium;

namespace NordLayer
{
    public class BasePage
    {
        
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;

        }

        private const string PageAddress = "https://nordlayer.com/";

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        private IWebElement _clickDownloads => Driver.FindElement(By.CssSelector("#gatsby-focus-wrapper > div > div:nth-child(1) > header > div > div > div > div > nav > a:nth-child(3) > div"));

        public void DownloadsClick()
        {
            _clickDownloads.Click();
        }

    }
}

