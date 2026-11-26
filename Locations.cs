
namespace GreatATUTreasureHunt
{
    // Location 1: Computer Lab
    public class ComputerLab : Location
    {
        public ComputerLab()
            : base(
                "Computer Lab",
                new Clue(
                    "I connect your laptop to the internet. " +
                    "You cannot see me, but without me " +
                    "you cannot browse. What am I?",
                    "wifi",
                    "Think about the wireless internet connection."),
                new Treasure("Computer Token", 10),
                "Your next stop is where students queue for food."
            )
        {
        }

        public override void Describe()
        {
            System.Console.WriteLine(
                "\nYou are in the Computer Lab!");

            System.Console.WriteLine(
                "The computers are running and the Wi-Fi is working.");
        }

        public override bool SolveChallenge(Player player)
        {
            System.Console.WriteLine(
                "Solve the computer-related riddle!");

            return TrySolve(player);
        }
    }

    // Location 2: Canteen
    public class Canteen : Location
    {
        public Canteen()
            : base(
                "Canteen",
                new Clue(
                    "I am served hot, often in a mug. " +
                    "Students drink me to stay awake during lectures. " +
                    "What am I?",
                    "coffee",
                    "You might buy me before your morning lecture."),
                new Treasure("Canteen Token", 10),
                "Find the quiet place filled with books."
            )
        {
        }

        public override void Describe()
        {
            System.Console.WriteLine(
                "\nYou have arrived at the Canteen!");

            System.Console.WriteLine(
                "The queue is moving slowly. Someone is ordering chips!");
        }

        public override bool SolveChallenge(Player player)
        {
            System.Console.WriteLine(
                "Solve the canteen riddle!");

            return TrySolve(player);
        }
    }

    // Location 3: Library
    public class Library : Location
    {
        public Library()
            : base(
                "Library",
                new Clue(
                    "I have pages but I am not a website. " +
                    "I contain stories and information. " +
                    "What am I?",
                    "book",
                    "You can borrow me from a shelf."),
                new Treasure("Library Token", 10),
                "Look for the place where Clubs & Socs meet."
            )
        {
        }

        public override void Describe()
        {
            System.Console.WriteLine(
                "\nWelcome to the Library!");

            System.Console.WriteLine(
                "It is quiet here. Remember to keep your voice down!");
        }

        public override bool SolveChallenge(Player player)
        {
            System.Console.WriteLine(
                "Solve the library riddle!");

            return TrySolve(player);
        }
    }

    // Location 4: Students' Union
    public class StudentsUnion : Location
    {
        public StudentsUnion()
            : base(
                "Students' Union",
                new Clue(
                    "I bring students together through activities, " +
                    "events and shared interests. " +
                    "What am I?",
                    "societies",
                    "Think about the groups students join at college."),
                new Treasure("Union Token", 10),
                "Your next stop is where students leave their cars."
            )
        {
        }

        public override void Describe()
        {
            System.Console.WriteLine(
                "\nYou have reached the Students' Union!");

            System.Console.WriteLine(
                "Freshers' Week activities are happening everywhere.");
        }

        public override bool SolveChallenge(Player player)
        {
            System.Console.WriteLine(
                "Solve the Students' Union riddle!");

            return TrySolve(player);
        }
    }

    // Location 5: Car Park
    public class CarPark : Location
    {
        public CarPark()
            : base(
                "Car Park",
                new Clue(
                    "You need me to show that you have paid " +
                    "for parking. I am usually displayed " +
                    "in your car. What am I?",
                    "ticket",
                    "Think about proof that you have paid for parking."),
                new Treasure("Parking Token", 10),
                "You have all five tokens! Return to the Students' Union!"
            )
        {
        }

        public override void Describe()
        {
            System.Console.WriteLine(
                "\nYou have arrived at the Car Park!");

            System.Console.WriteLine(
                "Cars are everywhere. Finding a space is difficult!");
        }

        public override bool SolveChallenge(Player player)
        {
            System.Console.WriteLine(
                "Solve the final parking riddle!");

            return TrySolve(player);
        }
    }
}
