using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book ");
            AddressBookOperations addressBook = new AddressBookOperations();
            addressBook.Add();
            addressBook.Display();
            addressBook.Edit();
        }
    }
}