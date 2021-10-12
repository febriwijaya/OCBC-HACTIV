using System;

public class Logika1
{
  public static void Main()
  {
    int a;
    int b;

    Console.Write("Masukkan nilai pertama : ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Masukkan nilai kedua : ");
    b = int.Parse(Console.ReadLine());

    if(a > b)
    {
      Console.WriteLine("a lebih besar dari b");
    }
    else if (a < b)
    {
      Console.WriteLine("a lebih kecil dari b");
    } else 
    {
      Console.WriteLine("a sama dengan b");
    }
  }
}