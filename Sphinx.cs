// using System;
//
// class Riddle
// {
//   static void Main()
//   {
//     Console.WriteLine("What gets wet while it's drying?");
//     string answer1 = Console.ReadLine();
//
//     bool riddle1 = answer1 == "towel";
//
//     if (riddle1)
//     {
//       Console.WriteLine("What has a neck but no head?");
//       string answer2 = Console.ReadLine();
//
//       bool riddle2 = answer2 == "bottle";
//       if (riddle2)
//       {
//         Console.WriteLine("You've defeated the Sphinx");
//       }
//       else
//       {
//         Console.WriteLine("You've been eaten");
//       }
//     }
//     else
//     {
//       Console.WriteLine("You've been eaten");
//     }
//   }
// }
//
// using System;
//
// class RiddleTime
// {
//   public
//
//   static void Main()
//   {
//     Console.WriteLine("Defeat the Sphinx's riddles or the Sphinx eats you!");
//     Console.WriteLine("What gets wet while it's drying?");
//     string stringAnswerOne = Console.ReadLine();
//
//
//   }
// }

using System;
using System.Collections.Generic;

class Riddle
{
  public static Dictionary<int, string> riddles = new Dictionary<int, string>() { {1, "What gets wet while it's drying?"}, {2, "What has a neck but no head?"}, {3, "How many months of the year have 28 days?"}, {4, "What can travel around the world while staying in a corner?"}, {5, "What has hands but can not clap?"}, {6, "You can drop me from the tallest building and I'll be fine, but if you drop me in water I die. What am I?"}, {7 , "What gets wetter and wetter the more it dries?"}, {8, "What has a head and a tail, but no body?"}, {9, "What has an eye but can not see?"}};
  public static Dictionary<int, string> answers = new Dictionary<int, string>  () { {1, "towel"}, {2, "bottle"}, {3, "all"}, {4, "stamp"}, {5, "clock"}, {6, "paper"}, {7, "towel"}, {8, "coin"}, {9, "needle"}};
  public static Dictionary<int, string> usedRiddles = new Dictionary<int, string>  () {};
  

  static void Main()
  {
    Console.WriteLine("Defeat the Sphinx's riddles or the Sphinx eats you! Would you like to play?[y for yes]");
    string readyCheck = Console.ReadLine();
    if (readyCheck.ToLower() == "y")
    {
      for (int i = 0; i < 3; i++) 
      {
        int selector = RandomRiddle();
        askRiddle(selector, i);
      }
    }
  }
  static void askRiddle(int selector, int i)
  {
    Console.WriteLine(riddles[selector]);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() == answers[selector] && i < 2) 
    {
      Console.WriteLine("Great work! Time for the next riddle.");
    }
    else if (userAnswer.ToLower() == answers[selector])
    {
      Console.WriteLine("Congradulations. You've defeated the Sphinx");
      return;
    }
    else 
    {
      Console.WriteLine("You've been eaten by the Sphinx!");
      return;
    }
  }

  static int RandomRiddle()
  {

    Random rand = new Random();
    int currentRiddle = rand.Next(1, riddles.Count);
    while (usedRiddles.ContainsKey(currentRiddle))
    {
      currentRiddle = rand.Next(1, riddles.Count);
    }
    usedRiddles.Add(currentRiddle,riddles[currentRiddle]);
    return currentRiddle;
  }
}
