using System;

namespace PRG2_20192_P1_3_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi
            int n; //Jumlah pengulangannya

            //Algoritma
            Console.WriteLine("Program Menulis Syair Lagu Anak Ayam\n"); //Judul program
            Console.Write("Masukkan nilai N : "); n = Convert.ToInt16(Console.ReadLine());
            for(int i = n; i >= 1; i--)
            {
                if(i==1)
                {
                    Console.WriteLine("Anak ayam turun 1, mati satu tinggal induknya");
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", i, i-1);
                }
            }
        }
    }
}
