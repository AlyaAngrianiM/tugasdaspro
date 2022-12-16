using System;

namespace UTS_TIKET_BIOSKOP
{
    class Program
    {
        static void Pembukaan()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Selamat datang di Tiket.Mawar");
            Console.WriteLine("Pusatnya untuk pembelian tiket bioskop");
            Console.WriteLine("By. Alya Angriani. M_2207111390");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Pembukaan();
            try
            {
            double hargaTiket;
            
            Console.WriteLine("Silahkan isi beberapa data berikut ini");
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("Tahun Lahir : ");
            int tahun = Convert.ToInt32(Console.ReadLine());
            
            int usia = 2021 - tahun;
            if (usia < 10 || usia > 60)
            {
                hargaTiket = 10000.00;
                Console.WriteLine("|*********************************|");
                Console.WriteLine("|         -- Studio 1 --          |");
                Console.WriteLine($"|Nama :                       {nama}|");
                Console.WriteLine($"|Harga tiket :   RP          {hargaTiket}|");
                Console.WriteLine("|---------------------------------|");
            }else if (usia >= 10 || usia <= 60 ) 
            {
                hargaTiket = 25000.00;
                Console.WriteLine("|*********************************|");
                Console.WriteLine("|         -- Studio 1 --          |");
                Console.WriteLine($"|Nama :                       {nama}|");
                Console.WriteLine($"|Harga tiket :   RP          {hargaTiket}|");
                Console.WriteLine("|---------------------------------|");
                
            }
            
            Console.WriteLine("");
            Console.WriteLine("Terimakasih sudah telah menggunakan layanan kami");
          
            }
            
            catch(System.FormatException)
            {
                Console.WriteLine("Harap input angka anda dengan valid");
            }
        }
    }
}