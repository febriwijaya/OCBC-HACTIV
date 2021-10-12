using System;

public class ArrayLatihan
{
  public static void Main()
  {
    int[,] contoh = 
    {
      {1, 2, 3, 4},
      {5, 6, 7, 8},
      {9, 10, 11, 12}
    };

    Console.WriteLine("Nilai array anda adalah ");
    int i, j;

    for (i = 0; i < 3; i++) {
      for (j = 0; j < 4; j++)
        Console.Write(contoh[i, j] + " ");
      Console.WriteLine();
    }

    Console.WriteLine("\nNilai array yang anda akses : ");
    int contoh1 = contoh[0,0];
    Console.WriteLine(contoh1);
    Console.WriteLine(contoh[0,1]);
    Console.WriteLine(contoh[0,3]);    
  }
}