﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contacts
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
    }
}
