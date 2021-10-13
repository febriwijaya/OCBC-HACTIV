using System;  

public class Tugas {

    public static void Main(string[] args)
    {
        int choose;
        string exit;
        
        do{
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("------------>Menu<-------------------");
          Console.WriteLine("1. Konsep OOP");
          Console.WriteLine("2. Identifier");
          Console.WriteLine("3. Overloading");
          Console.WriteLine("4. About Me");
      
          Console.Write("Masukkan Pilihan anda : ");
          choose = int.Parse(Console.ReadLine());

          switch (choose)
          {
            case 1 : {
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
              break;
            }

            case 2: {
              class_pesawat pesawat = new class_pesawat();
              Console.WriteLine("Masukkan jenis pesawat : ");
              pesawat.nama = Console.ReadLine();
              Console.WriteLine("Masukkan ketinggian  : ");
              pesawat.ketinggian = Console.ReadLine();

              pesawat.terbang();
              pesawat.sudahterbang();
              Console.ReadLine();
              break;
            }

            case 3 : {
              data datanew = new data();
              Console.WriteLine("Masukkan Nama : ");
              datanew.nama = Console.ReadLine();

              Console.WriteLine("Masukkan Nomor HP : ");
              datanew.nomor_telepon = int.Parse(Console.ReadLine());

              datanew.print(datanew.nama);
              datanew.print(datanew.nomor_telepon);
              Console.Read();
              break;
            }

            case 4 : {
              Console.WriteLine("------------>Biodata Saya<----------------");
              Console.WriteLine("\tNama Saya          : Febri Wijaya Hutagalung");
              Console.WriteLine("\tAlamat             : Medan");
              Console.WriteLine("\tHp                 : 081914433487");
              Console.WriteLine("\tUsia               : 23 tahun ");
              Console.WriteLine("\tHobby              : Browsing Internet");
              Console.WriteLine("\tSkill              : Python, PHP, C#, C++, React js, PHP Laravel, PHP CI, Progressive Web Apps, mySQL");
              break;
            }

            default : {
              Console.Write("Angka yang anda Masukkan Salah...!");
              break;
            }
          }
        
          Console.Write("Apakah anda Ingin kembali ke menu awal ? (y/n) : ");
          exit = Console.ReadLine();
          exit = exit.ToLower();
          Console.Clear();
    }

    while(exit == "y" || exit == "Y");
    
    }
}