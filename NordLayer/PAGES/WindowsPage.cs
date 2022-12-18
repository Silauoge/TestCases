using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordLayer.PAGES
{
    public class WindowsPage : BasePage
    {
        private IWebElement _clickWindows => Driver.FindElement(By.CssSelector("#submenu-item-3 > a > div > span"));

        private IWebElement _verifyWindows => Driver.FindElement(By.CssSelector("#gatsby-focus-wrapper > div > div > main > div.bg-grey-shark.headerPad.ie-height-100 > div.nord-container.container.mb-6.md\\:mt-6.mt-5.pt-4.md\\:pt-0 > div > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > div > div > a"));

        public WindowsPage(IWebDriver webDriver) : base(webDriver) { }

        public void WindowsClick()
        {
            _clickWindows.Click();
        }

        public void VerifyWindows(string expectedText)
        {
            Assert.That(_verifyWindows.Text, Is.EqualTo(expectedText), "Answer is wrong!");
        }
    }
}

