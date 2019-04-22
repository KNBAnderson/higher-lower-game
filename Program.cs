using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Would you like to pick a number or guess my number? ['P' for pick a number, 'G' for guess a number]");
    string play = Console.ReadLine();
    if(play == "p" || play == "P") {
      Console.WriteLine("Pick a number from 1 to 100,000 and I will guess it");
      ComputerGuess();
      } else if (play == "g" || play == "G"){
        Random rnd = new Random();
        int randomThingy = rnd.Next(1,101);
        Console.WriteLine("I have chosen a number. Can you guess it?");
        UserGuess(randomThingy);
        Main();
      }
    }
    static void ComputerGuess() {
      int max = 100000;
      int min = 1;
      int mid = FindMid(min, max);

      string userHint = "";
      while (userHint != "C" || userHint != "c")
      {
        Console.WriteLine("Is " + mid + " your number? ['H' if your number is higher, 'L' if your number lower, 'C' if my guess is correct]");
        userHint = Console.ReadLine();
        if(userHint == "H" || userHint == "h")
        {
          min = mid;
          mid = FindMid(min, max);
        }
        else if(userHint == "L" || userHint == "l")
        {
          max = mid;
          mid = FindMid(min, max);
        }
        else if(userHint == "C" || userHint == "c")
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

    static void UserGuess(int randomNumber) {
      string userGuess = "";
      while (true)
      {
        userGuess = Console.ReadLine();
        int userInt = int.Parse(userGuess);
        if (userInt > randomNumber)
        {
          Console.WriteLine("The number is lower than " + userInt + ". Guess again");
        }
        else if (userInt < randomNumber)
        {
          Console.WriteLine("The number is higher than " + userInt + ". Guess again");
        }
        else if (userInt == randomNumber)
        {
          Console.WriteLine("You got it! " + randomNumber + " was the number!");
          break;
        }
      }
    }
  }
