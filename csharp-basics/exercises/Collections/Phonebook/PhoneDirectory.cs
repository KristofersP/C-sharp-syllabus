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

            if (_data.ContainsKey(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
            }
        }
    }
}