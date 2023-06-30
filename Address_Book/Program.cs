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
            AddressBookOperations addressbook = new AddressBookOperations();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option \n1. Add Contact\n 2. Edit Contact\n 3. Delete Contact\n 4.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number of Address book you want to add");
                        int N = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            addressbook.AddToDict();
                        }
                        addressbook.DisplayData();
                        break;
                    case 2:
                        Console.WriteLine("Enter UniqueName");
                        string unique = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        addressbook.Edit(name, unique);
                        break;
                    case 3:
                        Console.WriteLine("Enter UniqueName");
                        string unique1 = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        string name1 = Console.ReadLine();
                        addressbook.Delete(name1, unique1);
                        addressbook.DisplayData();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
    
}