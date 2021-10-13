using System;

class Program
{
  static void Main(string[] args)
  {
    data datanew = new data();
    Console.WriteLine("Masukkan Nama : ");
    datanew.nama = Console.ReadLine();

    Console.WriteLine("Masukkan Nomor HP : ");
    datanew.nomor_telepon = int.Parse(Console.ReadLine());

    datanew.print(datanew.nama);
    datanew.print(datanew.nomor_telepon);
    Console.Read();
  }
}