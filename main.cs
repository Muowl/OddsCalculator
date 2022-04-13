using System;
using Entities;

class Program 
{
  public static void Main (string[] args) 
  {
    try
    {
      Console.WriteLine ("Enter the number of points betted for player one: ");
      float playerOne = float.Parse(Console.ReadLine());
      Console.WriteLine ("Enter the number of points betted for player two: ");
      float playerTwo = float.Parse(Console.ReadLine());
      Calculator calc = new Calculator (playerOne, playerTwo);
      calc.Calculation();
    }
    catch (Exception ex)
    {
      Console.WriteLine("Error: " + ex.Message);
    }    
  }
}