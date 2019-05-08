using OpenQA.Selenium;
using System;

namespace ReadFromXml
{
    public class StartPage
    {
        XmlParser parser;    

        public StartPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Start_page").InnerText;
        }

        public string ButtonLogin()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_Login").InnerText.Replace(" ", "");
        }

        public string ButtonRegister()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_Register").InnerText.Replace(" ", "");
        }

        public string ButtonAddressBook()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_Address_book").InnerText.Replace(" ", "");
        }

        public string ButtonMyAccount()
        {
            return parser.LoadFileFindElementsTableStartPageXPath().SelectSingleNode("Button_My_account").InnerText.Replace(" ", "");
        }
    }
}
