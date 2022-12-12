using System;
using NUnit.Framework;

namespace NordVPN.TESTS
{
    public class CompleteTest : BaseTests
    {
        [Test]
        public static void TestOptionComplete()
        {

            string text = "Complete plan";

            _completePage.NavigateToDefaultPage();
            _completePage.GetNordVPN();
            _completePage.AYearPlanClick();
            _completePage.CompleteClick();
            _completePage.VerifyComplete(text);

        }
    }
}

