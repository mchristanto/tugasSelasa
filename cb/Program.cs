using System;
using System.Linq;
using System.Collections.Generic;
namespace cb
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("INPUT KALIMAT   :");
            var kalimat = Console.ReadLine();
            if (kalimat.Length <= 3)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                    
            }
            Console.Write("INPUT KATA      :");
            var kata = Console.ReadLine();
            if (kata.Length <= 1)
            {
                Console.WriteLine("HURUF PADA KATA KURANG PANJANG");
            }
            Console.WriteLine("OUTPUT          :");
            Console.Write("STATISTIK HURUF :");
           
        }
    }
}
