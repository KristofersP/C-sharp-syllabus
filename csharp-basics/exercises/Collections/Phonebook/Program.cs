using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        public static void Main(string[] args)
        {
            PhoneDirectory book = new PhoneDirectory();

            book.PutNumber("janis", "123");
            Console.WriteLine(book.GetNumber("janis"));
            book.PutNumber("janis", "1234");
            Console.WriteLine(book.GetNumber("janis"));

            Console.ReadKey();        }
    }
}
