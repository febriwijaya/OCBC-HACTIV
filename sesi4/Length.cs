using System;

class Length {
  static void Main() {
    int[] angka = new int[10];

    Console.WriteLine("Panjang array angka adalah " + angka.Length);

    // Menggunakan Length untuk menginisialisasi angka
    for (int i = 0; i < angka.Length; i++) {
      angka[i] = i * i;
    }

    // Sekarang menggunakan Length untuk menampilkan angka
    Console.Write("Berikut adalah array angka : ");
    for(int i = 0; i < angka.Length; i++)
      Console.Write(angka[i] + " ");

    Console.WriteLine();
  }
}