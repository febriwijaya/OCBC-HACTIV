using System;

public class Logika3
{
  public static void Main()
  {
    string username, password;
    
    Console.Write("Masukkan nama anda : ");
    username = Console.ReadLine();
    Console.Write("Masukkan Password anda : ");
    password = Console.ReadLine();

    if(username == "ocbc" && password == "bootcamp") {
      Console.Write("Anda berhasil login");
    } else {
      Console.Write("Username atau password anda Salah");
    }
  }
}