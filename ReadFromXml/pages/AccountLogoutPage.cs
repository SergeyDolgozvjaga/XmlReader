using OpenQA.Selenium;

namespace ReadFromXml.pages
{
    public class AccountLogoutPage
    {
        XmlParser parser;

        public AccountLogoutPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Account_logout_page").InnerText;
        }

        public string ButtonContinueLogout()
        {
            return parser.LoadFileFindElementsTableAccountPageXPath().SelectSingleNode("Button_Continue_Logout").InnerText;
        }
    }
}
