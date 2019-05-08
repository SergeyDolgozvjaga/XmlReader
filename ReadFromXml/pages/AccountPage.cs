using OpenQA.Selenium;
using System;

namespace ReadFromXml.pages
{
    public class AccountPage
    {
        XmlParser parser;

        public AccountPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Account_page").InnerText;
        }

        public string GetSucessPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Account_sucess_page").InnerText;
        }

        public string ButtonLogout()
        {
            return parser.LoadFileFindElementsTableAccountPageXPath().SelectSingleNode("Button_Logout").InnerText;
        }

        public string ButtonPassword()
        {
            return parser.LoadFileFindElementsTableAccountPageXPath().SelectSingleNode("Button_Password").InnerText;
        }

        public string ButtonMyAccount()
        {
            return parser.LoadFileFindElementsTableAccountPageXPath().SelectSingleNode("Button_My_account").InnerText;
        }
    }
}
