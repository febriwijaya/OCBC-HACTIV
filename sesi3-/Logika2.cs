using System;

public class Logika2
{
  public static void Main(string[] args)
  {
    int nilai;
    
    Console.Write("Masukkan nilai anda : ");
    nilai = int.Parse(Console.ReadLine());

    if (nilai < 60) {
      Console.WriteLine("Nilai Kamu C");
    }
    else if (nilai < 80) {
      Console.WriteLine("Nilai Kamu B");
    }
    else {
      Console.WriteLine("Nilai kamu A");
    }
  }
}