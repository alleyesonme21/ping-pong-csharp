using System.Collections.Generic;

namespace PingPong.Models
{
  public class PingPongObj
  {
    public string InputNumber;
    public int MyNumber;
    public PingPongObj(string inputNumber) 
    {
      MyNumber = int.Parse(inputNumber);
    }
  }
}