using System;

class StringImmutible
{
  static void Main()
  {
    string stringawal = "C# membuat string mudah";

    // Menciptakan sebuah susbstring
    string substr = stringawal.Substring(5, 12);

    Console.WriteLine("stringawal : " + stringawal);
    Console.WriteLine("substring : " + substr);
  }
}