using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    /* Create class Family extend class Person
     * Parameter: numOfPerson(number of person), numOfHouse(number of house)
     * Method: inputInfor(), showInfor() use to import and show infor of each family  
     */
    class Family : Person
    {


        public int numOfPerson, numOfHouse;
        public Person[] list;

        public Family()
        {
            list = new Person[99];
        }

        public Family(string Name, string Job, int Age, int YearOfBirth, int numOfPer, int numOfHou) : base(Name, Job, Age, YearOfBirth)
        {
            numOfPerson = numOfPer;
            numOfHouse = numOfHou;
        }

        public void inputInfor()
        {
            Console.WriteLine("so thanh vien: ");
            numOfPerson = Int32.Parse(Console.ReadLine());
            Console.WriteLine("so nha: ");
            numOfHouse = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap thong tin cho tung nguoi trong ho gia dinh: ");
            for(int i = 0; i < numOfPerson; i++)
            {
                Console.WriteLine("Nguoi thu "+(i+1)+" la ");
                list[i] = new Person();
                list[i].inputValue();
            }
        }

        public void showInfor()
        {
            Console.WriteLine("So thanh vien " + numOfPerson);
            Console.WriteLine("So nha " + numOfHouse);
            for(int i = 0; i < numOfPerson; i++)
            {
                Console.WriteLine("Nguoi thu " + (i + 1) + " la ");
                list[i].showValue();
            }
        }

    }
}
