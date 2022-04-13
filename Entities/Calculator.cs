using System;

namespace Entities;
class Calculator
{
    public float PlayerOne { get; private set; }

    public float PlayerTwo { get; private set; }

    public Calculator()
    {
    }
    public Calculator(float first, float second)
    {
      PlayerOne = first;
      PlayerTwo = second;
    }

    public void Calculation()
    {
        if (PlayerOne > PlayerTwo)
        {
          Console.WriteLine("\nOdds:");
          Console.WriteLine("Player one: " + (PlayerOne / PlayerTwo).ToString("F2"));
          Console.WriteLine("Player two: 1.00");
        }
        else if (PlayerOne < PlayerTwo)
        {
          Console.WriteLine("\nOdds:");
          Console.WriteLine("Player one: 1.00");
          Console.WriteLine("Player two: " + (PlayerTwo / PlayerOne).ToString("F2"));
        }
      else
      {
          Console.WriteLine("\nOdds:");
          Console.Write("Player one: 1");
          Console.Write("Player two: 1");
      }
    }

}