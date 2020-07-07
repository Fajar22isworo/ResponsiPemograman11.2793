using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemograman11
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("PILIH MENU APLIKASI");
            Console.WriteLine("1.Tambah Penjualan");
            Console.WriteLine("2.Hapus Penjualan");
            Console.WriteLine("3.Tampilkan Penjualan");
            Console.WriteLine("4.Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.Clear();
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("TAMBAH DATA PENJUALAN");
            Console.Write("NOTA :");
            penjualan.Nota = Console.ReadLine();
            Console.Write("TANGGAL :");
            penjualan.Tanggal= Console.ReadLine();
            Console.Write("CUSTOMER :");
            penjualan.Customer = Console.ReadLine();
            Console.Write("JENIS (T/K) :");
            penjualan.Jenis= Console.ReadLine();
            Console.Write("TOTAL NOTA:");
            penjualan.Total =  Console.ReadLine() ;
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("HAPUS DATA PENJUALAN");
            Console.Write("NOTA :");
            string NOTA = Console.ReadLine();
            foreach(Penjualan penjualan in daftarPenjualan)
            {
                no++;
                if (penjualan.Nota == NOTA)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("DATA PENJUALAN BERHASIL DI HAPUS");
            }else
            {
                Console.WriteLine("NOTA TIDAK DITEMUKAN");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int no = 0;
            Console.WriteLine("Data penjualann");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                string JENIS;
                if (penjualan.Jenis == "T")
                {
                    JENIS = "TUNAI";
                }
                else if (penjualan.Jenis == "K") 
                {
                    JENIS = "KREDIT";
                }
                else 
                {
                    JENIS = "JENIS TIDAK DIKETAHUI";
                }
                Console.WriteLine(no + "." + penjualan.Nota + "," + penjualan.Tanggal + "," + penjualan.Customer + "," + JENIS + "," + penjualan.Total);
                {
                    if (no < 1) ;
                }
                Console.WriteLine("DATA PENJUALAN KOSONG");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}