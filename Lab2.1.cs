/* // Write a C# program to create employee class with name, email and salary field, also create object for employee.
using System;

namespace LAB
{
    // Employee class definition
    public class Employee
    {  
        private string name;
        private string email;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Mamata";
            e.Email = "mamatakhanal@gmail.com";
            e.Salary = 20000;

            //print data using properties
            Console.WriteLine("Name:{0}" ,e.Name);
            Console.WriteLine("Email:{0}" ,e.Email);
            Console.WriteLine("Salary:{0}", e.Salary);
            Console.ReadKey();
        } 
    }
}
*/
