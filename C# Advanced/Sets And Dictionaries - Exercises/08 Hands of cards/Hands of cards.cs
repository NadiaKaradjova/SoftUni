using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Hands_of_cards
{
    public class _08_Hands_of_cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                var line = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries); 
                var name = line[0];
                var cardsArray = line[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                

                if (!result.ContainsKey(name))
                {
                    var cards = new HashSet<string>();
                    result[name] = cards;
                }

                if (result.Any(x => x.Key == name))
                {
                    var current = result.First(x => x.Key == name);
                    foreach (var item in cardsArray)
                    {
                        current.Value.Add(item);
                    }
                    result[name] = current.Value;
                }
                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                var points = item.Value;
                var sum = CardsPoints(points);
                Console.WriteLine($"{item.Key}: {sum}");
            }
        }

        private static int CardsPoints(HashSet<string> cards)
        {
            var points = 0;
            var power = new Dictionary<string, int> { { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 } };
            var types = new Dictionary<string, int> { { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 } };

            foreach (var card in cards)
            {
                var currentCard = card;
                var currentCardPower = currentCard.Substring(0, currentCard.Length-1);
                var currentCardType = currentCard.Last().ToString();
                               
                var currentPower = 0;
                var currentType = 0;
                var isDigit = int.TryParse(currentCardPower, out currentPower);
                if (!isDigit && power.ContainsKey(currentCardPower))
                {
                    var temp = power.First(x => x.Key == currentCardPower);
                    currentPower = temp.Value;
                }

                if (types.ContainsKey(currentCardType))
                {
                    var temp = types.First(x => x.Key == currentCardType);
                    currentType = temp.Value;
                }
                points += currentPower * currentType;
            }
            return points;
        }
    }
}
