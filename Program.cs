
using System;
using System.Collections.Generic;

namespace GreatATUTreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Great ATU Treasure Hunt";

            Console.WriteLine("========================================");
            Console.WriteLine("     THE GREAT ATU TREASURE HUNT");
            Console.WriteLine("========================================");

            Console.WriteLine("\nWelcome to ATU Sligo!");
            Console.WriteLine("Five golden tokens are hidden around campus.");
            Console.WriteLine("Collect them all and win a parking space for a year!");
            Console.WriteLine("\nYou start with 100 points.");
            Console.WriteLine("Every hint costs you 5 points.");

            Console.Write("\nEnter your name: ");

            string playerName = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(playerName))
            {
                playerName = "Treasure Hunter";
            }

            Player player = new Player(playerName);

            // Create all five campus locations.
            List<Location> locations = new List<Location>
            {
                new ComputerLab(),
                new Canteen(),
                new Library(),
                new StudentsUnion(),
                new CarPark()
            };

            // The player starts at the Computer Lab.
            int currentIndex = 0;

            player.MoveTo(locations[currentIndex]);

            bool gameRunning = true;

            // Main game loop.
            while (gameRunning)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("          TREASURE HUNT MENU");
                Console.WriteLine("========================================");

                player.CurrentLocation.Describe();

                Console.WriteLine("\nPlayer: " + player.Name);
                Console.WriteLine("Score: " + player.Score);
                Console.WriteLine(
                    "Treasures: " +
                    player.TreasuresCollected.Count + "/5");

                Console.WriteLine("\n1. Solve the clue");
                Console.WriteLine("2. Ask for a hint (-5 points)");
                Console.WriteLine("3. Travel to the next location");
                Console.WriteLine("4. View progress");
                Console.WriteLine("5. Quit game");

                Console.Write("\nChoose an option: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        player.CurrentLocation.SolveChallenge(player);
                        break;

                    case "2":
                        if (!player.CurrentLocation.IsCompleted)
                        {
                            player.UseHint();

                            Console.WriteLine(
                                "Hint: " +
                                player.CurrentLocation.Clue.Hint);
                        }
                        else
                        {
                            Console.WriteLine(
                                "You have already solved this clue!");
                        }
                        break;

                    case "3":

                        // The player must solve the current clue first.
                        if (!player.CurrentLocation.IsCompleted)
                        {
                            Console.WriteLine(
                                "Solve the clue before moving on!");
                        }
                        else
                        {
                            // Move to the next campus location.
                            if (currentIndex < locations.Count - 1)
                            {
                                currentIndex++;

                                player.MoveTo(locations[currentIndex]);

                                Console.WriteLine(
                                    "\nTravelling to " +
                                    player.CurrentLocation.Name + "...");
                            }

                            // After collecting all five tokens,
                            // return to the Students' Union.
                            else if (player.TreasuresCollected.Count == 5)
                            {
                                currentIndex = 3;

                                player.MoveTo(locations[currentIndex]);

                                Console.WriteLine(
                                    "\nYou have returned to the Students' Union!");
                            }
                            else
                            {
                                Console.WriteLine(
                                    "You still need to collect all the treasures!");
                            }
                        }

                        // Check the winning condition.
                        if (player.TreasuresCollected.Count == 5 &&
                            player.CurrentLocation.Name == "Students' Union")
                        {
                            Console.WriteLine("\n========================================");
                            Console.WriteLine("          CONGRATULATIONS!");
                            Console.WriteLine("========================================");

                            Console.WriteLine(
                                "You collected all five golden tokens!");

                            Console.WriteLine(
                                "You have won a guaranteed parking space " +
                                "for the whole year!");

                            player.ShowProgress();

                            Console.WriteLine(
                                "\nThank you for playing The Great ATU Treasure Hunt!");

                            gameRunning = false;
                        }

                        break;

                    case "4":
                        player.ShowProgress();
                        break;

                    case "5":
                        Console.WriteLine(
                            "\nThanks for playing! Better luck next time!");

                        gameRunning = false;
                        break;

                    default:
                        Console.WriteLine(
                            "\nInvalid choice! Please enter a number from 1 to 5.");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to close the game...");
            Console.ReadKey();
        }
    }
}
