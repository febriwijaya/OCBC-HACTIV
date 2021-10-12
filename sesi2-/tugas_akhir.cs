using System;

class TugasAkhir
{
  public static void Main(string[] args)
  {
    int  pertama, kedua, ketiga, total;
    double rata;

    Console.Write("Enter your username : ");
    string username = Console.ReadLine();
    Console.Write("Enter your Password : ");
    string password = Console.ReadLine();
    Console.Write("Enter your age : ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Enter your Gender : ");
    string gender = Console.ReadLine();
    Console.Write("Enter your Status [Y/N]: ");
    string status = Console.ReadLine();

    string status_nikah = status == "Y" ? "Sudah Menikah" : "Belum Menikah";

    Console.WriteLine();
    Console.WriteLine("===Menghitung Nilai===");
    Console.Write("Masukkan Nilai Pertama : ");
    pertama = int.Parse(Console.ReadLine());
    Console.Write("Masukkan nilai kedua : ");
    kedua = int.Parse(Console.ReadLine());
    Console.Write("Masukkan nilai ketiga : ");
    ketiga = int.Parse(Console.ReadLine());

    total = pertama + kedua + ketiga;
    rata = total / 3.0;


    if(username == "Febri" && password == "OCBC" && age > 18)
    {
      Console.WriteLine();
      Console.WriteLine("== OUTPUT ==");
      Console.WriteLine("Username anda : " + username);
      Console.WriteLine("Umur anda adalah : " + age);
      Console.WriteLine("Jenis Kelamin anda adalah : " + gender);
      Console.WriteLine("Status Nikah anda adalah : " + status_nikah);
      Console.WriteLine();

      Console.WriteLine("Total Nilai adalah : " + total);
      Console.WriteLine("Rata rata nilai adalah : " + rata);
    }
    else 
    {
      Console.WriteLine("Sorry, try again");
    }
  }
}