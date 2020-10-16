using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    /* Create class Person
     * Parameter: job, yearOfBirth, name, age
     * Method: inputValue(), showValue() use to import and show infor of each person  
     */
    class Person
    {
        protected string job;
        protected int yearOfBirth;
        protected string name;
        protected int age;

        public Person() { }
        public Person(string Name, string Job, int Age, int YearOfBirth)
        {
            name = Name;
            job = Job;
            age = Age;
            yearOfBirth = YearOfBirth;
        }

        public void inputValue()
        {
            Console.WriteLine("ho ten: ");
            name = Console.ReadLine();
            Console.WriteLine("nghe nghiep: ");
            job = Console.ReadLine();
            Console.WriteLine("tuoi: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nam sinh: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());
        }

        public void showValue()
        {
            Console.WriteLine("ho ten: {0}, nghe nghiep: {1}, tuoi: {2}, nam sinh: {3}", name, job, age, yearOfBirth);
        }
    }
}
