using System;
namespace Telephone1
{
    class Telephone
    {
        protected string _phonetype;
        public string phonetype
        {
            get
            {
                return _phonetype;
            }
            set { _phonetype = value; }
        }
        public Telephone()
        {

        }

        public Telephone(string PhType)
        {
            _phonetype = PhType;
        }
        public void Ring()
        {
            Console.WriteLine($"Ringing the {_phonetype}");
        }
        class ElectronicPhone : Telephone
        {
            public ElectronicPhone()
            {
                _phonetype = "Digital";

            }
            public void Run()
            {
                base.Ring();
            }
        }
        public class Program
        {

            static void Main(string[] args)
            {
                ElectronicPhone phone = new ElectronicPhone();
                phone.Run();
            }
        }

    }
}



