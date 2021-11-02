using System;
using System.Collections.Generic;

namespace TheCardGame___Generic
{
    class Game
    {
        public List<Card> cardDeck;
        public List<Player> players;

        private Random random;
        private int totalCards = 36;
        private int[,] cardValue = new int [2,9] { { 6, 7, 8, 9, 10, 74, 81, 75, 65 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9} };
        private char[] cardSuit = { '\u2665', '\u2666', '\u2663', '\u2660' };

        public Game(int playersCount)
        {
            random = new Random();

            players = new List<Player>();
            for (int i = 0; i < playersCount; i++)
            {
                players.Add(new Player());
            }

            cardDeck = createCardDeck();
            shuffleCards(cardDeck);
            cardsDeal(players, cardDeck);
        }

        public List<Card> createCardDeck()
        {
            cardDeck = new List<Card>();
            int suitCount = totalCards / 4;

            for (int i = 0; i < suitCount; i++)
            {
                cardDeck.Add(new Card(cardValue[0, i], cardSuit[0]));
                cardDeck.Add(new Card(cardValue[0, i], cardSuit[1]));
                cardDeck.Add(new Card(cardValue[0, i], cardSuit[2]));
                cardDeck.Add(new Card(cardValue[0, i], cardSuit[3]));
            }

            return cardDeck;
        }

        public void shuffleCards(List<Card> cards)
        {
            cards.Sort((a, b) => random.Next(-2, 2));
        }

        public void cardsDeal(List<Player> players, List<Card> cards)
        {
            int currentPlayer = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                players[currentPlayer++].cards.Add(cards[i]);
                currentPlayer %= players.Count;
            }
        }

        public bool playersTurn(int count)
        {
            Console.WriteLine($"Players turn {count}:");
            Console.WriteLine("Player\tCard's q-ty\tTurn with card");

            int maxValue = -1;
            Player playerWithMaxValue = null;
            Stack<Card> cardStack = new Stack<Card>();

            for (int i = 0; i < players.Count; i++)
            {
                Player player = players[i];
                int cardweight = 0;

                if (player.cards.Count > 0)
                {
                    Card card = player.cards[random.Next(player.cards.Count)];

                    Console.WriteLine($"{i+1}\t{player.cards.Count}\t\t{card}");
                    player.cards.Remove(card);

                    for (int j = 0; j < totalCards/4; j++)
                        if (cardValue[0,j] == card.CardValue)
                        {
                            cardweight = cardValue[1,j];
                            break;
                        }

                    if (cardweight > maxValue)
                    {
                        maxValue = cardweight;
                        playerWithMaxValue = player;
                    }
                    cardStack.Push(card);
                }
            }

            playerWithMaxValue.cards.AddRange(cardStack);
            Console.WriteLine($"The cardstack took the player {players.IndexOf(playerWithMaxValue)+1}.");
            Console.WriteLine("------------------------------------------------\n");

            if (playerWithMaxValue.cards.Count == totalCards)
            {
                Console.WriteLine($"The winner is a player {players.IndexOf(playerWithMaxValue)+1}");
                return false;
            }

            return true;
        }
    }
}
