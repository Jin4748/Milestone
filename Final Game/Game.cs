using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class Game
    {
        string GameTitle = "Compendium of Materia Medica";
        string Description = "This is a interesting trivia game about the Chinese Herbal. I hope you will enjoy the game.";

        private Maze_World MyWorld;
        private Player CurrentPlayer;

        private void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.Yellow;
            string prompt = "Welcome to Compendium of Material Medica. What would you like to do???";
            string[] options = { "About", "Play", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DisplayAboutInfo();                   
                    break;
                case 1:                   
                    RunFirstChoice();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("This is a interesting trivia game to learn about the Chinese Herbal. I hope you can enjoy the game.");
            WriteLine("Press any key to return to the menu...");
            ResetColor();
            ReadKey(true);
            RunMainMenu();
            
        }

        private void RunFirstChoice()
        {
            string prompt = "You received a patient suffering from a cold. As a junior doctor, how should you treat this patient?";
            string[] options = { "Use Galic", "Use Medicine", "Use Potion", "Use Hot Ginger Coca-Cola", "Give a cup of Hot Water"};
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nThe Patient didn't get over his cold and developed a severe sore throat");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nAfter a few minutes....");
                    WriteLine("\nThe Patient has died...");
                    string Playerchoice0 = ReadLine().Trim();
                    if (Playerchoice0 == "Use Galic")
                    {
                        WriteLine("GAME OVER");
                    }
                        RunMainMenu();                    
                    break;
                case 1:                   
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nAfter a few minutes....");
                    WriteLine("\nThe Patient has poisioned...");
                    string Playerchoice1 = ReadLine().Trim();
                    if (Playerchoice1 == "Use Medicine")
                    {
                        WriteLine("GAME OVER");
                    }
                        RunMainMenu();
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nThe Patient has shown good symptoms...");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\nAfter a few minutes....");
                    WriteLine("\nThe Patient has became a lovely Slime...");
                    string Playerchoice2 = ReadLine().Trim();
                    if (Playerchoice2 == "Use Potion")
                    {
                        WriteLine("GAME OVER");
                    }
                        RunMainMenu();
                    break;
                case 3:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nThe Patient has finally recovered...");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nAfter a few minutes....");
                    WriteLine("\nThe Patient has fallen asleep... ZZZZZZZZZZZZZZZZZZZZzzzzzzzzzzzzzzzzzzzzzzzzzzz");
                    break;
                case 4:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nThe Patient has finally recovered...");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nAfter a few minutes....");
                    WriteLine("\nThe Patient is talking to you about girls... .....((/- -)/");
                    break;
            }
            ResetColor();
            ReadLine();

            WriteLine("\n===============================================");
            string herbalQuestion1 = "What kind of herb can treat traumatic?";
            string herbalAnswer1 = "Panax notoginseng";
            Trivia herbalTrivia1 = new Trivia(herbalQuestion1, herbalAnswer1);
            herbalTrivia1.AskQuestion();
            WriteLine("\n---------------------------------------------------");

            string herbalQuestion2 = "What is the effect of Chrysanthemum?";
            string herbalAnswer2 = "Heat-Clearing & detoxifying";
            Trivia herbalTrivia2 = new Trivia(herbalQuestion2, herbalAnswer2);
            herbalTrivia2.AskQuestion();
            WriteLine("\n---------------------------------------------------");

            string herbalQuestion3 = "Is Acupunture inside the scope the traditional Chinese medicine? Yes/No";
            string herbalAnswer3 = "Yes";
            Trivia herbalTrivia3 = new Trivia(herbalQuestion3, herbalAnswer3);
            herbalTrivia3.AskQuestion();
            WriteLine("\n-----------------------------------------------------");

            string herbalQuestion4 = "";
            string herbalAnswer4 = "";
            Trivia herbalTrivia4 = new Trivia(herbalQuestion4, herbalAnswer4);
            herbalTrivia4.AskQuestion();

            WriteLine("\n------------------------------------------------------");
            ReadLine();
            MessageDisplayIntro();
            Start();
            MessageDisplayOutro();

            ExitGame();
        }


        private void DisplayPlayer()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Hello. Player");
            WriteLine("Your current title is Rookie.");
            WriteLine("You can upgrade your level in the SHOP.");
            ReadLine();
        }


        public void Play()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"_By Jin");

            string userName;
            Write("Dear player, may I know your name?");
            userName = ReadLine();

            ForegroundColor = ConsoleColor.Red;
            WriteLine("Hello , " + userName + " Welcome to Compendium of Materia Medica");

            RunMainMenu();

            RunFirstChoice();

        }

        public void Start()
        {
            string[,] grid = {
                { "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄" },
                { " ", " ", "█", "█", "█", "█", "█", "▄", "█" },
                { "█", " ", " ", " ", "█", "█", "█", " ", "█" },
                { "▄", " ", "▄", " ", "█", " ", "█", "█", "█" },
                { "█", " ", "█", " ", "▄", " ", "█", "█", "█" },
                { "█", " ", "█", " ", " ", " ", "█", " ", "█" },
                { "█", "▄", "▄", "▄", "▄", " ", "█", " ", "█" },
                { "█", " ", " ", " ", " ", " ", "█", " ", "█" },
                { "█", " ", "▄", "▄", "▄", "▄", "▄", " ", "█" },
                { "█", " ", " ", " ", " ", " ", " ", " ", "█" },
                { "▄", "▄", "▄", "▄", "▄", "▄", "▄", "C", "▄" },
            };

            MyWorld = new Maze_World(grid);

            CurrentPlayer = new Player(0, 1);

            RunGameLoop();
        }

        private void MessageDisplayIntro()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("You got a message from Master.Fu : ");
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Dear my disciple,");
            WriteLine("Please help me find the important herbal in the StoneMaze, I need this herbal to create cure my son's disease.");
            WriteLine("Please help me!!!");
            WriteLine("Thank you");
            WriteLine("Master.Fu");
            ResetColor();
            ReadKey(true);
        }

        private void MessageDisplayOutro()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            WriteLine("You found the herbal.");
            ResetColor();

        }

        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo KeyInfo = ReadKey(true);
            ConsoleKey Key = KeyInfo.Key;
            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositionWalkAble(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkAble(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkAble(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkAble(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }
        
        private void RunGameLoop()
        {
            while (true)
            {
                DrawFrame();
                HandlePlayerInput();
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);
                if (elementAtPlayerPos == "C")
                {
                    break;
                }

                System.Threading.Thread.Sleep(20);
            }
        }
        
    }
}
