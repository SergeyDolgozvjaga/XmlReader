using System;

namespace ReadFromXml.pages
{
    public class HomePage
    {
        XmlParser parser;

        public HomePage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Home_page").InnerText;
        }
    }
}
