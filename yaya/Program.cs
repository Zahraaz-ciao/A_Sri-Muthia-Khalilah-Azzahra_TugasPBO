using System;
using System.Collections.Generic;

namespace SistemRumahSakit
{
    public class Orang(string nama, int umur)
    {
        public string Nama { get; set; } = nama;
        public int Umur { get; set; } = umur;

        public virtual void Aktivitas() => Console.WriteLine($"{Nama} sedang melakukan aktivitas.");
        public virtual void InfoOrang() => Console.WriteLine($"Nama: {Nama}, Umur: {Umur}");
    }

    public class TenagaMedis(string nama, int umur, string spesialisasi) : Orang(nama, umur)
    {
        public string Spesialisasi { get; set; } = spesialisasi;

        public void CekSpesialis() => Console.WriteLine($"Spesialisasi {Nama}: {Spesialisasi}");
        public override void InfoOrang() => Console.WriteLine($"Nama: {Nama}, Umur: {Umur}, Spesialisasi: {Spesialisasi}");
    }

    public class Dokter(string nama, int umur, string spesialisasi) : TenagaMedis(nama, umur, spesialisasi)
    {
        public override void Aktivitas() => Console.WriteLine($"Dr. {Nama} sedang mendiagnosis pasien.");
        public void Diagnosa() => Console.WriteLine($"Dokter {Nama}, spesialisasi {Spesialisasi} sedang mendiagnosis pasien.");
        public void TampilkanInfo() => Console.WriteLine($"Nama: Dr. {Nama}, Umur: {Umur}, Spesialisasi: {Spesialisasi}");
    }

    public class Perawat(string nama, int umur, string spesialisasi) : TenagaMedis(nama, umur, spesialisasi)
    {
        public override void Aktivitas() => Console.WriteLine($"{Nama} sedang merawat pasien.");
        public void CekPasien() => Console.WriteLine($"Perawat {Nama} sedang mengecek kondisi pasien.");
    }

    public class Pasien(string nama, int umur, string keluhan) : Orang(nama, umur)
    {
        public string Keluhan { get; set; } = keluhan;

        public void CekKeluhan() => Console.WriteLine($"Keluhan {Nama}: {Keluhan}");
        public override void Aktivitas() => Console.WriteLine($"{Nama} sedang diperiksa oleh tenaga medis.");
    }

    public class PasienAnak(string nama, int umur, string keluhan) : Pasien(nama, umur, keluhan)
    {
        public void Menangis() => Console.WriteLine($"{Nama} sedang menangis.");
    }

    public class PasienDewasa(string nama, int umur, string keluhan) : Pasien(nama, umur, keluhan)
    {
        public void Konsultasi() => Console.WriteLine($"{Nama} sedang berkonsultasi.");
    }

    public class RumahSakit
    {
        private readonly List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang) => daftarOrang.Add(orang);

        public void DaftarOrang()
        {
            Console.WriteLine("=== DAFTAR ORANG DI RUMAH SAKIT ===");
            foreach (var orang in daftarOrang)
            {
                orang.InfoOrang();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instansiasi Objek
            Dokter drMori = new Dokter("Mori", 65, "Jantung");
            Pasien yuna = new Pasien("Yuna", 20, "Pusing");
            PasienAnak andre = new PasienAnak("Andre", 6, "Demam");
            Perawat axoloth = new Perawat("Axoloth", 28, "Umum");

            drMori.Aktivitas();
            yuna.Aktivitas();
            drMori.Diagnosa();
            drMori.TampilkanInfo();
            andre.Menangis();
            Orang orang2 = axoloth;
            orang2.Aktivitas();
        }
    }
}