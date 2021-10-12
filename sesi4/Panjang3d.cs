using System;

public class Panjang3D
{
  public static void Main() {
    int[, ,] angka = new int[10, 5, 6];

    Console.WriteLine("Panjang array angka adalah " + angka.Length);
  }
}