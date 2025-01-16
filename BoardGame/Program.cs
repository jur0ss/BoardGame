// See https://aka.ms/new-console-template for more information

using static System.Console;

internal class Program
{

    public interface PlayerType
    {
        void PerformSpecialAction(Player player);
    }

    public class Warrior : PlayerType
    {
        public void PerformSpecialAction(Player player)
        {
            WriteLine($"{player.Name} używa specjalnej siły wojownika i zdobywa dodatkowe punkty!");
            player.UpdateScore(10);
        }
    }

    public class Wizard : PlayerType
    {
        public void PerformSpecialAction(Player player)
        {
            WriteLine($"{player.Name} rzuca zaklęcie i zyskuje dodatkowy ruch!");
            player.Move();
        }
    }

    public class Healer : PlayerType
    {
        public void PerformSpecialAction(Player player)
        {
            WriteLine($"{player.Name} leczy towarzyszy i zdobywa punkty za wsparcie");
            player.UpdateScore(5);
        }
    }
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

        public Game(List<Player> players)
        {
            Players = players;
            GameBoard = new Board();
        }

        public void StartGame()
        {
            int turn = 0;
            bool gameRunning = true;

            while (gameRunning)
            {
                Player currentPlayer = Players[turn % Players.Count];
            }
        }

        public void CheckReward(Player player)
        {
            string reward = Board.GenerateReward(player.Position);
            if (reward == "Nagroda")
            {
                int points = new Random().Next(10, 100);
                player.UpdateScore(points);
                Console.WriteLine($"Player {player.Name} zdobył {points} bonusowych punktów");
            }
        }
    }
    
    



public static void Main(string[] args)
    {
        
    }
}