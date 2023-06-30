﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddressBookOperations
    {
        Contact contact = new Contact();
        List<Contact> Data = new List<Contact>();
        public void Add()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter zip");
            contact.zip = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email");
            contact.Email = Console.ReadLine();
            Data.Add(contact);
        }

        public void Display()
        {
            foreach (var data in Data)
            {
                Console.WriteLine("First Name :" + data.FirstName + "\n" + "Last Name :" + data.LastName + "\n" + "Address :" + data.Address + "\n" + "City :" + data.City + "\n" + "State :" + data.State + "\n" + "Zip Code :" + data.zip + "\n" + "Phone Number :" + data.PhoneNumber + "\n" + "Mail Id :" + data.Email);
            }
        }
        public void Edit()
        {
            Console.WriteLine("Edit Using First Name");
            string name = Console.ReadLine();
            foreach (var data in Data)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("Select Option to edit Contct details \n 1. Edit First Name \n 2.Edit Last Name \n 3.Edit Address \n 4.Edit City \n 5.Edit State \n 6. Zip \n 7. Edit Phone Number \n 8. Edit Email ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name");
                            data.FirstName = Console.ReadLine();
                            Display();
                            break;
                        case 2:
                            Console.WriteLine("Enter last Name");
                            data.LastName = Console.ReadLine();
                            Display();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address");
                            data.Address = Console.ReadLine();
                            Display();
                            break;
                        case 4:
                            Console.WriteLine("Enter City");
                            data.City = Console.ReadLine();
                            Display();
                            break;
                        case 5:
                            Console.WriteLine("Enter State");
                            data.State = Console.ReadLine();
                            Display();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip Code");
                            data.zip = Console.ReadLine();
                            Display();
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone Number");
                            data.PhoneNumber = Console.ReadLine();
                            Display();
                            break;
                        case 8:
                            Console.WriteLine("Enter Mail Id");
                            data.Email = Console.ReadLine();
                            Display();
                            break;


                    }
                }
            }

        }

        public void Delete()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name To delete Contact");
            string name = Console.ReadLine();
            foreach (var data in Data)
            {
                if (data.FirstName.Equals(name))
                {
                    contact = data;
                }

            }
            Data.Remove(contact);
        }
    }
}
