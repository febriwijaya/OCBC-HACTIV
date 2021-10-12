using System;

public class Project3
{
  public static void Main(string[] args)
  {
    // membuat variabel kosong
    string fname, lname, tgllahir;
    int umur;
    
    Console.Write("Masukkan nama depan : ");
    fname = Console.ReadLine();
    Console.Write("Masukkan nama belakang : ");
    lname = Console.ReadLine();
    Console.Write("Masukkan tanggal lahir : ");
    tgllahir = Console.ReadLine();
    Console.Write("Masukkan alamat : ");
    var alamat = Console.ReadLine();
    Console.Write("Masukkan Umur : ");
    umur = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Nama lengkap anda : " + fname + " " + lname);
    Console.WriteLine("Tanggal lahir : " + tgllahir);
    Console.WriteLine("Alamat : " + alamat);
    Console.WriteLine("Umur : " + umur +  " tahun");
  }
}