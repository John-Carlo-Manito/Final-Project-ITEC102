using NICK_FINALS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using static System.Console;

namespace NICK_FINALS
{
    class Game
    {
        public void Start()
        {

           
            MainMenu();

        }
        private void MainMenu()
        {
            string prompt = @"
                                                                   ████████ ██    ██ ██████  ██ ███    ██  ██████      ██     ██  ██████  ██████  ██████  
                                                                      ██     ██  ██  ██   ██ ██ ████   ██ ██           ██     ██ ██    ██ ██   ██ ██   ██ 
                                                                      ██      ████   ██████  ██ ██ ██  ██ ██   ███     ██  █  ██ ██    ██ ██████  ██   ██ 
                                                                      ██       ██    ██      ██ ██  ██ ██ ██    ██     ██ ███ ██ ██    ██ ██   ██ ██   ██ 
                                                                      ██       ██    ██      ██ ██   ████  ██████       ███ ███   ██████  ██   ██ ██████  
                                                                                       
                                                                      This game will test your speed in typing.(use ARROW UP AND DOWN KEYS TO NAVIGATE)";




            string[] options = { "   Play   ", " Tutorial ", "Leaderboards   ", "  Credits ", "   Exit   " };
            Menu mainMenu = new Menu(prompt, options);
            int SelectedIndex = mainMenu.Run();
            switch (SelectedIndex)
            {
                case 0:
                    Clear();
                    Runplay();
                    break;
            }
        }
        private void Runplay()
        {
            Console.WriteLine("Welcome to the Typing Test!");
            Console.WriteLine("Press any key to start the test.");
            Console.ReadKey();

            Console.Clear();

            string[] words = { "hello", "world", "typing", "test", "practice", "programming" };

            Random random = new Random();
            int wordIndex = random.Next(0, words.Length);
            string currentWord = words[wordIndex];

            Console.WriteLine("Type the word: " + currentWord);

            DateTime startTime = DateTime.Now;

            string userInput = Console.ReadLine();

            DateTime endTime = DateTime.Now;
            TimeSpan elapsedTime = endTime - startTime;

            int wordsTyped = 0;
            int errorCount = 0;

            if (userInput == currentWord)
            {
                wordsTyped++;
                Console.WriteLine("Correct! Well done!");
            }
            else
            {
                errorCount++;
                Console.WriteLine("Incorrect. Pay attention to your typing!");
            }

            double accuracy = (wordsTyped / (double)(wordsTyped + errorCount)) * 100;
            double typingSpeed = wordsTyped / elapsedTime.TotalMinutes;

            Console.WriteLine("Words Typed: " + wordsTyped);
            Console.WriteLine("Errors: " + errorCount);
            Console.WriteLine("Accuracy: " + accuracy.ToString("0.00") + "%");
            Console.WriteLine("Typing Speed: " + typingSpeed.ToString("0.00") + " words per seconds");

            Clear();
            Console.WriteLine("Press any key to Return in MainMenu the program.");
            ReadKey();
            MainMenu();
            Console.ReadKey();
        }
    }
}