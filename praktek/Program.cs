using System;
using System.Collections.Generic;

namespace praktek
{
    class Program
    {
        static int kesempatan = 5;
        static string katamisteri = "barcelona";
        static List<string> listtebakan = new List<string>();
        
        static void Main(string[] args)
        {
            Intro();
            Playgame();
            Endgame();
        }
        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata misteri");
            Console.WriteLine("petunjuknya adalah kata ini merupakan nama klub sepakbola spanyol");
            Console.WriteLine($"Kata tersebut terdiri dari {katamisteri.Length } huruf");
            Console.WriteLine("Klub apakah yang di maksud?");

        }
        static void Playgame()
        {
            while (kesempatan > 0)
            {
                Console.Write("\nApa huruf tebakan mu? pilih (a-z)");
                string input = Console.ReadLine();
                listtebakan.Add(input);
                if(cekjawaban (katamisteri,listtebakan))
                {
                    Console.WriteLine("Selamat anda berhasil menebak katanya");
                    Console.WriteLine($"kata misteri hari ini adalah {katamisteri}");
                    break;
                }
                else if(katamisteri.Contains(input))
                {
                    Console.WriteLine("\nHuruf itu ada di dalam kata ini");
                    
                    Console.WriteLine(CekHuruf(katamisteri,listtebakan));
                    Console.WriteLine("Silahkan tebak huruf yang lainnya..");
                }
                else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--; // kesempatan = kesempatan - 1
                    Console.WriteLine($"kesempatan anda tersisa : {kesempatan}");
                }
            }
        }

        static bool cekjawaban(string kata, List<string> List)
        { 
            bool net = false;
            for (int i = 0; i < kata.Length; i++)
            {
                string x = Convert.ToString(kata[i]);
                if(List.Contains(x))
                {
                    net = true;
                }
                else
                {
                    return net = false;
                }

                
            }
            return net;
        }
        static string CekHuruf(string kata, List<string> List)
        {
            string net = "";
            for (int i = 0; i < kata.Length; i++)
            {
                string x = Convert.ToString(kata[i]);
                if(List.Contains(x))
                {
                    net += x;
                }
                else
                {
                    net += "_";
                }
            }
            return net;
        }

        static void Endgame()
        {
            Console.WriteLine("Permainan Berakhir");
            Console.WriteLine("Byee...");
            Console.ReadKey();
        }

    }
}
