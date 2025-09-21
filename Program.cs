using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hari
{
    struct TanggalDanWaktu
    {
        uint detik;
        uint menit;
        uint jam;
        uint hari;
        uint tanggal;
        uint bulan;
        uint tahun;
    };

    struct Tanggal
    {
        uint tanggal;
        uint bulan;
        uint tahun;
    };

    internal class Program
    {

       public static  int[] jumlahHariMasehi = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
       public static string[] namaHari = {"Minggu","Senin","Selasa","Rabu","Kamis","Jum'at","Sabtu" };

        static void Main(string[] args)
        {
        
            string[] namaBulanMasehi = {"Januari", "Februari", "Maret", "April", "Mei", "Juni",
                   "Juli", "Agustus", "September", "Oktober","November", "Desember"};

            int[] kabisat = { 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040 };


            TanggalDanWaktu tanggalMasehi;

            Console.SetWindowSize(Console.WindowWidth / 2, Console.WindowHeight / 2);

           // Console.WriteLine("tgl. lahir (hh/bb/tttt)");
           // string sTgl = Console.ReadLine();

          //  string[] sArrTgl = sTgl.Split('/');

          //  string hh = sArrTgl[0];
          //  string bb = sArrTgl[1];
         //   string tttt = sArrTgl[2];

            // string dateString = "2025-09-20 14:00:00";
          //  string dateString = tttt + "-" + bb + "-" + hh;
          //  DateTime dateTime = DateTime.Parse(dateString);

            // string hari = Hari((int)dateTime.DayOfWeek);
            // string zodiak = Zodiak(int.Parse(hh), int.Parse(bb));

            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("HARI");
            Console.WriteLine("-------");
            Console.WriteLine("tgl. 17 agustus 1945");
            Console.WriteLine("jatuh pada hari '" + hari() + "'");

            Console.ReadKey();
        }


        public static string hari() {

            string sHari = "";

            // step 1 ===
            // 1 abad terdapat 5 hari menyendiri
            // Tentukan hari menyendiri hingga tahun 1900. Nah, 1900 tahun = 1600
            // tahun + 300 tahun=> 3 abag
            int iSisaHariByTahun = (1600 % 4) + (15 % 7);
            Console.WriteLine("iSisaHariByTahun: " + iSisaHariByTahun);

            // step 2 ===
            // kasus menentukan hari di tgl 17 agt 1945
            // Tentukan hari menyendiri mulai dari awal tahun 1901 hingga akhir tahun 1944
            //  Kita mengetahui bahwa 44 tahun itu mempunyai (44 bagi 4) 11 tahun kabisat 
            //dan 33 tahun biasa. 
            // setiap tahun kabisat mempunyai 2 hari menyendiri 
            // tahun biasa   mempunyai 1 hari menyendiri
            int iSisaHariByYearRange = ((11 * 2) + (33 * 1)) % 7;
            Console.WriteLine("iSisaHariByYearRange: " + iSisaHariByYearRange);

            // step 3 ===
            // Tentukan banyaknya hari menyendiri mulai dari 1 Januari 1945
            // hingga 17 Agustus 1945. 
            // 
            int iJlhHari = 0;

            for( int i = 1;i <= (8 - 1);i++){
                iJlhHari += jumlahHariMasehi[i];
            }
            iJlhHari = iJlhHari + 17;
            //Console.WriteLine("iJlhHari: " + iJlhHari);

            int iSisaHariByDateRange = iJlhHari % 7;

            Console.WriteLine("iSisaHariByDateRange: " + iSisaHariByDateRange);

            int iSumSisa = (iSisaHariByTahun + iSisaHariByYearRange + iSisaHariByDateRange) % 7;
            Console.WriteLine("");
            Console.WriteLine("iSumSisa: " + iSumSisa);

            sHari = namaHari[iSumSisa];

            return sHari;
        }



    }
}
