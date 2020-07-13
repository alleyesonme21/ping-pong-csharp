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

      List<PingPongObj> OutputList = new List<PingPongObj>() {};

      

      Console.WriteLine(myNumber);
      Main();
    }
  }
}