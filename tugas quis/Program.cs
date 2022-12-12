using System;

namespace tugas_quis
{
    class Program
    {
        static void Main(string[] args)
        {
            int koderandomanda;
            int kodekomputer;
            int skoranda = 0;
            int skorkomputer = 0;
            int game = 1;

            Random random = new Random();
            for (int n= 1; n <=10; n++)
            {
                {
                Console.WriteLine("Ronde : "+game);
                Console.WriteLine("Pencet enter untuk melempar dadu");
                Console.ReadKey();

                koderandomanda = random.Next(1,7);
                Console.WriteLine("Angka dadu anda adalah :"+koderandomanda);

                kodekomputer = random.Next(1,7);
                Console.WriteLine("Angka dadu komputer adalah : "+kodekomputer);
                }
                if (koderandomanda > kodekomputer)
                {
                game++;
                skoranda++;
                Console.WriteLine("Anda menang di ronde ini");
                Console.WriteLine("Skor Komputer :"+skorkomputer+ " Skor Anda : "+skoranda);
                Console.WriteLine("===========================================================");
                }
                else if (koderandomanda < kodekomputer)
                {
                game++;
                skorkomputer++;
                Console.WriteLine("Anda kalah di round ini");
                Console.WriteLine("Skor Komputer :"+skorkomputer+ " Skor Anda : "+skoranda);
                Console.WriteLine("===========================================================");
                }
                else
                {
                game++;
                Console.WriteLine("Hasil anda dengan komputer seri");
                Console.WriteLine("Skor Komputer :"+skorkomputer+ " Skor Anda : "+skoranda);
                Console.WriteLine("===========================================================");
                }
                if(skoranda > skorkomputer && n >= 10)
                {
                    Console.WriteLine("Anda menang di permainan dadu ini !!");
                    Console.WriteLine("Tekan enter untuk menghapus");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if(skoranda < skorkomputer && n >= 10)
                {
                    Console.WriteLine("Anda kalah di permainan dadu ini !!");
                    Console.WriteLine("Tekan enter untuk menghapus");
                    Console.ReadKey();
                    Console.Clear();
                
                }
                else if (skoranda == skorkomputer && n >=10)
                {
                    Console.WriteLine("Hasil permainan seri");
                    Console.WriteLine("Tekan enter untuk menghapus");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
            
    }
    
}
