using System;
using System.Runtime.ConstrainedExecution;

namespace CarPoolingSystem
{
    class MemberCar
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Member _member;
        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        private car _car;
        public car Car
        {
            get { return _car; }
            set { _car = value; }
        }
        private string _carRegistrationNumber;
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set
            {
                _carRegistrationNumber = value;
            }
        }
        private string _carColor;
        public string CarColor
        {
            get { return _carColor; }
            set
            {
                _carColor = value;
            }
        }
        public MemberCar()
        {

        }
        public MemberCar(long id, Member member, Car car, string carRegistrationNumber, string carcolor,)
        {
            Id = id;
            Member = member;
            Car = car;
            CarRegistrationNumber = carRegistrationNumber;
            CarColor = carcolor;
        }
    }
}