using NUnit.Framework;
using ReadFromXml;

namespace ReadFromXmlTest
{
    [TestFixture]
    public class StartPageTest
    {
        Driver drive;
        StartPage startPage;
        LoginPage loginPage;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
            startPage = new StartPage();
            loginPage = new LoginPage();
        }

        [Test]
        public void StartPage_AddressBook_Click_NotLoginUser_Test()
        {           
            // Arrange
            string expectedURL = loginPage.GetPageURL();
            string actualURL;

            // Act        
            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonAddressBook()).Click();  
            actualURL = drive.GetURL();
            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void StartPage_MyAccount_Click_NotLoginUser_Test()
        {
            // Arrange
            string expectedURL = loginPage.GetPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonMyAccount()).Click();
            actualURL = drive.GetURL();

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [TearDown]
        public void TearDown()
        {
            drive.Close();
        }
    }
}
