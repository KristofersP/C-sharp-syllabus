using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory() {
            _data = new SortedDictionary<string, string>();
        }

        private string Find(string name) 
        {
            foreach (KeyValuePair<string, string> pair in _data)
            {
                if(pair.Key == name)
                {
                    return pair.Key;
                }
            }

            return null;
        }

        public string GetNumber(string name) 
        {
            foreach (KeyValuePair<string, string> pair in _data)
            {
                if (pair.Key == name)
                {
                    return pair.Value;
                }
            }
            return null;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            foreach (KeyValuePair<string, string> pair in _data)
            {
                if (pair.Key == i)
                {
                    _data.Add(pair.Key, number);
                }
                else
                {
                    var newEntry = new PhoneEntry { name = name, number = number }; // Create a new pair.
                    _data.Add(newEntry.name, newEntry.number);   // Add the new pair to the array.
                }
            }
            
        }
    }
}