using System;

namespace DASPRO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi Terbuka
            const int a = 5;
            const int b = 4;
            const int c = 7;

            int tambah = a+b+c;
            int kali = a*b*c;
            int kurang = a-b-c;
            int bagi = a/b/c;

            Console.WriteLine("Hello World");
            Console.WriteLine("anda adalah agen rahasia");
            Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui");
            Console.WriteLine("- password terdiri dari 4 angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+tambah);
            Console.WriteLine("- jika dikalikan hasilnya "+kali);
            Console.WriteLine("- jika dikurang hasilnya "+kurang);
            Console.WriteLine("- jika dikurang hasilnya "+bagi);
            Console.WriteLine("");
            Console.Write("Enter Code : ");
        }
    }
}
