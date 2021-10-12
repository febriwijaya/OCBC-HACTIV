using System;

public class Array
{
  public static void Main()
  {
    string[] contoh = new string [4]
    {
      "Motherboard", "Processor", "Power Supply", "Video Card"
    };

    string contoh1 = contoh[3];
    Console.WriteLine(contoh1);
    Console.Write("Press any key to continue...");
  }
}