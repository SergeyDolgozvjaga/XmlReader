using System.Xml;

namespace ReadFromXml
{
    public class XmlParser
    {
        // files
        private const string fileUrl = "C:\\Users\\GIGABYTE\\Desktop\\ReadFromXml 2.0\\ReadFromXml\\URL.xml";
        private const string fileFindElements = "C:\\Users\\GIGABYTE\\Desktop\\ReadFromXml 2.0\\ReadFromXml\\FindElements.xml";                                               
        private const string fileUsers = "C:\\Users\\GIGABYTE\\Desktop\\ReadFromXml 2.0\\ReadFromXml\\Users.xml";

        // tables
        private const string fileUrlTableUrl = "/Table/URL";
        private const string fileFindElementsTableStartPageXPath = "/Table/Start_page/XPath";
        private const string fileFindElementsTableLoginPageId = "/Table/Login_page/Id";
        private const string fileFindElementsTableLoginPageXPath = "/Table/Login_page/XPath";
        private const string fileFindElementsTableForgetPaswordPageXPath = "/Table/Forget_password_page/XPath";
        private const string fileFindElementsTableRegisterPageId = "/Table/Register_page/Id";
        private const string fileFindElementsTableRegisterPageName = "/Table/Register_page/Name";
        private const string fileFindElementsTableRegisterPageXPath = "/Table/Register_page/XPath";
        private const string fileFindElementsTableAccountPageXPath = "/Table/Account_page/XPath";
        private const string fileFindElementsTablePasswordEditPageId = "/Table/Password_edit_page/Id";
        private const string fileFindElementsTablePasswordEditPageXPath = "/Table/Password_edit_page/XPath";

        private const string fileUsersTableUser1 = "/Table/Users/User1";
        private const string fileUsersTableUser2 = "/Table/Users/User2";
        private const string fileUsersTableUser3 = "/Table/Users/User3";

        private XmlNode LoadXmlFileAndXmlTable(string file, string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file);
            XmlNode node = xmlDoc.DocumentElement.SelectSingleNode(path);
            return node;
        }

        public XmlNode LoadFileUrlTableUrl()
        {
            return LoadXmlFileAndXmlTable(fileUrl, fileUrlTableUrl);
        }

        public XmlNode LoadFileFindElementsTableStartPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableStartPageXPath);
        }

        public XmlNode LoadFileFindElementsTableLoginPageId()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableLoginPageId);
        }

        public XmlNode LoadFileFindElementsTableLoginPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableLoginPageXPath);
        }

        public XmlNode LoadFileFindElementsTableForgetPasswordPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableForgetPaswordPageXPath);
        }

        public XmlNode LoadFileUsersTableUser1()
        {
            return LoadXmlFileAndXmlTable(fileUsers, fileUsersTableUser1);
        }

        public XmlNode LoadFileUsersTableUser2()
        {
            return LoadXmlFileAndXmlTable(fileUsers, fileUsersTableUser2);
        }

        public XmlNode LoadFileUsersTableUser3()
        {
            return LoadXmlFileAndXmlTable(fileUsers, fileUsersTableUser3);
        }

        public XmlNode LoadFileFindElementsTableRegisterPageId()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableRegisterPageId);
        }

        public XmlNode LoadFileFindElementsTableRegisterPageName()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableRegisterPageName);
        }

        public XmlNode LoadFileFindElementsTableRegisterPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableRegisterPageXPath);
        }

        public XmlNode LoadFileFindElementsTableAccountPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTableAccountPageXPath);
        }

        public XmlNode LoadFileFindElementsTablePasswordEditPageId()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTablePasswordEditPageId);
        }

        public XmlNode LoadFileFindElementsTablePasswordEditPageXPath()
        {
            return LoadXmlFileAndXmlTable(fileFindElements, fileFindElementsTablePasswordEditPageXPath);
        }
    }
}
