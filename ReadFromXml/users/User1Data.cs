using System;

namespace ReadFromXml.users
{
    public class User1Data : IUserData
    {
        XmlParser parser;

        public User1Data()
        {
            parser = new XmlParser();
        }

        public string GetFirstName()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("firstname").InnerText.Replace(" ", "");
        }

        public string GetLastName()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("lastname").InnerText.Replace(" ", "");
        }

        public string GetEmail()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("email").InnerText.Replace(" ", "");
        }

        public string GetTelephone()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("telephone").InnerText.Replace(" ", "");
        }

        public string GetFax()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("fax").InnerText.Replace(" ", "");
        }

        public string GetCompany()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("company").InnerText.Replace(" ", "");
        }

        public string GetAddress1()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("address1").InnerText.Replace(" ", "");
        }

        public string GetAddress2()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("address2").InnerText.Replace(" ", "");
        }

        public string GetCity()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("city").InnerText.Replace(" ", "");
        }

        public string GetPostcode()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("postcode").InnerText.Replace(" ", "");
        }

        public string GetCountry()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("country").InnerText;
        }

        public string GetRegion()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("region").InnerText.Replace(" ", "");
        }

        public string GetPassword()
        {
            return parser.LoadFileUsersTableUser1().SelectSingleNode("password").InnerText.Replace(" ", "");
        }
    }
}
