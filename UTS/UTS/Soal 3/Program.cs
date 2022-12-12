using System;

namespace Soal_3
{
    class Program
    {
        static string Nama;
        static int TahunKelahiran;
        static int TahunSekarang = 2022;
        static int Umur;

        static void Main(string[] args)
        {

            Console.WriteLine("Nama :");
            Nama = Console.ReadLine();
            Console.WriteLine("Tahun Kelahiran:");
            TahunKelahiran = Convert.ToInt32(Console.ReadLine());
            
            Umur = TahunSekarang-TahunKelahiran;
            
            if(Umur <= 60 && Umur >= 10)
            {
                Console.WriteLine("|"+"{0,24}","***********************|");
                Console.WriteLine("|"+"{0,24}","    -- Studio 1 --     |");
                Console.WriteLine("|Nama:"+"{0,19}",""+Nama+"|");
                Console.WriteLine("|Harga:"+"{0,18}","25000.00|");
                Console.WriteLine("|"+"{0,24}","-----------------------|");
                Console.WriteLine("|"+"{0,24}","***********************|");
            }
            else
            {
                Console.WriteLine("|"+"{0,24}","***********************|");
                Console.WriteLine("|"+"{0,24}","    -- Studio 1 --     |");
                Console.WriteLine("|Nama:"+"{0,19}",""+Nama+"|");
                Console.WriteLine("|Harga:"+"{0,18}","10000.00|");
                Console.WriteLine("|"+"{0,24}","-----------------------|");
                Console.WriteLine("|"+"{0,24}","***********************|");
            }
        }
        
    }
}
