using System;

class Program
{
  static void Main()
  {
    int max = 100000;
    int min = 1;
    int mid = FindMid(min, max);
    Console.WriteLine("Would you like to play? ['Y' for yes, 'N' for no]");
    string play = Console.ReadLine();
    if(play == "y" || play == "Y") {
      Console.WriteLine("Pick a number from 1 to 100,000 and I will guess it");
    } else {
      Main();
    }
    string guess = "";
    while (guess != "C" || guess != "c")
    {
      Console.WriteLine("Is " + mid + " your number? ['H' if your number is higher, 'L' if your number lower, 'C' if my guess is correct]");
      guess = Console.ReadLine();
      if(guess == "H" || guess == "h")
      {
        min = mid;
        mid = FindMid(min, max);
      }
      else if(guess == "L" || guess == "l")
      {
        max = mid;
        mid = FindMid(min, max);
      }
      else if(guess == "C" || guess == "c")
      {
        break;
      }
    }
    Console.WriteLine("YEA");
    Main();
  }

  static int FindMid(int min, int max) {
    return (int)(max - ((max-min) / 2));
  }
}
