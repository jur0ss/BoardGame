// See https://aka.ms/new-console-template for more information

using static System.Console;

internal class Program
{

    public class Player
    {
        public string Name { get; set; }
        public int Position { get; private set; }
        public int Score { get; private set; }
        
        public string Type { get; private set; }

        public Player(string name, string type)
        {
            this.Name = name;
            Score = 0;
            Position = 0;
            this.Type = type;
        }
        
        
        private Random random = new Random();
        public int RollDice()
        {
            return random.Next(1, 7);
        }

        public void Move()
        {
            int steps = RollDice();
            Console.WriteLine($"{Name} wyrzucił {steps}");
            Position += steps;
            if (Position > 64)
            {
                Position = 64;
            }
            
        }

        public void UpdateScore(int points)
        {
            Score += points;
        }
    }

    public class Board
    {
        public int Size = 64;

        public static string GenerateReward(int position)
        {
            Random rand = new Random();
            if (rand.Next(1, 6) == 1) // 20% szans na nagrodę
            {
                return "Nagroda";
            }
            else
            {
                return "Brak nagrody";
            }
        }
    }

    public class Game
    {
        public List<Player> Players { get; set; }
        public Board GameBoard { get; set; }
    }



public static void Main(string[] args)
    {
        
    }
}