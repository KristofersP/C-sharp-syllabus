using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Employee : Person
    {
        private string _jobTitle;

        public void DisplayJobTitle()
        {
            Console.WriteLine("Job title: " + _jobTitle);
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }
    }
}
