using System;
using NUnit.Framework;

namespace NordLayer
{
    class IOSTests : BaseTests
    {

        [Test]
        public static void TestDownloadiOS()
        {

            string text = "App Store";

            _iosPage.NavigateToDefaultPage();
            _iosPage.DownloadsClick();
            _iosPage.IOSClick();
            _iosPage.VerifyiOS(text);

        }
    }
}
