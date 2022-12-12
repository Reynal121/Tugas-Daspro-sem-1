using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Soal_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesempatan = 10;
            String Jawaban = "";
            bool salah = false;
            bool menang = false;
            bool kalah = false;
            bool benar = false;
            Console.Clear();
            string soal = "informatika";

            char[] Tebakan = new char[soal.Length]; 
            
 
            for (int i = 0; i < soal.Length; i++) { 
                Tebakan[i] = '_'; 
            }
 
            while (menang == false && kalah == false) 
            {
                Console.Write("Huruf tebakan : ");
                char playerTebakan = char.Parse(Console.ReadLine()); 
                for (int t = 0; t < soal.Length; t++) 
                {
                    if (playerTebakan == soal[t]) { 
                        benar = true; 
                        Tebakan[t] = playerTebakan; 
                    } else if (t == soal.Length - 1 && benar == false){ 
                        salah = true; 
                    }
                }
                Console.Clear();
                Jawaban = new String(Tebakan); 
                if (salah == true) { 
                    Console.WriteLine("Tebakan anda salah!"); 
                    kesempatan--; 
                    salah = false; 
                }
                benar = false; 
                Console.WriteLine(Tebakan); 
                Console.WriteLine();
                switch (kesempatan) 
                {
                    case 9:
                        Console.WriteLine("_|___");
                        break;
                    case 8:
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 7:
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 6:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 5:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 4:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 3:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 2:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 1:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("_|___");
                        break;
                    case 0:
                        Console.WriteLine("__________");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("_|___");
                        break;

                    default:
                        break;
                }

                if (Jawaban == soal) {
                    Console.WriteLine("Selamat, anda menang!");
                    menang = true; 
                } else if (kesempatan == 0 && Jawaban != soal) {
                    Console.WriteLine("Anda kurang beruntung!");
                    kalah = true;
                }
            }
        }
    }
}