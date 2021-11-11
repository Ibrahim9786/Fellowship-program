using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewContact newContact = new NewContact("firstName");
            newContact.AddContact();


        }
    }
}
