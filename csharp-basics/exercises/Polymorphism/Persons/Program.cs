using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Dave";
            employee.LastName = "Davidson";
            employee.Address = "Davestreet Avenue 11";
            employee.ID = 1;
            employee.JobTitle = "Baker";
            
            Student student = new Student();
            student.FirstName = "Charles";
            student.LastName = "Charleson";
            student.Address = "Brivibas iela 201";
            student.ID = 2;
            student.Gpa = 70;

            employee.PrintBase();
            employee.DisplayJobTitle();

            student.PrintBase();
            student.DisplayGPA();

            Console.ReadKey();
        }
    }
}