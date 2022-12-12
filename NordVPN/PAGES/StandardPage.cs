using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordVPN.PAGES
{
    public class StandardPage : BasePage
    {
        private IWebElement _chooseStandard => Driver.FindElement(By.XPath("(//a[@aria-label='Get Standard'][normalize-space()='Get Standard'])[3]"));

        private IWebElement _verifyStandard => Driver.FindElement(By.XPath("(//span[normalize-space()='Standard plan'])[1]"));

        public StandardPage(IWebDriver webDriver) : base(webDriver) { }

        public void StandardClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _chooseStandard.Click();
        }

        public void VerifyStandard(string expectedText)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.That(_verifyStandard.Text, Is.EqualTo(expectedText), "Answer is wrong!");
        }
    }
}

