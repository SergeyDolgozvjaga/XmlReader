using OpenQA.Selenium;
using System;

namespace ReadFromXml.pages
{
    public class ForgetPasswordPage
    {
        XmlParser parser;

        public ForgetPasswordPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Forget_password_page").InnerText;
        }

        public string ButtonBack()
        {
            return parser.LoadFileFindElementsTableForgetPasswordPageXPath().SelectSingleNode("Button_Back").InnerText;
        }

        public string ButtonContinue()
        {
            return parser.LoadFileFindElementsTableForgetPasswordPageXPath().SelectSingleNode("Button_Continue").InnerText;
        }
    }
}
