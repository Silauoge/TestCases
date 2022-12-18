using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordLayer.PAGES
{
    public class LinuxPage : BasePage
    {
        private IWebElement _clickLinux => Driver.FindElement(By.CssSelector("#submenu-item-4 > a > div > span"));

        private IWebElement _verifyLinuxDEB => Driver.FindElement(By.CssSelector("#LinuxMain > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > div > div > a.min-w-188.min-w\\:288.mb-4.lg\\:mb-0.Button.Button--large.Button--contained.inline-block"));

        private IWebElement _verifyLinuxRPM => Driver.FindElement(By.CssSelector("#LinuxMain > div.nord-col.md\\:col-6.z-1 > div:nth-child(2) > div > div > div > a.min-w-188.min-w\\:288.md\\:mb-0.lg\\:ml-3.Button.Button--large.Button--contained.inline-block"));

        public LinuxPage(IWebDriver webDriver) : base(webDriver) { }

        public void LinuxClick()
        {
            _clickLinux.Click();
        }

        public void VerifyLinuxDEB(string expectedTextDEB)
        {
            Assert.That(_verifyLinuxDEB.Text, Is.EqualTo(expectedTextDEB), "Answer is wrong!");
        }

        public void VerifyLinuxRPM(string expectedTextRPM)
        {
            Assert.That(_verifyLinuxRPM.Text, Is.EqualTo(expectedTextRPM), "Answer is wrong!");
        }
    }
}

