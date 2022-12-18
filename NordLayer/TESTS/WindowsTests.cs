using System;
using NUnit.Framework;

namespace NordLayer.TESTS
{
    public class WindowsTests : BaseTests
    {
        [Test]
        public static void TestDownloadWindows()
        {

            string text = "Download here";

            _windowsPage.NavigateToDefaultPage();
            _windowsPage.DownloadsClick();
            _windowsPage.WindowsClick();
            _windowsPage.VerifyWindows(text);

        }
    }
}

