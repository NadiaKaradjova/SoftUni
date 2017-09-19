using System;

namespace _11_The_Heigan_Dance
{
    public class _11_The_Heigan_Dance
    {
        private const int ChamberSize = 15;
        private const int CloudDamage = 3500;
        private const int EruptionDamage = 6000;
        private const double PlayerHealth = 18500;
        private const double HeiganHealth = 3000000;

        public static void Main()
        {
            var playerPosition = new int[] { ChamberSize / 2, ChamberSize / 2 };
            var heiganPoints = HeiganHealth;
            var playerPoints = PlayerHealth;
            var playerIsDead = false;
            var heiganIsDead = false;
            var hasCloud = false;
            var deathCouse = "";

            var damageToHeigan = double.Parse(Console.ReadLine());

            while (true)
            {
                var input = Console.ReadLine().Split();
                var spell = input[0];
                var spellRow = int.Parse(input[1]);
                var spellCol = int.Parse(input[2]);

                heiganPoints -= damageToHeigan;
                heiganIsDead = heiganPoints <= 0;

                if (hasCloud)
                {
                    playerPoints -= CloudDamage;
                    hasCloud = false;
                    playerIsDead = playerPoints <= 0;
                }
                if (heiganIsDead || playerIsDead)
                {
                    break;
                }

                if (PlayerIsInDamageZone(playerPosition, spellRow, spellCol))
                {
                    if (!PlayerTryEscape(playerPosition, spellRow, spellCol))
                    {
                        switch (spell)
                        {
                            case "Cloud":
                                playerPoints -= CloudDamage;
                                hasCloud = true;
                                deathCouse = "Plague Cloud";                               
                                break;
                            case "Eruption":
                                playerPoints -= EruptionDamage;
                                deathCouse = spell;
                                break;
                        }
                    }
                }

                playerIsDead = playerPoints <= 0;
                if (playerIsDead)
                {
                    break;
                }                
            }

            Print(playerPosition, heiganPoints, playerPoints, deathCouse);
        }

        private static void Print(int[] playerPosition, double heiganPoints, double playerPoints, string deathCouse)
        {
            if (heiganPoints <=0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganPoints:f2}");
            }

            if (playerPoints <= 0)
            {
                Console.WriteLine($"Player: Killed by {deathCouse}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPoints}");
            }
            Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
        }

        private static bool PlayerTryEscape(int[] playerPosition, int spellRow, int spellCol)
        {
            if (playerPosition[0]-1 >=0 && playerPosition[0] - 1 < spellRow - 1)
            {
                playerPosition[0]--;
                return true;
            }
            else if (playerPosition[1] + 1 < ChamberSize && playerPosition[1] + 1 > spellCol + 1)
            {
                playerPosition[1]++;
                return true;
            }
            else if (playerPosition[0] + 1 < ChamberSize && playerPosition[0] + 1 > spellRow + 1)
            {
                playerPosition[0]++;
                return true;
            }
            else if (playerPosition[1] - 1 >= 0 && playerPosition[1] - 1 < spellCol - 1)
            {
                playerPosition[1]--;
                return true;
            }

            return false;
        }

        private static bool PlayerIsInDamageZone(int[] playerPosition, int spellRow, int spellCol)
        {
            bool isHitRow = playerPosition[0] >= spellRow - 1 && playerPosition[0] <= spellRow + 1;
            bool isHitCol = playerPosition[1] >= spellCol - 1 && playerPosition[1] <= spellCol + 1;

            return isHitCol && isHitRow;
        }
    }
}
