using System;
using System.Collections.Generic;

namespace TheCardGame___Generic
{
    class Program
    {
        static int Check(int answer)
        {
            while (answer < 2 || answer > 36 || 36 % answer != 0)
            {
                Console.WriteLine("Your choice is not correct.");
                Console.WriteLine("Check the requested parameter above.");
                Console.Write("Make your choice here - ");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            return answer;
        }
        static int Menu()
        {
            int answer;
            Console.WriteLine("The minimum q-ty of the players - 2 players.");
            Console.WriteLine("Maximum players is limited with q-ty of cards - 36 cards.");
            Console.WriteLine("All players must receive equal q-ty of cards.");
            Console.WriteLine("That's why all cardstack should divide by q-ty of players.");
            Console.WriteLine("How many players will play the game?");
            Console.Write("Type the correct answer here - ");
            answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return Check(answer);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("It is the card game");
            Console.WriteLine("Who put the card with high value he/she will return the cardstack.");
            Console.WriteLine("Player that receives total card will be the winner!\n");
            Game cardGame = new Game(Menu());
            int i = 1;
            while (cardGame.playersTurn(i++))
            { }
            Console.WriteLine("The end :)");
        }
    }
}
