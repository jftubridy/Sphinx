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
  public static Dictionary<int, string> riddles = new Dictionary<int, string>() { {1, "What gets wet while it's drying?"}, {2, "What has a neck but no head?"}, {3, "How many months of the year have 28 days?"}};
  public static Dictionary<int, string> answers = new Dictionary<int, string>  () { {1, "towel"}, {2, "bottle"}, {3, "all"}};


  static void Main()
  {
    Console.WriteLine("Defeat the Sphinx's riddles or the Sphinx eats you!");
    Console.WriteLine("Are you sure you want to challenge the Sphinx??? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      RandomRiddle();
    }
    else
    {
      Console.WriteLine("Are you finished with the program? ['Y' for yes, 'Enter' for no]");
      string finishedAnswer = Console.ReadLine();
      if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Main();
      }
    }
  }
  static void RandomRiddle()
  {

    Random rand = new Random();
    return rand.Next(0, 3);

    Console.WriteLine(riddles[rand]);
    string userAnswerOne = Console.ReadLine();
    if (userAnswerOne == (answers[rand]))
    {
      Console.WriteLine("Correct! You've defeated the Sphinx!");

    }
    else
    {
      Console.WriteLine("Incorrect! You've been gobbled up by the mighty Sphinx!");
    }
  }
}
