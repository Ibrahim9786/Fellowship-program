using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2AddressBookSystem
{
    public class NewContact
    {
        string firstName;
        public NewContact(string firstName)
        {
            this.firstName = firstName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }

        public void displayContact()
        {
            Console.WriteLine(" FirstName : " + this.FirstName + " LastName : " + this.LastName + " Address : " + this.Address + " City : " + this.City + " State : " + this.State + " ZipCode : " + this.ZipCode + " Email : " + this.Email);
        }


        public void AddContact()
        {
            Console.WriteLine("Enter First Name , Last Name , Address , City , State , ZipCode, Number , Email \n");
            NewContact objcontact = new NewContact("firstName")



            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            List<NewContact> objList = new List<NewContact>();
            objList.Add(objcontact);
            objcontact.displayContact();
            Console.ReadKey();
        }


    }

}
