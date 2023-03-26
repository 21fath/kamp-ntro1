using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] İsimler = new string[] { "Ahmet", "Mehmet", "Ayşe", "Murat" };
            //Console.WriteLine(İsimler[0]);
            //Console.WriteLine(İsimler[1]);
            //Console.WriteLine(İsimler[2]);
            //Console.WriteLine(İsimler[3]);

            //İsimler = new string[5];
            //İsimler[4] = "İlker";
            //Console.WriteLine(İsimler[4]);
            //Console.WriteLine(İsimler[0]);

            List<string> İsimler2 = new List<string> { "Ahmet", "Mehmet", "Ayşe", "Murat" };
            Console.WriteLine(İsimler2[0]);
            Console.WriteLine(İsimler2[1]);
            Console.WriteLine(İsimler2[2]);
            Console.WriteLine(İsimler2[3]);
            İsimler2.Add("Fatih");
            Console.WriteLine(İsimler2[4]);
            Console.WriteLine(İsimler2[0]);


        }
    }
}
