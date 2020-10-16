using System;
using System.Collections.Generic;

namespace OOP1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Family> ds = new List<Family>();
            
            Console.WriteLine("so ho gia dinh: ");
            int shgd = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cho tung ho dan: ");
            for (int i = 0; i < shgd; i++)
            {
                Console.WriteLine("ho dan so " + (i + 1));
                Family hogiadinh = new Family();
                hogiadinh.inputInfor();
                ds.Add(hogiadinh);
            }

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine("ho dan thu " + (i + 1));
                ds[i].showInfor();
            }


        }
    }
    }

