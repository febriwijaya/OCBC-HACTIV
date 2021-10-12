using System;

public class Data1
{
    public static void Main(string[] args)
    {
        int[] aAngka = new int[5];
        string[] aNama = new string[] { "Febri", "Roni", "Jean" };
        object[] aObjek = { 09.44, "Test", DateTime.Now, true, 'D' };

        for (int i = 0; i < aAngka.Length; i++)
        {
            Console.Write($"Masukan angka ke- {i + 1}: ");
            aAngka[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array aAngka : ");
        foreach (int item in aAngka)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("Array aNama : ");
        foreach (string item in aNama)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("Array aObjek : ");
        foreach (object item in aObjek)
        {
            Console.Write($"{item} ");
        }
    }


}