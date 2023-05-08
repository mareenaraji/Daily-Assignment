using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem
{
    internal class Member
    {
        private long _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _contactNumber;
        private string _licensenumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;
        private DateTime licensestart;
        private DateTime licenseend;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }
        public string LicenseNumber
        {
            get { return _licensenumber; }
            set
            {
                _licensenumber = value;
            }
        }
        public DateTime LicenseStartDate
        {
            get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
                get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            }
        }
        public Member()
        {

        }
        public Member(long id, string firstname, string lastname, string email, 
            string contactNumber, string licensenumber, DateTime licenseStartDate, DateTime licenseExpiryDate)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            ContactNumber = contactNumber;
            LicenseNumber = licensenumber;
            LicenseStartDate = licenseStartDate;
            LicenseExpiryDate = licenseExpiryDate;
        }

        public Member(int id, string firstname, string lastname, string email, string licensenumber, DateTime licensestart, DateTime licenseend)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            LicenseNumber = licensenumber;
            this.licensestart = licensestart;
            this.licenseend = licenseend;
        }

        public override string ToString()
        {
            return String.Format($"Member:{_firstname},{_lastname}\n" +
                $"Member contact details:{_contactNumber},{_email}");
        }
        public override bool Equals(object obj)
        {
            Member member=obj as Member;
            if (Email.ToLower() == member.Email.ToLower() && ContactNumber.ToLower() == member.ContactNumber.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
