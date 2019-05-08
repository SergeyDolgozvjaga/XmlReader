using NUnit.Framework;
using ReadFromXml;
using ReadFromXml.pages;
using ReadFromXml.users;

namespace ReadFromXmlTest.pages
{
    [TestFixture]
    public class AccountLogoutPageTest
    {
        StartPage startPage;
        LoginPage loginPage;
        User1 user;
        Driver drive;
        HomePage homePage;
        AccountPage accountPage;
        AccountLogoutPage accountLogoutPage;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
            startPage = new StartPage();
            loginPage = new LoginPage();
            user = new User1();
            homePage = new HomePage();
            accountPage = new AccountPage();
            accountLogoutPage = new AccountLogoutPage();
        }

        [Test]
        public void Logout_To_HomePage_Test()
        {
            // Arrange
            string expected = homePage.GetPageURL();
            string actual;

            // Act
            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonLogin()).Click();
            drive.FindElementByIdAndInputData(loginPage.InputEmail()).SendKeys(user.Email);
            drive.FindElementByIdAndInputData(loginPage.InputPassword()).SendKeys(user.Password);
            drive.FindElementByXPath(loginPage.ButtonLogin()).Click();
            drive.FindElementByXPath(accountPage.ButtonLogout()).Click();
            drive.FindElementByXPath(accountLogoutPage.ButtonContinueLogout()).Click();
            actual = drive.GetURL();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            drive.Close();
        }
    }
}
