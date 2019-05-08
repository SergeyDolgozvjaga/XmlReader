using OpenQA.Selenium;
using System;

namespace ReadFromXml.pages
{
    public class PasswordEditPage
    {
        XmlParser parser;

        public PasswordEditPage()
        {
            parser = new XmlParser();
        }

        public string InputPassword()
        {
            return parser.LoadFileFindElementsTablePasswordEditPageId().SelectSingleNode("password").InnerText;
        }

        public string InputPasswordConfirm()
        {
            return parser.LoadFileFindElementsTablePasswordEditPageId().SelectSingleNode("password_confirm").InnerText;
        }

        public string ButtonBack()
        {
            return parser.LoadFileFindElementsTablePasswordEditPageXPath().SelectSingleNode("Button_Back").InnerText;
        }

        public string ButtonContinue()
        {
            return parser.LoadFileFindElementsTablePasswordEditPageXPath().SelectSingleNode("Button_Continue").InnerText;
        }
    }
}
