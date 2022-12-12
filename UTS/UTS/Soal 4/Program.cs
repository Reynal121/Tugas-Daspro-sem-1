using System;
using System.Text.RegularExpressions;

namespace Soal_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Teks;
            string Enkripsi = "";
            String abjad = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Regex rgx = new Regex("[^A-Za-z ]");

            do
            {
                Console.Write("Teks : ");
                Teks = Console.ReadLine();
            } while (String.IsNullOrEmpty(Teks) || rgx.IsMatch(Teks));

            foreach (Char t in Teks)
             {
                Char sementara = ' ';
                for (int i = 0; i < abjad.Length; i++)
                {
                    Char c = abjad[i];
                    if (t.Equals(c)) {
                        sementara = abjad[i+3];
                        break;
                    } else if (t.Equals(' ')) 
                    {
                        sementara = ' ';
                        break;
                    }
                }
                Enkripsi = Enkripsi + sementara;
            }
            Console.WriteLine("Enkripsi : " + Enkripsi);

        }
    }
}
