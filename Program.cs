using System;
using PingPong.Models;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a Whole Number:");
      string inputNumber = Console.ReadLine();
      int myNumber = int.Parse(inputNumber);
      Console.WriteLine(myNumber);
    }
  }
}