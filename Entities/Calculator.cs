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
      Console.Clear();
      if (PlayerOne > PlayerTwo)
      {
        Console.WriteLine("\nOdds:");
        Console.WriteLine("Player one: " + (PlayerOne / PlayerTwo).ToString("F2"));
        Console.WriteLine("Player two: 1.00");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nOdds in favor of player one!");
      }
      else if (PlayerOne < PlayerTwo)
      {
        Console.WriteLine("\nOdds:");
        Console.WriteLine("Player one: 1.00");
        Console.WriteLine("Player two: " + (PlayerTwo / PlayerOne).ToString("F2"));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nOdds in favor of player two!");
        }
      else
      {
        Console.WriteLine("\nOdds:");
        Console.WriteLine("Player one: 1");
        Console.WriteLine("Player two: 1");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEqual odds!");        
      }
    }
}