using System;
using PingPong.Models;
using System.Collections.Generic;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a Whole Number:");
      string inputNumber = Console.ReadLine();

      PingPongObj pingpong = new PingPongObj(inputNumber);
      int myNumber = pingpong.MyNumber;

      for (int index = 1; index <= myNumber; index++)
      {
        if ((index % 3 == 0) && (index % 5 == 0))
        {
          Console.WriteLine("ping-pong");
        }
        else if (index % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (index % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(index);
        }
      }
      Main();
    }
  }
}