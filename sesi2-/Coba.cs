using System;

public class Coba
{
  public static void Main()
  {

    string nama;
    int harga1, harga2, harga3;
    int jumlah1, jumlah2, jumlah3;

    Console.Write("Masukkan nama anda : ");
    nama = Console.ReadLine();
    Console.Write("Masukkan Harga Barang 1 : ");
    harga1 = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Jumlah Barang 1 : ");
    jumlah1 = int.Parse(Console.ReadLine());

    Console.Write("Masukkan Harga Barang 2 : ");
    harga2 = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Jumlah Barang 2 : ");
    jumlah2 = int.Parse(Console.ReadLine());

    Console.Write("Masukkan Harga Barang 3 : ");
    harga3 = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Jumlah Barang 3 : ");
    jumlah3 = int.Parse(Console.ReadLine());

    double total1 = harga1 * jumlah1;
    double total2 = harga2 * jumlah2;
    double total3 = harga3 * jumlah3;

    double TotalHargaSemua = total1 + total2 + total3;
    double JumlahSemuaBarang = jumlah1 + jumlah2 + jumlah3;

    Console.WriteLine();
    Console.WriteLine("nama customer : " + nama);
    Console.WriteLine("barang 1 berjumlah : " + jumlah1 + " harga barang 1 adalah " + harga1 + " total bayar barang 1 adalah : " + total1);
    Console.WriteLine("barang 2 berjumlah : " + jumlah2 + " harga barang 2 adalah " + harga2 + " total bayar barang 2 adalah : " + total2);
    Console.WriteLine("barang 3 berjumlah : " + jumlah3 + " harga barang 3 adalah " + harga3 + " total bayar barang 3 adalah : " + total3);
    Console.WriteLine();
    Console.WriteLine("Jumlah semua barang : " + JumlahSemuaBarang);
    Console.WriteLine("Total harga semua barang : " + TotalHargaSemua);
  }
}