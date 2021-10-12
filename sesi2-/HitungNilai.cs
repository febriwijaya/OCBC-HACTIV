using System;

public class HitungNilai
{
  public static void Main(string[] args)
  {
    int  pertama, kedua, ketiga, total;
    double rata;
    Console.WriteLine("===Menghitung Nilai===");
    Console.Write("Masukkan Nilai Pertama : ");
    pertama = int.Parse(Console.ReadLine());
    Console.Write("Masukkan nilai kedua : ");
    kedua = int.Parse(Console.ReadLine());
    Console.Write("Masukkan nilai ketiga : ");
    ketiga = int.Parse(Console.ReadLine());

    total = pertama + kedua + ketiga;
    rata = total / 3.0;
    Console.WriteLine();
    Console.WriteLine("Total Nilai adalah : " + total);
    Console.WriteLine("Rata rata nilai adalah : " + rata);
    
  }
}