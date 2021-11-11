using System;

namespace AddressBookSystem
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public Double PhoneNumber { get; set; }
        public string Email { get; set; }

        public void displayContact()
        {
            Console.WriteLine("FirstName : " + this.FirstName + "LastName : " + this.LastName + "Address : " + this.Address + "City :" + this.City + "State :" + this.State + "ZipCode : " + this.ZipCode + "PhoneNumber : " + this.PhoneNumber + "Email : " + this.Email);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name, Last Name, Address, City, State, Zip Code, Phone Number, Email \n ");

            Program objProgram = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToInt32(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            objProgram.displayContact();
            Console.ReadKey();
        }
    }
}
