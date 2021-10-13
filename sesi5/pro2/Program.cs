using System;

class Program {
  public static void Main(string[] args) {
    class_pesawat pesawat = new class_pesawat();
    Console.WriteLine("Masukkan jenis pesawat : ");
    pesawat.nama = Console.ReadLine();
    Console.WriteLine("Masukkan ketinggian  : ");
    pesawat.ketinggian = Console.ReadLine();

    pesawat.terbang();
    pesawat.sudahterbang();
    Console.ReadLine();
  }
}