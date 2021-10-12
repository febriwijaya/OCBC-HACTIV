using System;

class Project3
{
  static void Main()
  {
    string nama;
    int umur;

    Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
    Console.Write("Masukkan nama : ");
    nama = Console.ReadLine();
    Console.Write("Masukkan alamat : ");
    var alamat = Console.ReadLine();
    Console.Write("Masukkan umur : ");
    umur = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Terimakasih");
    Console.WriteLine("Data Berikut");
    Console.WriteLine($"Nama : {nama}");
    Console.WriteLine($"Umur : {umur} tahun");
    Console.WriteLine("SUDAH DISIMPAN");
  }
}