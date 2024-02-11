using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maske takip uygulamsına hoşgeldiniz...");
            Person person1 = new Person();
            Console.Write("isim:");
            person1.FirstName =Console.ReadLine();
            Console.Write("Soyisim:");
            person1.LastName = Console.ReadLine();
            Console.Write("Doğum yılı:");
            person1.DateOfBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kimlik no:");
            person1.NationalIdentity = Convert.ToInt64(Console.ReadLine());

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

      
       
        

    }
}