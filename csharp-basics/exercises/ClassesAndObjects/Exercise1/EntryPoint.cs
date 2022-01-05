using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class EntryPoint
    {
        public static void Main()
        {
            Product logitechMouse = new Product("Logitech mouse", 70.00, 14);
            Product iPhone5s = new Product("iPhone 5s", 999.99, 3);
            Product epsonEB_U05 = new Product("Epson EB-U05", 440.46, 1);
           
            logitechMouse.PrintProduct();
            iPhone5s.PrintProduct();
            epsonEB_U05.PrintProduct();

            logitechMouse.ChangeAmount(13);
            logitechMouse.PrintProduct();

            iPhone5s.ChangePrice(550.50);
            iPhone5s.PrintProduct();
        }
    }
}
