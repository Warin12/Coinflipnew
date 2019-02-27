using System;

namespace coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
           int coin;
           string guess;
           Random rng = new Random();
           
           Console.WriteLine("Guess Heads or tails(H or T)");
           guess = Console.ReadLine();
           coin = rng.Next(0,2);
           if(coin == 0 && guess == "T");
           {
               Console.WriteLine("It landed on tails, you win");
           }
           else if (coin == 1 && guess == "H");
           {
               Console.WriteLine("It was Heads, you win");
           }

        }
    }
}
