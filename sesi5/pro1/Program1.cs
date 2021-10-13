using System;

class Program1 {
  
  public static void Main(string[] args) {
    // instant objek
    Laptop laptop1 = new Laptop();

    // akses atribut
    Console.WriteLine("Masukkan Merek laptop : ");
    laptop1.merk = Console.ReadLine();
    Console.WriteLine("Masukkan kapasitas RAM : ");
    laptop1.ram = int.Parse(Console.ReadLine());
    Console.WriteLine("Masukkan kapasitas Memory : ");
    laptop1.memory = int.Parse(Console.ReadLine());

    // Tampilkan
    Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
    Console.WriteLine("Kapasitas Ram ada {0}", laptop1.ram);
    Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

    // Akses Method
    laptop1.Chatting();
    laptop1.Sosmed();
    laptop1.OnlineShop();

    Console.Read();
  }
}