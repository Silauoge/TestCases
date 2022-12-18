using System;
using NordLayer.PAGES;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NordLayer
{
    public class BaseTests
    {
        protected static IWebDriver Driver;

        public static IOSPage _iosPage;
        public static AndroidPage _androidPage;
        public static MacOSPage _macOSPage;
        public static WindowsPage _windowsPage;
        public static LinuxPage _linuxPage;

        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _iosPage = new IOSPage(Driver);
            _androidPage = new AndroidPage(Driver);
            _macOSPage = new MacOSPage(Driver);
            _windowsPage = new WindowsPage(Driver);
            _linuxPage = new LinuxPage(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Close();
        }
    }
}

