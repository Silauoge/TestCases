using System;
using NUnit.Framework;

namespace NordLayer.TESTS
{
    public class LinuxTests : BaseTests
    {
        [Test]
        public static void TestDownloadLinux()
        {

            string text = "Download .deb";
            string textnext = "Download .rpm";

            _linuxPage.NavigateToDefaultPage();
            _linuxPage.DownloadsClick();
            _linuxPage.LinuxClick();
            _linuxPage.VerifyLinuxDEB(text);
            _linuxPage.VerifyLinuxRPM(textnext);

        }
    }
}

