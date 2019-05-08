using System;

namespace ReadFromXml.users
{
    public class User1
    {
        private User1Data data;

        private string firstname;
        private string lastname;
        private string email;
        private string telephone;
        private string fax;
        private string company;
        private string address1;
        private string address2;
        private string city;
        private string postcode;
        private string country;
        private string region;
        private string password;

        public User1()
        {
            data = new User1Data();
        }

        public string Firstname
        {
            set
            {
                firstname = data.GetFirstName();             
            }
            get { return firstname; }
        }

        public string Lastname
        {
            set
            {
                lastname = data.GetLastName();
            }
            get { return lastname; }
        }

        public string Email
        {
            set
            {
                email = data.GetEmail();
            }
            get { return email; }
        }

        public string Telephone
        {
            set
            {
                telephone = data.GetTelephone();
            }
            get { return telephone; }
        }

        public string Fax
        {
            set
            {
                fax = data.GetFax();
            }
            get { return fax; }
        }

        public string Company
        {
            set
            {
                company = data.GetCompany();
            }
            get { return company; }
        }

        public string Address1
        {
            set
            {
                address1 = data.GetAddress1();
            }
            get { return address1; }
        }

        public string Address2
        {
            set
            {
                address2 = data.GetAddress2();
            }
            get { return address2; }
        }

        public string City
        {
            set
            {
                city = data.GetCity();
            }
            get { return city; }
        }
        public string Postcode
        {
            set
            {
                postcode = data.GetPostcode();
            }
            get { return postcode; }
        }

        public string Country
        {
            set
            {
                country = data.GetCountry();
            }
            get { return country; }
        }

        public string Region
        {
            set
            {
                region = data.GetRegion();
            }
            get { return region; }
        }

        public string Password
        {
            set
            {
                password = data.GetPassword();
            }
            get { return password; }
        }
    }
}
