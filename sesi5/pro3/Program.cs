using System;

class Program
{
  public static void Main(string[] args) {
    pesawat pesawat = new pesawat();
    pesawat_tempur pswttempur = new pesawat_tempur();

    pesawat.Nama = "Helly";
    pesawat.JumlahRoda = 3;
    pesawat.Ketinggian = "1000 kaki";
    pesawat.JumlahPenumpang = "3 penumpang";

    pswttempur.Nama = "AZ500TPU";
    pswttempur.JumlahRoda = 5;
    pswttempur.Ketinggian = "200 kaki";
    pswttempur.JumlahPenumpang = "2 Penumpang plus kopilot dan assintance";

    // memanggil method dari suatu kelas
    Pesawat2.terbang();
    pswttempur.terbangtinggi();
    Console.Read();
  }
}