using System;


    class Logic_8
    {
        static void Main(string[] args)
        {
            int awal, batas;
            string operasi;
            string ulang = "no";

            
            do{
            Console.Write("Masukkan awalan looping : ");
            awal = int.Parse(Console.ReadLine());

            Console.Write("Masukkan batas looping : ");
            batas = int.Parse(Console.ReadLine());

            Console.Write("Masukkan operasi : ");
            operasi = Console.ReadLine();
                if(operasi == "+")
                    {
                        for(int i = 1; i<= batas; i++)
                        {
                            Console.WriteLine("nilai = {0}", i+awal);
                        }

                    }

                else if(operasi == "-")
                    {
                        for(int i = 1; i<= batas; i++)
                        {
                            Console.WriteLine("nilai = {0}", i-awal);
                        }
                    }

                else if(operasi == "*")
                    {
                        for(int i = 1; i<= batas; i++)
                        {
                            Console.WriteLine("nilai = {0}", i*awal);
                        }
                    }

                else if(operasi == "/")
                    {
                        for(int i = 1; i<= batas; i++)
                        {
                            Console.WriteLine("nilai = {0}", i/awal);
                        }
                    }

                Console.Write("Ulang ? y/n : ");
                ulang = Console.ReadLine();
                ulang = ulang.ToLower();
            }while(ulang == "y");
        }
    }
