using NUnit.Framework;
using ReadFromXml;
using ReadFromXml.pages;
using ReadFromXml.users;

namespace ReadFromXmlTest
{
    [TestFixture]
    public class RegisterPageTest
    {
        Driver drive;
        RegisterPage registerPage;
        LoginPage loginPage;
        StartPage startPage;
        User1 user;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
            registerPage = new RegisterPage();
            loginPage = new LoginPage();
            startPage = new StartPage();
            user = new User1();
        }

        [Test]
        public void From_RegisterPage_To_LoginPage_Using_LinkButton_Test()
        {
            // Arrange
            string expectedURL = loginPage.GetPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(registerPage.GetPageURL());
            drive.FindElementByXPath(registerPage.ButtonLoginPage()).Click();
            actualURL = drive.GetURL();

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void Registration_Confirm_Test()
        {
            // Arrange
            string expectedURL = new AccountPage().GetSucessPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonRegister()).Click();
            drive.FindElementByIdAndInputData(registerPage.Firstname()).SendKeys(user.Firstname);
            drive.FindElementByIdAndInputData(registerPage.LastName()).SendKeys(user.Lastname);
            drive.FindElementByIdAndInputData(registerPage.Email()).SendKeys(user.Email);
            drive.FindElementByIdAndInputData(registerPage.Telephone()).SendKeys(user.Telephone);
            drive.FindElementByIdAndInputData(registerPage.Fax()).SendKeys(user.Fax);
            drive.FindElementByIdAndInputData(registerPage.Company()).SendKeys(user.Company);
            drive.FindElementByIdAndInputData(registerPage.Address1()).SendKeys(user.Address1);
            drive.FindElementByIdAndInputData(registerPage.Address2()).SendKeys(user.Address2);
            drive.FindElementByIdAndInputData(registerPage.City()).SendKeys(user.City);
            drive.FindElementByIdAndInputData(registerPage.Postcode()).SendKeys(user.Postcode);
            drive.FindElementByIdAndSelectIt(registerPage.Region()).SelectByText(user.Region);
            drive.FindElementByIdAndInputData(registerPage.Password()).SendKeys(user.Password);
            drive.FindElementByIdAndInputData(registerPage.PasswordConfirm()).SendKeys(user.Password);
            drive.FindElementByName(registerPage.CheckboxConfirm()).Click();
            drive.FindElementByXPath(registerPage.ButtonContinue()).Click();
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
