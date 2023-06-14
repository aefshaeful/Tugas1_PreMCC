using System;

namespace KasirKopi
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            double totalHarga = 0;
            bool lanjutkan = true;

            Console.WriteLine("Selamat Datang di Kedai Kopi CUAKS \n");
            Console.WriteLine("============================================");
            do
            {
                Console.WriteLine("Silahkan pilih biji kopi yang ingin dipesan:");
                Console.WriteLine("1. Robusta");
                Console.WriteLine("2. Liberika");
                Console.WriteLine("3. Arabica");
                Console.WriteLine("4. Exit");

                Console.Write("Pilihan: ");
                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Robusta robusta = new Robusta();
                        totalHarga += robusta.Harga();
                        Console.WriteLine("Biji kopi Robusta berhasil ditambahkan ke keranjang.");
                        break;

                    case 2:
                        Liberika liberika = new Liberika();
                        totalHarga += liberika.Harga();
                        Console.WriteLine("Biji kopi Liberika berhasil ditambahkan ke keranjang.");
                        break;

                    case 3:
                        Arabica arabica = new Arabica();
                        totalHarga += arabica.Harga();
                        Console.WriteLine("Biji kopi Arabica berhasil ditambahkan ke keranjang.");
                        break;
                        
                    case 4:
                        Console.WriteLine("Terima kasih telah berkunjung ke Kedai Kopi CUAKS.");
                        lanjutkan = false;
                        break;
                        
                    case 5:
                        Console.WriteLine("Logout");
                        lanjutkan = false;
                        break;
                    
                    case 6:
                        Console.WriteLine("Exit");
                        lanjutkan = false;
                        break;    
                        
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }

                if (lanjutkan)
                {
                    Console.WriteLine("Total harga sementara: {0}", totalHarga);

                    Console.WriteLine("Apakah ingin melanjutkan pesanan? (Ya/Tidak)");
                    string jawaban = Console.ReadLine();
                    if (jawaban == "Tidak")
                    {
                        lanjutkan = false;
                        Console.WriteLine("============================================");
                        Console.WriteLine("Terima kasih telah berkunjung ke Kedai Kopi CUAKS.");
                    }
                }
            } while (lanjutkan);
        }
    }

    public abstract class BijiKopi
    {
        protected string jenis;
        protected double harga;

        public string Jenis
        {
            get { return jenis; }
        }

        public double Harga()
        {
            return harga;
        }
    }

    public class Robusta : BijiKopi
    {
        public Robusta()
        {
            jenis = "Robusta";
            harga = 45000;
        }
    }

    public class Liberika: BijiKopi
    {
        public Liberika()
        {
            jenis = "Liberika";
            harga = 30000;
        }
    }

    public class Arabica: BijiKopi
    {
        public Arabica()
        {
            jenis = "Arabica";
            harga = 50000;
        }
    }
}
