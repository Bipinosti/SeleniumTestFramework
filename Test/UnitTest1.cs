using TestFramework;
using NUnit.Framework;
using TestFramework.Common;

namespace Test
{
    [TestFixture]
    public class UnitTest1 : TestBase
    {
        [Test]
        public void CanAccessCountry()
        {
            ExplicitWait.WaitId("image-1022");
            Browser.Goto("#country");
            ExplicitWait.WaitName("code");
            Pages.Country.CanTestCode();
        }

    }
}

