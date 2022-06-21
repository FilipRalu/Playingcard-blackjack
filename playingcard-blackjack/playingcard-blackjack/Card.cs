using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playingcard_blackjack
{
    internal class Card
    {
        Cards c = new Cards();
        private string value;
        public int Card_Value(int i)
        {
            return c.Integer[i];
        }
        public Card(int i)
        {
            value = c.T[i];
        }
        public void Display()
        {
            Console.WriteLine("Cartea ta este: {0}", value);
        }
    }
}