using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordLayer.PAGES
{
    public class MacOSPage : BasePage
    {
        private IWebElement _clickMacOS => Driver.FindElement(By.CssSelector("#submenu-item-2 > a > div > span"));

        private IWebElement _verifyMacOS => Driver.FindElement(By.CssSelector("#gatsby-focus-wrapper > div > div > main > div.bg-grey-shark.headerPad.ie-height-100 > div.nord-container.container.mb-6.md\\:mt-6.mt-5.pt-4.md\\:pt-0 > div > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > div > a.inline-block.hover\\:opacity-75.md\\:pr-5.Link.Link--blue.font-medium > img"));

        public MacOSPage(IWebDriver webDriver) : base(webDriver) { }



        public void MacOSClick()
        {
            _clickMacOS.Click();
        }

        public void VerifyMacOS(string expectedText)
        {
            string _MacOS = _verifyMacOS.GetAttribute("alt");

            Assert.That(_MacOS, Is.EqualTo(expectedText), "Answer is wrong!");

        }
    }
}

