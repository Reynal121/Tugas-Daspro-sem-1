using System;

namespace DASPRO
{
    class Program
    {
        static int KodeA;
        static int KodeB;
        static int KodeC;
        static int hasiltambah;
        static int hasilkali;
        static int kesempatan = 3; // Kesempatan
        static int level = 1;
        static string TebakanA;
        static string TebakanB;
        static string TebakanC;
        static bool bGameStart;

        //Function
        static void Main(string[] args)
        {
            bGameStart = true; //Start
            while(bGameStart)  //While Loop
            {
                if(level <= 5 && kesempatan >= 1) //Jika level masih kurang atau sama dengan 5, dan kesempatan masih lebih atau sama dengan 1
                {
                    Playgame();
                }
                else if(kesempatan <= 0) //Jika kesempatan nya kurang atau sama dengan 0
                {
                    ShowEnd(false);
                    bGameStart = (false);
                }
                else
                {
                    ShowEnd(true); // Jika 2 kondisi diatas tidak ada yang terpenuhi
                    bGameStart = (false);
                }
                
            }
            Console.Write("\nTekan Enter untuk keluar..."); 
            Console.ReadKey();
        }

        static void Init()
        {
            Random gp = new Random();  //Random Kode
            //Inisialisasi variabel
            KodeA = gp.Next(1,level+2);
            KodeB = gp.Next(1,level+2);
            KodeC = gp.Next(1,level+2);

            //Aritmatika
            hasiltambah = KodeA+KodeB+KodeC;
            hasilkali = KodeA*KodeB*KodeC;
        }
        static void Intro() //Intro
        {
            Init();
            Console.WriteLine("Anda adalah agen rahasia");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui");
            Console.WriteLine("==========================================");
            Console.WriteLine("- Password terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambahkan : "+ hasiltambah);
            Console.WriteLine("- Jika dikalikan : "+ hasilkali);
            Console.WriteLine("==========================================");
            Console.WriteLine(kesempatan + " Kesempatan Lagi");
            Console.WriteLine("================[ Level "+ level +" ]===============");

 
        }

        static void Playgame()
        {
            Intro();
            Console.Write("Masukan Kode pertama : ");
            TebakanA = Console.ReadLine();
            Console.Write("Masukan Kode kedua : ");
            TebakanB = Console.ReadLine();
            Console.Write("Masukan Kode ketiga : ");
            TebakanC = Console.ReadLine();

            if(TebakanA == KodeA.ToString() && TebakanB == KodeB.ToString() && TebakanC == KodeC.ToString()){
                Console.WriteLine("Tebakan Anda Benar!!!");
                level += 1;
                if( level <= 5 )
                {
                    Console.WriteLine("Selamat tebakan anda benar anda akan naik ke level "+level);
                    Console.WriteLine("Tekan enter untuk melanjutkan");
                    Console.ReadKey();
                    Console.Clear();


                }
                else
                {
                    Console.WriteLine("Selamat anda telah mencapai level terakhir");

                }
                
                Console.ReadKey();
                //True
            }
            else
            {
                //False
                Console.WriteLine("Tebakan Anda Salah!!!");
                kesempatan -= 1;
                Console.WriteLine("kesempatan anda tersisa :"+kesempatan);
                Console.WriteLine("Tekan enter untuk melanjutkan");
                Console.ReadKey();
                Console.Clear();
                
            }
        }

        static void ShowEnd(bool b)
        {
            Console.Clear();
            if(b)
            {
                Console.WriteLine("Jawaban Anda Benar!\n\nAnda Menang!!"); //kondisi menang
            }
            else
            {
                Console.WriteLine("Kesempatan Habis.\n\nAnda Kalah!!"); // kondisi kalah
            }
        }
    }
}

            

          