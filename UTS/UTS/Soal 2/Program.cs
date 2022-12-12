using System;

namespace Soal_2
{
    class Program
    {
        static int RP;
        static int USD = 15355;

        static void Main(string[] args)
        {
            Console.WriteLine("Rate USD ke RP :");
            Console.WriteLine(""+USD);
            Console.WriteLine("Jumlah USD :");
            RP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hasil konversi :"+ Convert.ToInt32(USD*RP));
        }   
    }
}
