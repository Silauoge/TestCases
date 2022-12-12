using System;
using NUnit.Framework;

namespace NordVPN.TESTS
{
    public class PlusTest : BaseTests
    {
        [Test]
        public static void TestOptionPlus()
        {

            string text = "Plus plan";

            _plusPage.NavigateToDefaultPage();
            _plusPage.GetNordVPN();
            _plusPage.AYearPlanClick();
            _plusPage.PlusClick();
            _plusPage.VerifyPlus(text);

        }
    }
}

