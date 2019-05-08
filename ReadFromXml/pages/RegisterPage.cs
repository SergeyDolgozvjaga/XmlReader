
namespace ReadFromXml.pages
{
    public class RegisterPage
    {
        XmlParser parser;

        public RegisterPage()
        {
            parser = new XmlParser();
        }

        public string GetPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Register_page").InnerText;
        }

        public string ButtonLoginPage()
        {
            return parser.LoadFileFindElementsTableRegisterPageXPath().SelectSingleNode("Ref_Button_Login_page").InnerText;
        }

        public string ButtonContinue()
        {
            return parser.LoadFileFindElementsTableRegisterPageXPath().SelectSingleNode("Button_Continue").InnerText;
        }

        public string Firstname()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("firstname").InnerText.Replace(" ", "");
        }

        public string Email()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("email").InnerText.Replace(" ", "");
        }

        public string Password()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("password").InnerText.Replace(" ", "");
        }

        public string PasswordConfirm()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("password_confirm").InnerText.Replace(" ", "");
        }

        public string CheckboxConfirm()
        {
            return parser.LoadFileFindElementsTableRegisterPageName().SelectSingleNode("checkbox_confirm_read_info").InnerText.Replace(" ", "");
        }

        public string LastName()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("lastname").InnerText.Replace(" ", "");
        }

        public string Telephone()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("telephone").InnerText.Replace(" ", "");
        }

        public string Fax()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("fax").InnerText.Replace(" ", "");
        }

        public string Company()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("company").InnerText.Replace(" ", "");
        }

        public string Address1()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("address1").InnerText.Replace(" ", "");
        }

        public string Address2()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("address2").InnerText.Replace(" ", "");
        }

        public string City()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("city").InnerText.Replace(" ", "");
        }

        public string Postcode()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("postcode").InnerText.Replace(" ", "");
        }

        public string GetCountry()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("country").InnerText;
        }

        public string Region()
        {
            return parser.LoadFileFindElementsTableRegisterPageId().SelectSingleNode("region").InnerText.Replace(" ", "");
        }     
    }
}
