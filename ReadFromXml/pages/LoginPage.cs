using OpenQA.Selenium;
using System;

namespace ReadFromXml
{
    public class LoginPage
    {
        XmlParser parser;

        public LoginPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Login_page").InnerText;
        }

        public string InputEmail()
        {
            return parser.LoadFileFindElementsTableLoginPageId().SelectSingleNode("email").InnerText;
        }

        public string InputPassword()
        {
            return parser.LoadFileFindElementsTableLoginPageId().SelectSingleNode("password").InnerText;
        }

        public string ButtonLogin()
        {
            return parser.LoadFileFindElementsTableLoginPageXPath().SelectSingleNode("Button_Login").InnerText;
        }

        public string ButtonContinue()
        {
            return parser.LoadFileFindElementsTableLoginPageXPath().SelectSingleNode("Button_Continue").InnerText;
        }

        public string ButtonForgottenPassword()
        {
            return parser.LoadFileFindElementsTableLoginPageXPath().SelectSingleNode("Button_Forgotten_password").InnerText;
        }
    }
}
