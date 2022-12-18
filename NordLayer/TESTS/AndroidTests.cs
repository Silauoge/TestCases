using System;
using NUnit.Framework;

namespace NordLayer.TESTS
{
    public class AndroidTests : BaseTests
    {
        [Test]
        public static void TestDownloadAndroid()
        {

            string text = "Google Play";

            _androidPage.NavigateToDefaultPage();
            _androidPage.DownloadsClick();
            _androidPage.AndroidClick();
            _androidPage.VerifyAndroid(text);

        }
    }
}

