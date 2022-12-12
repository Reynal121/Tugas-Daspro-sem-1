using System;

namespace soal_1
{
    class Program
    {
        static string Nama;
        static string Nim;
        static string Konsentrasi;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nama :");
            Nama = Console.ReadLine();
            Console.WriteLine("Nim :");
            Nim = Console.ReadLine();
            
            do{
                Console.WriteLine("Konsentrasi : [RPL/KCV/Jaringan]");
                Konsentrasi = Console.ReadLine();
                if(Konsentrasi != "RPL" && Konsentrasi != "KCV" && Konsentrasi != "Jaringan" )
                {
                    Console.WriteLine("Input yang anda masukkan tidak sesuai");
                }
            }
            while(Konsentrasi != "RPL" && Konsentrasi != "KCV" && Konsentrasi != "Jaringan" );
            

            Console.WriteLine("|"+"{0,24}","***********************|");
            Console.WriteLine("|Nama :"+"{0,18}",""+Nama+"|");
            Console.WriteLine("|"+"{0,24}",""+Nim+"|");
            Console.WriteLine("|"+"{0,24}","-----------------------|");
            Console.WriteLine("|"+"{0,24}",""+Konsentrasi+"|");
            Console.WriteLine("|"+"{0,24}","***********************|");

        }

    }
}
