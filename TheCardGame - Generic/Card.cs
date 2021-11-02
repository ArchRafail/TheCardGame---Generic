using System;

namespace TheCardGame___Generic
{
    class Card
    {
        private int cardValue;
        private char cardSuit;
        public int CardValue {
            get => cardValue;
            private set
            { cardValue = value; }
        }
        public char CardSuit {
            get => cardSuit;
            private set
            { cardSuit = value; }
        }

        public Card(int cardValue, char cardSuit)
        {
            this.CardValue = cardValue;
            this.CardSuit = cardSuit;
        }

        public override string ToString()
        {
            return (CardValue > 10 ? $"{(char)CardValue}" : $"{CardValue}") + $"{CardSuit}";
        }

    }
}
