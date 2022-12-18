using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordLayer
{

    public class IOSPage : BasePage
    {
        
        private IWebElement _clickiOS => Driver.FindElement(By.CssSelector("#submenu-item-0 > a > div > span"));

        private IWebElement _verifyIOS => Driver.FindElement(By.CssSelector("#gatsby-focus-wrapper > div > div > main > div.bg-grey-shark.headerPad.ie-height-100 > div.nord-container.container.mb-6.md\\:mt-6.mt-5.pt-4.md\\:pt-0 > div > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > a > img"));

        public IOSPage(IWebDriver webDriver) : base(webDriver) { }

        public void IOSClick()
        {
            _clickiOS.Click();
        }

        public void VerifyiOS(string expectedText)
        {
            string _IOS =_verifyIOS.GetAttribute("alt");

            Assert.That(_IOS, Is.EqualTo(expectedText), "Answer is wrong!");
        }


    }
    
}

