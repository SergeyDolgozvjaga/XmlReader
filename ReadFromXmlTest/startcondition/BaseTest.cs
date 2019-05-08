using NUnit.Framework;
using ReadFromXml;

namespace ReadFromXmlTest
{
    [TestFixture]
    public class BaseTest
    {
        Driver drive;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            drive.Close();
        }
    }
}
