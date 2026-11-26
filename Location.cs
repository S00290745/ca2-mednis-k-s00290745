
using System;

namespace GreatATUTreasureHunt
{
    // Abstract parent class for all campus locations.
    public abstract class Location
    {
        public string Name { get; set; }

        public Clue Clue { get; set; }

        public Treasure Treasure { get; set; }

        public string NextLocationHint { get; set; }

        public bool IsCompleted { get; private set; }

        protected Location(string name, Clue clue,
            Treasure treasure, string nextLocationHint)
        {
            Name = name;
            Clue = clue;
            Treasure = treasure;
            NextLocationHint = nextLocationHint;
            IsCompleted = false;
        }

        // Every location must describe itself.
        public abstract void Describe();

        // Every location must implement its own challenge.
        public abstract bool SolveChallenge(Player player);

        // Shared method used by all location subclasses.
        protected bool TrySolve(Player player)
        {
            if (IsCompleted)
            {
                Console.WriteLine("You have already found this treasure!");
                return false;
            }

            Console.WriteLine("\n" + Clue.Question);
            Console.Write("\nYour answer: ");

            string answer = Console.ReadLine() ?? "";

            if (Clue.CheckAnswer(answer))
            {
                Console.WriteLine("\nCorrect! Well done!");

                IsCompleted = true;
                player.CollectTreasure(Treasure);

                Console.WriteLine(
                    "Next clue: " + NextLocationHint);

                return true;
            }

            Console.WriteLine("\nIncorrect answer! Try again.");
            return false;
        }
    }
}
