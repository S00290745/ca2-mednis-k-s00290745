
using System.Collections.Generic;

namespace GreatATUTreasureHunt
{
    public class Player
    {
        public string Name { get; set; }

        public Location CurrentLocation { get; private set; }

        public List<Treasure> TreasuresCollected { get; private set; }

        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
            Score = 100;
            TreasuresCollected = new List<Treasure>();
        }

        public void MoveTo(Location location)
        {
            CurrentLocation = location;
        }

        public void CollectTreasure(Treasure treasure)
        {
            if (!treasure.IsCollected)
            {
                treasure.Collect();
                TreasuresCollected.Add(treasure);
                Score += treasure.Points;

                System.Console.WriteLine(
                    "\nYou collected: " + treasure.Name);

                System.Console.WriteLine(
                    "You earned " + treasure.Points + " points!");
            }
        }

        public void UseHint()
        {
            Score -= 5;

            if (Score < 0)
                Score = 0;

            System.Console.WriteLine(
                "Hint used! You lost 5 points.");
        }

        public void ShowProgress()
        {
            System.Console.WriteLine("\n===== PLAYER PROGRESS =====");
            System.Console.WriteLine("Player: " + Name);
            System.Console.WriteLine("Score: " + Score);
            System.Console.WriteLine(
                "Treasures collected: " +
                TreasuresCollected.Count + "/5");
            System.Console.WriteLine("===========================");
        }
    }
}
