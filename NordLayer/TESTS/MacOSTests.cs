using System;
using NUnit.Framework;

namespace NordLayer.TESTS
{
    public class MacOSTests : BaseTests
    {
        [Test]
        public static void TestDownloadMacOS()
        {

            string text = "Mac App Store";

            _macOSPage.NavigateToDefaultPage();
            _macOSPage.DownloadsClick();
            _macOSPage.MacOSClick();
            _macOSPage.VerifyMacOS(text);

        }
    }
}

