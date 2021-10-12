using System;  

public class Tugas {

    public static void Main(string[] args)
    {
        int choose;
        string exit;
        
        do{
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("------------>Welcome To My Program<-------------------");
          Console.WriteLine("------------------->Assignment 1<---------------------");
          Console.WriteLine();
          Console.WriteLine("Nama Lengkap Saya : Febri Wijaya Hutagalung");
          Console.WriteLine("Kode Peserta : FSDO001ONL012");
          Console.WriteLine("Silahkan Pilih Menu Program Saya : [1 sd 7]");
          Console.WriteLine();
          Console.WriteLine("------------------------->MENU<-----------------------");
          Console.WriteLine("1. Segitiga Alfabet");
          Console.WriteLine("2. Segitiga Angka");
          Console.WriteLine("3. Bilangan Faktorial");
          Console.WriteLine("4. Membalikkan Angka (Reverse)");
          Console.WriteLine("5. Converter Angka jadi String");
          Console.WriteLine("6. Palindrom Kata");
          Console.WriteLine("7. About Me");
      
          Console.Write("Masukkan Pilihan anda : ");
          choose = int.Parse(Console.ReadLine());

          switch (choose)
          {
            case 1 : {
              char huruf='A';
              int i, j, perulangan, urut, reverse; 

              Console.Write("Masukkan total perulangan Segitiga Huruf : ");
              perulangan = int.Parse(Console.ReadLine());

              for(i = 1; i <= perulangan; i++)      
              {      
                for(j = perulangan-1; j >= i; j--) {
                  Console.Write(" ");      
                }
                for(urut = 1; urut <= i; urut++)  {
                  Console.Write(huruf);
                  huruf++;
                }
                huruf--;
                for(reverse = 1; reverse < i; reverse++) {     
                  Console.Write(--huruf);      
                }
                Console.Write("\n");
              }
              break;
            }

            case 2: {
              int number = 1;
              int i, perulangan, j, urut, reverse; 
              
              Console.Write("Masukkan total perulangan Segitiga Angka: ");
              perulangan = int.Parse(Console.ReadLine());

              for(i = 1; i <= perulangan; i++) {  
                for(j = perulangan-1; j >= i; j--) {
                  Console.Write(" ");      
                }        
                for(urut = 1; urut <= i; urut++) {
                  Console.Write(number);
                  number++;
                }
                number--;
                for(reverse = 1; reverse < i; reverse++) {  
                  Console.Write(--number);      
                }        
                Console.Write("\n");
              }
              break;
            }

            case 3 : {
              int i, total, range;
          
              Console.Write("Masukkan Range Bilangan : ");
              range = int.Parse(Console.ReadLine());

              total = 1;
              for(i = 1; i <= range; i++ ) {
                total = total * i;
              }
              Console.WriteLine($"Hasil dari Faktorial {range} adalah = {total}");
              break;
            }

            case 4 : {
              string str1, str2 = ""; 
              int i, j;			

              Console.Write("Masukkan Angka : ");
              str1 = Console.ReadLine();

              j = str1.Length-1;
              for (i = j; i >= 0; i--) {
                str2 = str2 + str1[i];
              }
              
              Console.WriteLine("Reverse String : {0}", str2);
              Console.Write("");
              break;
            }

            case 5 : {
              string input;
              char[] arrInput;
              int converToInt;
              int len;

              Console.Write("Masukkan input Berupa Angka : ");
              input = Console.ReadLine();

              arrInput = input.ToCharArray();      
              len = arrInput.Length;
              for (int i = 0; i < len; i++) {
                converToInt = (int)Char.GetNumericValue(arrInput[i]);
                if (converToInt == 0) Console.Write("Zero ");
                if (converToInt == 1) Console.Write("One ");
                if (converToInt == 2) Console.Write("Two ");
                if (converToInt == 3) Console.Write("Three ");
                if (converToInt == 4) Console.Write("Four ");
                if (converToInt == 5) Console.Write("Five ");
                if (converToInt == 6) Console.Write("Six ");
                if (converToInt == 7) Console.Write("Seven ");
                if (converToInt == 8) Console.Write("Eight ");
                if (converToInt == 9) Console.Write("Nine ");
              }
              break;
            }

            case 6 : {
              string str1, str2 = ""; 
              int i,j;			

              Console.Write("Masukkan String (Katak) : ");
              str1 = Console.ReadLine();

              j = str1.Length-1;
              for (i = j; i >= 0; i--) {
                str2 = str2 + str1[i];
              }
              
              Console.WriteLine("Hasil : {0}", str2);
              break;
            }

            case 7 : {
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