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
                Console.WriteLine("Select Option \n1. Add Contact\n 2.Edit Contact\n 3.Delete Contact\n 4.Serach using city \n 5.Exit");
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
                        bool f = true;
                        while (f)
                        {
                            Console.WriteLine("Select an Option \n 1.Search using City \n 2.Search using State \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name of city");
                                    string city = Console.ReadLine();
                                    addressbook.SearchByCity(city);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Name of state");
                                    string state = Console.ReadLine();
                                    addressbook.SearchByState(state);
                                    break;
                                case 3:
                                    f = false;
                                    break;
                            }

                        }

                        break;
                    case 5:
                        bool f2 = true;
                        while (f2)
                        {
                            Console.WriteLine("Select an Option \n 1.Data using City \n 2.Data using State \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    addressbook.DisplayCity();
                                    break;
                                case 2:
                                    addressbook.DisplayState();
                                    break;
                                case 3:
                                    f2 = false;
                                    break;
                            }

                        }
                        break;
                    case 6:
                        bool f3 = true;
                        while (f3)
                        {
                            Console.WriteLine("Select an Option \n 1.Get no of Contact by city \n 2..Get no of Contact by city \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name of city");
                                    string cityName = Console.ReadLine();
                                    addressbook.ByCity(cityName);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Name of State");
                                    string stateName = Console.ReadLine();
                                    addressbook.ByState(stateName);
                                    break;
                                case 3:
                                    f3 = false;
                                    break;
                            }

                        }
                        break;
                    case 7:
                        addressbook.SortDict();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
    
}