using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_Hands_of_Cards
{
    public class task5_Hands_of_Cards
    {
        public static void Main()
        {
            var cardPower = GetCardPower();
            var cardTypes = GetCardTypes();

            var cards = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var card in playerCards)
                {
                    var cardsPower = card.Substring(0, card.Length-1);
                    var cardsType = card.Substring(card.Length - 1);

                    var sum = cardPower[cardsPower] * cardTypes[cardsType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                    
                }

                line = Console.ReadLine();
            }
            foreach (var item in cards)
            {
                var name = item.Key;
                var cardsSum = item.Value.Sum();
                Console.WriteLine($"{name}: {cardsSum}");
            }
            

        }

        public static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }

        public static Dictionary<string, int> GetCardPower()
        {
            var power = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;
            }
            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14; 
            return power;
        }
    }
}
