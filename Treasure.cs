
namespace GreatATUTreasureHunt
{
    public class Treasure
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public bool IsCollected { get; private set; }

        public Treasure(string name, int points)
        {
            Name = name;
            Points = points;
            IsCollected = false;
        }

        public void Collect()
        {
            IsCollected = true;
        }
    }
}
