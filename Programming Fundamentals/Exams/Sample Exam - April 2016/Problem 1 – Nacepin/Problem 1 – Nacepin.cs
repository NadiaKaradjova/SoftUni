using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Nacepin
{
    public class Problem_1___Nacepin
    {
        public static void Main()
        {
            var priceUS = double.Parse(Console.ReadLine());
            var weightUS = long.Parse(Console.ReadLine());
            var priceUK = double.Parse(Console.ReadLine());
            var weightUK = long.Parse(Console.ReadLine());
            var priceChinese = double.Parse(Console.ReadLine());
            var weightChinese = long.Parse(Console.ReadLine());

            var nacepinUS = 0.0;
            var nacepinUK = 0.0;
            var nacepinChinese = 0.0;

            nacepinUS = priceUS / 0.58 / weightUS;
            nacepinUK = priceUK / 0.41 / weightUK;
            nacepinChinese = priceChinese * 0.27 / weightChinese;
            
            var winPrice = Math.Min(nacepinUS, Math.Min(nacepinUK, nacepinChinese));
            var maxPrice = Math.Max(nacepinUS, Math.Max(nacepinUK, nacepinChinese));

            if (winPrice == nacepinUS)
            {
                Console.WriteLine($"US store. {winPrice:f2} lv/kg");
            }
            else if (winPrice == nacepinUK)
            {
                Console.WriteLine($"UK store. {winPrice:f2} lv/kg");
            }
            else if (winPrice == nacepinChinese)
            {
                Console.WriteLine($"Chinese store. {winPrice:f2} lv/kg");
            }
            Console.WriteLine($"Difference {(maxPrice - winPrice):f2} lv/kg");

        }
    }
}
