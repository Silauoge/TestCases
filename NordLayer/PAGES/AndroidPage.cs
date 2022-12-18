using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordLayer.PAGES
{
    public class AndroidPage : BasePage
    {


        private IWebElement _clickAndroid => Driver.FindElement(By.CssSelector("#submenu-item-1 > a > div > span"));

        private IWebElement _verifyAndroid => Driver.FindElement(By.CssSelector("#gatsby-focus-wrapper > div > div > main > div.bg-grey-shark.headerPad.ie-height-100 > div.nord-container.container.mb-6.md\\:mt-6.mt-5.pt-4.md\\:pt-0 > div > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > div > a.inline-block.hover\\:opacity-75.md\\:pr-5.Link.Link--blue.font-medium > img"));

        public AndroidPage(IWebDriver webDriver) : base(webDriver) { }



        public void AndroidClick()
        {
            _clickAndroid.Click();
        }

        public void VerifyAndroid(string expectedText)
        {
            string _Android = _verifyAndroid.GetAttribute("alt");

            Assert.That(_Android, Is.EqualTo(expectedText), "Answer is wrong!");

        }
    }
}