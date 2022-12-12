using System;
using NordVPN.PAGES;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NordVPN.TESTS
{
    public class BaseTests
    {

        protected static IWebDriver Driver;

        public static CompletePage _completePage;
        public static PlusPage _plusPage;
        public static StandardPage _standardPage;


        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _completePage = new CompletePage(Driver);
            _plusPage = new PlusPage(Driver);
            _standardPage = new StandardPage(Driver);

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Close();
        }

    }
}
