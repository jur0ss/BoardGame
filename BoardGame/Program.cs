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

        public newPlayer(string name, string type)
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
            
        }
    }



public static void Main(string[] args)
    {
        
    }
}