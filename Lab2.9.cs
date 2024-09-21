// Write a program to demonstrate different types of property in C#.
/*using System;
namespace LAB
{
    class Person
    {
        private string location;
        private string name = "Mamata Khanal";
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                if (value == "Mamata")
                    name = value;
            }
        }
    }
    class Properties
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // set accessor will invoke
            p.Name = "Madan";
            // set accessor will invoke
            p.Location = "Kathmandu";
            // get accessor will invoke
            Console.WriteLine("Name: " + p.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + p.Location);
            Console.ReadLine();
        }
    }
}*/