using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NordVPN.PAGES
{
   public class CompletePage : BasePage
    {
        
        private IWebElement _chooseComplete => Driver.FindElement(By.CssSelector("#\\35 3622ab4-1 > div > div.PricingComparisonTable__table-wrapper.nmx-5.nmx-md-0.visible-lg > table > thead > tr:nth-child(2) > th.PricingComparisonTable__special.PricingComparisonTable__special-plan-card.d-flex.align-items-center.justify-content-center.m-auto.bg-bw-1.relative > div > div > a"));

        private IWebElement _verifyComplete => Driver.FindElement(By.CssSelector("#__next > div > main > div > div.nord-container.container.mt-4.md\\:mt-6 > div.PaymentSection_grid__8f0Hg.mt-3 > div.PaymentSection_colRight__E5Fap > div > div > div.CartSummaryBase_selectedCardsContainer__9AMQh.space-y-6 > div > div.flex.items-center.space-x-2 > span > div.flex.items-center.mb-2 > span"));

        public CompletePage(IWebDriver webDriver) : base(webDriver) { }

        public void CompleteClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _chooseComplete.Click();
        }

        public void VerifyComplete(string expectedText)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.That(_verifyComplete.Text, Is.EqualTo(expectedText), "Answer is wrong!");
        }
   
    } 
}

