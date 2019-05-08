using NUnit.Framework;
using ReadFromXml;
using ReadFromXml.pages;
using ReadFromXml.users;
using System;

namespace ReadFromXmlTest
{
    [TestFixture]
    public class LoginPageTest
    {
        Driver drive;
        StartPage startPage;
        LoginPage loginPage;
        User1 user;

        [SetUp]
        public void SetUp()
        {
            drive = new Driver();
            drive.SetUpChromeDriver();
            startPage = new StartPage();
            loginPage = new LoginPage();
            user = new User1();
        }

        [Test]
        public void LoginPage_To_RegisterPage_Test()
        {
            // Arrange
            string expectedURL = new RegisterPage().GetPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(loginPage.GetPageURL());
            drive.FindElementByXPath(loginPage.ButtonContinue()).Click();
            actualURL = drive.GetURL();

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void LoginPage_Button_ForgetPassword_Click_And_Button_Back_Click_Test()
        {
            // Arrange
            string expectedURL = loginPage.GetPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(loginPage.GetPageURL());
            drive.FindElementByXPath(loginPage.ButtonForgottenPassword()).Click();
            drive.FindElementByXPath(new ForgetPasswordPage().ButtonBack()).Click();
            actualURL = drive.GetURL();

            // Assert
            Assert.AreEqual(expectedURL, actualURL);
        }

        [Test]
        public void Login_Confirm_Test()
        {
            // Arrange user1.Password
            string expectedURL = new AccountPage().GetPageURL();
            string actualURL;

            // Act
            drive.NavigatePage(startPage.GetPageURL());
            drive.FindElementByXPath(startPage.ButtonLogin()).Click();
            drive.FindElementByIdAndInputData(loginPage.InputEmail()).SendKeys(user.Email);
            drive.FindElementByIdAndInputData(loginPage.InputPassword()).SendKeys(user.Password);
            drive.FindElementByXPath(loginPage.ButtonLogin()).Click();
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
