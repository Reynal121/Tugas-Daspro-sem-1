using System;

namespace Battle_Tank
{
class Program
    {
        static char[,] tank = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] LokasiTank = {
            {2,5},
            {3,1},
            {5,1}
        };
        static int[,] recent = {
            {0,0},
            {0,0},
            {0,0}
        };
        static int[] tebakan = {0,0};
        static int TebakanBenar = 0;
        static bool Gamestart = true;
        static int Benar = 0;

        static void Main(string[] args)
        {
            while(Gamestart)
            {
                DrawTank();
                try
                {
                    Console.Write("Pilih baris: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Yang anda masukkan bukan angka valid");
                    Console.WriteLine("Error: Silakan masukkan angka yang valid");
                }
                Benar = CekTank();
                if(Benar == 2)
                {
                    Console.WriteLine("Tank Ini Sudah hancur!");
                }
                else
                if(Benar == 1)
                {
                    Console.WriteLine("Boom! Tank hancur! Tebakan Anda Benar!");
                    TebakanBenar++;
                }
                else
                {
                    Console.WriteLine("Miss! Meleset! Tebakan Anda Salah!");
                }
                if(TebakanBenar == 3)
                {
                    Console.WriteLine("\nTank hancur semua! Anda Menang!");
                    Gamestart=false;
                }
                Console.WriteLine();
            }
        }

        static void DrawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int n=0;n<6;n++)
                {
                    Console.Write(tank[i,n] + " ");
                }
                Console.WriteLine();
            }
        }

        static int CekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == tebakan[0] && recent[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(LokasiTank[i,0] == tebakan[0] && LokasiTank[i,1] == tebakan[1])
                {
                    tank[tebakan[0],tebakan[1]] = 'X';
                    recent[i,0] = tebakan[0];
                    recent[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}