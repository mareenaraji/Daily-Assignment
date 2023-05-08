using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq2
{
    class Member
    {
        private static List<Member> memberList = new List<Member>();

        private long _id;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        private string _firstName;

        public string FirstName

        {

            get { return _firstName; }

            set { _firstName = value; }

        }

        private string _lastName;

        public string LastName

        {

            get { return _lastName; }

            set { _lastName = value; }

        }

        private string _email;

        public string Email

        {

            get { return _email; }

            set { _email = value; }

        }

        private string _contactNumber;

        public string ContactNumber

        {

            get { return _contactNumber; }

            set { _contactNumber = value; }

        }

        private string _licenseNumber;

        public string LicenseNumber

        {

            get { return _licenseNumber; }

            set { _licenseNumber = value; }

        }

        private DateTime _licenseStartDate;

        public DateTime LicenseStartDate

        {

            get { return _licenseStartDate; }

            set { _licenseStartDate = value; }

        }

        private DateTime _licenseExpiryDate;

        public DateTime LicenseExpiryDate

        {

            get { return _licenseExpiryDate; }

            set { _licenseExpiryDate = value; }

        }

        private List<MemberCar> _carList = new List<MemberCar>();

        public List<MemberCar> CarList

        {

            get { return _carList; }

            set { _carList = value; }

        }

        public Member()

        {

            _carList = new List<MemberCar>();

        }

        public Member(long id, string firstName, 
            string lastName, string email, 
            string contactNumber, string licenseNumber, 
            DateTime licenseStartDate, 
            DateTime licenseExpiryDate)

        {

            Id = id;

            FirstName = firstName;

            LastName = lastName;

            Email = email;

            ContactNumber = contactNumber;

            LicenseNumber = licenseNumber;

            LicenseStartDate = licenseStartDate;

            LicenseExpiryDate = licenseExpiryDate;

        }

        public static Member FindMember(ArrayList memberList, long Id)

        {
            Member m = null;
            foreach (Object member in memberList)

            {
                if(member is Member)
                {
                    m = (Member)member;
                }

                if (m.Id == Id)
                {
                    return m;
                }
            }
            return m;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}

