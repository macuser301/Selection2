using System;

namespace Selection2
{
    class Program
    {
        static void Main(string[] args)
        {         //if statement!        
               Console.WriteLine("What is your name");

               string userName = Console.ReadLine();
               Console.WriteLine("Guess my favorite number between 195 and 205!");
               int favNumber = 200;
               string input = Console.ReadLine();

               int userGuess = int.Parse(input);
               if (userGuess == favNumber)
               {
                   Console.WriteLine("Correct!");
               }
               if (userGuess < favNumber)
               {
                   Console.WriteLine("Too Low!");
               }
               if (userGuess > favNumber)
               {
                   Console.WriteLine("Too High!");
               }
               Console.WriteLine($"Thank you {userName} for playing my guessing game!");

               //do While    






               int day = 4;
               switch (day)
               {
                   case 0:
                       Console.WriteLine("Sunday");
                       break;
                   case 1:
                       Console.WriteLine("Monday");
                       break;
                   case 2:
                       Console.WriteLine("Tuesday");
                       break;
                   case 3:
                       Console.WriteLine("Wednesday");
                       break;
                   case 4:
                       Console.WriteLine("Thursday");
                       break;
                   case 5:
                       Console.WriteLine("Friday");
                       break;
                   case 6:
                       Console.WriteLine("Saturday");
                       break;
               }








               Console.WriteLine($"{userName} Guess my new favorite number . between 4495 and 4501!");
               int favNumber2 = 4500;
               string input2 = Console.ReadLine();
               int userGuess2 = int.Parse(input2);
               if (userGuess2 == favNumber2)
               {
                   Console.WriteLine("Correct!");
               }
               else if (userGuess2 > favNumber2)
               {
                   Console.WriteLine("Too High!");
               }
               else
               {
                   Console.WriteLine("Too Low!");
               }


               Console.WriteLine("What's your favorite subject math or english?");
               var response = Console.ReadLine();
               switch (response)
               {
                   case "math":
                       Console.WriteLine("Math is cool"!);
                       break;
                   case "english":
                       Console.WriteLine("That's cool but I cant read!");
                       break;
                   default:
                       Console.WriteLine("Never heard of that one!");
                       break;

               }

               if (response == "math")
               {
                   Console.WriteLine("But, Math is for fools!");
               }
               else if (response == "english")
               {

                   Console.WriteLine("I hate learning English!");
               }
               else
               {
                   Console.WriteLine("That's an unusual topic!");
               }

                       
                                                     

                                                   
                    
            
            
            
            
            
            
            int favNumber3 = 300;
            int userGuess3 = 0;
            do
            {
                string input3 = Console.ReadLine();
                userGuess3 = int.Parse(input3);
                if (userGuess3 == favNumber3)
                {
                   
                }
            }
            while (userGuess3 != favNumber3);





        }
        public static string Bmi(double weight, double height)
        {
            var myBmi = weight / (height * height);

            if (myBmi <= 18.5)
            {
                return "Underweight";
            }
            else if (myBmi <= 25.0)
            {
                return "Normal";
            }
            else if (myBmi <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }



        }
    }
}    