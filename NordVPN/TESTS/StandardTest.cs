using System;
using NUnit.Framework;

namespace NordVPN.TESTS
{
    public class StandardTest : BaseTests
    {
        [Test]
        public static void TestOptionStandard()
        {

            string text = "Standard plan";

            _standardPage.NavigateToDefaultPage();
            _standardPage.GetNordVPN();
            _standardPage.AYearPlanClick();
            _standardPage.StandardClick();
            _standardPage.VerifyStandard(text);

        }

    }
}

