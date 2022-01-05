using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;
        
        public void PrintBase()
        {
            Console.WriteLine("Name: " + _firstName);
            Console.WriteLine("Lastname: " + _lastName);
            Console.WriteLine("Address: " + _address);
            Console.WriteLine("ID: " + _id);
        }

        public string FirstName 
        {
            get { return _firstName; } 
            set { _firstName = value; } 
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(value > 0)
                {
                    _id = value;
                }
                else
                {
                    _id = value * -1;
                }
            }
        }
    }
}
