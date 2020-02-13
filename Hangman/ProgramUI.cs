using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class ProgramUI
    {
        public void Run()
        {
            bool gameIsRunning = true;
            while(gameIsRunning == true)
            {
                RunGame();
                Console.Clear();
            }
        }

        private void RunGame()
        {
            Console.WriteLine("Greetings! Welcome to HangMan!");
            string[] word = new string[5];
            word[0] = "earth";
            word[1] = "wind";
            word[2] = "fire";
            word[3] = "water";
            word[4] = "planet";
            Console.WriteLine("Enter a number 0-4 to choose your word!");
            string wordChoice = "";
            char[] guess = new char[0];
            string userInput = Console.ReadLine();
            //This switch case is doings two things: 1) Assigning a word from out string[] to the variable wordChoice 2) create a char[] with '*' for each letter in WordChoice.
            switch (userInput)
            {
                case "0":
                    wordChoice = word[0];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
                case "1":
                    wordChoice = word[1];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    break;
                case "2":
                    wordChoice = word[2];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    break;
                case "3":
                    wordChoice = word[3];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    break;
                case "4":
                    wordChoice = word[4];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    break;

            }

            // ask user for input
            while (new string (guess) != wordChoice)
            {
                string userLetter = Console.ReadLine();

                // evaluate if wordChoice contains input

                bool letterGuessCorrect = wordChoice.Contains(userLetter);

                // iterate through char[], and replace the * at the same index in which the guess appears in the string

                if (letterGuessCorrect)
                {
                    Console.WriteLine("Great! Keep going!");

                    // Now loop through wordChoice and find all correct characters
                    // Replace the same index in guess
                    // Redisplay guess
                    for (int i = 0; i < wordChoice.Length; i++)
                    {
                        if (wordChoice[i].ToString() == userLetter)
                        {
                            char[] newArray = userLetter.ToCharArray();
                            guess[i] = userLetter[0];
                            Console.WriteLine(guess);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong! Try again!");
                }

            }

            char[] wordChoiceArray = wordChoice.ToCharArray();

            //foreach (char c in wordChoiceArray)
            //{
            //    Console.ReadLine();
            //}
        }
    }
}
