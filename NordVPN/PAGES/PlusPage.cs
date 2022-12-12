using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NordVPN.PAGES
{
    public class PlusPage : BasePage
    {
        private IWebElement _choosePlus => Driver.FindElement(By.XPath("(//a[@aria-label='Get Plus'][normalize-space()='Get Plus'])[3]"));

        private IWebElement _verifyPlus => Driver.FindElement(By.XPath("(//span[normalize-space()='Plus plan'])[1]"));

        public PlusPage(IWebDriver webDriver) : base(webDriver) { }

        public void PlusClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _choosePlus.Click();
        }

        public void VerifyPlus(string expectedText)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.That(_verifyPlus.Text, Is.EqualTo(expectedText), "Answer is wrong!");
        }
    } 
}

