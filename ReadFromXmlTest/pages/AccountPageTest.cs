using NUnit.Framework;
using ReadFromXml;
using ReadFromXml.pages;
using ReadFromXml.users;
using System;

namespace ReadFromXmlTest.pages
{

    [TestFixture]
    public class AccountPageTest
    {
        Driver drive;
        User1 user;
        AccountPage accountPage;
        PasswordEditPage passwordEditPage;
        StartPage startPage;
        LoginPage loginPage;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
            user = new User1();
            accountPage = new AccountPage();
            passwordEditPage = new PasswordEditPage();
            startPage = new StartPage();
            loginPage = new LoginPage();

            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonLogin()).Click();
            drive.FindElementByIdAndInputData(loginPage.InputEmail()).SendKeys(user.Email);
            drive.FindElementByIdAndInputData(loginPage.InputPassword()).SendKeys(user.Password);
            drive.FindElementByXPath(loginPage.ButtonLogin()).Click();
        }

        [Test]
        public void MyAccount_Button_Click_Test()
        {
            // Arrange
            string expected = accountPage.GetPageURL();
            string actual;

            // Act
            drive.FindElementByXPath(accountPage.ButtonMyAccount()).Click();
            actual = drive.GetURL();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Back_Button_Test()
        {
            // Arrange
            string expected = accountPage.GetPageURL();
            string actual;

            // Act
            drive.FindElementByXPath(accountPage.ButtonPassword()).Click();
            drive.FindElementByXPath(passwordEditPage.ButtonBack()).Click();
            actual = drive.GetURL();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Password_Button_Click_And_Button_Continue_Click_Test()
        {
            // Arrange
            string expected = accountPage.GetPageURL();
            string actual;

            // Act
            drive.FindElementByXPath(accountPage.ButtonPassword()).Click();
            drive.FindElementByIdAndInputData(passwordEditPage.InputPassword()).SendKeys(user.Password);
            drive.FindElementByIdAndInputData(passwordEditPage.InputPasswordConfirm()).SendKeys(user.Password);
            drive.FindElementByXPath(passwordEditPage.ButtonContinue()).Click();
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
