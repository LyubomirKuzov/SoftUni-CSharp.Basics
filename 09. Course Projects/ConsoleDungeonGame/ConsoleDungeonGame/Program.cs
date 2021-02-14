using System;
using System.Threading;

namespace ConsoleDungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SlowSpeed(2000);
            Console.WriteLine("Welcome to my dungeon!");
            GoDownOneLine();
            SlowSpeed(2000);
            Console.Write("Your name is: ");

            string playerName = Console.ReadLine();

            int playerHealth = 100;
            int playerAttack = 10;
            int playerDefence = 0;
            int playerEnergy = 0;
            int playerCoins = 0;

            bool playerIsDead = false;
            bool playerHasWeapon = false;
            bool playerHasArmor = false;

            GoDownOneLine();
            SlowSpeed(2000);
            Console.WriteLine($"Good luck {playerName}, you will need it!");
            SlowSpeed(3000);
            Clear();

            for (int i = 1; i <= 15; i++)
            {
                PrintPlayerStats(playerHealth, playerAttack, playerDefence, playerEnergy, playerCoins);
                GoDownOneLine();
                GoDownOneLine();
                GoDownOneLine();
                SlowSpeed(2000);
                Console.WriteLine($"Entering room number {i}...");
                GoDownOneLine();

                int roomNumber = new Random().Next(1, 8);

                switch (roomNumber)
                {
                    case 1:
                    case 2:
                    case 3:

                        SlowSpeed(2000);
                        Console.WriteLine("You have met a Monster!");
                        GoDownOneLine();
                        SlowSpeed(2000);
                        Console.WriteLine("1) Attack the Monster!");
                        GoDownOneLine();
                        SlowSpeed(2000);
                        Console.WriteLine("2) Try to run away!");
                        GoDownOneLine();
                        SlowSpeed(2000);
                        Console.Write("You decide to: ");

                        int decision = int.Parse(Console.ReadLine());

                        Clear();

                        switch (decision)
                        {
                            case 1:
                                PrintPlayerStats(playerHealth, playerAttack, playerDefence, playerEnergy, playerCoins);
                                GoDownOneLine();
                                GoDownOneLine();
                                GoDownOneLine();
                                SlowSpeed(2000);
                                Console.WriteLine("You decide to attack the Monster!");
                                GoDownOneLine();

                                int monsterHealth = 20;
                                int monsterAttack = 15;

                                while (true)
                                {
                                    monsterHealth -= playerAttack;

                                    if (monsterHealth <= 0)
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine("You have killed the Monster!");
                                        GoDownOneLine();

                                        int earnedCoins = new Random().Next(50, 200);
                                        playerCoins += earnedCoins;

                                        SlowSpeed(2000);
                                        Console.WriteLine($"You have earned {earnedCoins} coins!");
                                        SlowSpeed(2000);
                                        break;
                                    }

                                    else
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine($"Attacking the Monster!");
                                        GoDownOneLine();
                                    }

                                    playerHealth = playerHealth - (monsterAttack - playerDefence);

                                    if (playerHealth <= 0)
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine("You have been killed by the monster!");
                                        GoDownOneLine();
                                        SlowSpeed(2000);
                                        Console.WriteLine("GAME OVER!");
                                        SlowSpeed(3000);

                                        playerIsDead = true;
                                        break;
                                    }

                                    else
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine($"The Monster has reduced your health!");
                                        GoDownOneLine();
                                    }
                                }

                                SlowSpeed(3000);
                                Clear();

                                break;

                            case 2:

                                PrintPlayerStats(playerHealth, playerAttack, playerDefence, playerEnergy, playerCoins);
                                GoDownOneLine();
                                GoDownOneLine();
                                GoDownOneLine();
                                if (playerEnergy >= 5)
                                {
                                    SlowSpeed(2000);
                                    Console.WriteLine("You run away from the Monster successfully!");
                                    playerEnergy -= 5;
                                }

                                else
                                {
                                    playerHealth -= 10;

                                    if (playerHealth > 0)
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine("You barely managed to run from the Monster!");
                                        GoDownOneLine();
                                        SlowSpeed(2000);
                                        Console.WriteLine("It managed to attack you!");
                                        GoDownOneLine();
                                        SlowSpeed(2000);
                                        Console.WriteLine("Your energy is too low, do not attempt to run away again!");
                                    }

                                    else
                                    {
                                        SlowSpeed(2000);
                                        Console.WriteLine("You have been killed by the monster!");
                                        GoDownOneLine();
                                        SlowSpeed(2000);
                                        Console.WriteLine("GAME OVER!");
                                        SlowSpeed(3000);

                                        playerIsDead = true;
                                        break;
                                    }
                                }

                                SlowSpeed(3000);
                                Clear();

                                break;
                        }

                        break;

                    case 4:

                        SlowSpeed(2000);
                        Console.WriteLine("You find a weapon!");
                        GoDownOneLine();

                        if (!playerHasWeapon)
                        {
                            SlowSpeed(2000);
                            Console.WriteLine("You take the weapon!");
                            GoDownOneLine();
                            SlowSpeed(2000);
                            Console.WriteLine("Your attack gets increased!");
                            playerAttack += 5;
                            playerHasWeapon = true;
                        }

                        else
                        {
                            SlowSpeed(2000);
                            Console.WriteLine("You leave the weapon, because you have better!");
                        }

                        SlowSpeed(3000);
                        Clear();

                        break;

                    case 5:

                        SlowSpeed(2000);
                        Console.WriteLine("You find a shield and armor!");
                        GoDownOneLine();

                        if (!playerHasArmor)
                        {
                            SlowSpeed(2000);
                            Console.WriteLine("You take them and your defence gets increased!");
                            playerDefence += 5;
                            playerHasArmor = true;
                        }

                        else
                        {
                            SlowSpeed(2000);
                            Console.WriteLine("You leave them, because you have better gear!");
                        }

                        SlowSpeed(3000);
                        Clear();

                        break;

                    case 6:

                        SlowSpeed(2000);
                        Console.WriteLine("You enter Regeneration room!");
                        GoDownOneLine();
                        SlowSpeed(2000);
                        Console.WriteLine("Your health gets restored to the maximum!");
                        playerHealth = 100;

                        SlowSpeed(3000);
                        Clear();

                        break;

                    case 7:

                        SlowSpeed(2000);
                        Console.WriteLine("You find an Energy Potion, which increases your energy!");
                        playerEnergy += 5;

                        SlowSpeed(3000);
                        Clear();

                        break;
                }

                if (playerIsDead)
                {
                    break;
                }

                if (i == 15 && !playerIsDead)
                {
                    SlowSpeed(2000);
                    Console.WriteLine("CONGRATULATIONS!");
                    GoDownOneLine();
                    SlowSpeed(2000);
                    Console.WriteLine("You have escaped the dungeon and won the game!");
                    GoDownOneLine();
                    SlowSpeed(2000);
                    Console.WriteLine($"Coins won: {playerCoins}");
                    SlowSpeed(3000);

                    break;
                }
            }
        }

        private static void PrintPlayerStats(int playerHealth, int playerAttack, int playerDefence, int playerEnergy, int playerCoins)
        {
            Console.WriteLine($"Health: {playerHealth} | Attack: {playerAttack} | Defence: {playerDefence} | Energy: {playerEnergy} | Coins: {playerCoins}");
        }



        private static void SlowSpeed(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        private static void GoDownOneLine()
        {
            Console.WriteLine();
        }

        private static void Clear()
        {
            Console.Clear();
        }
    }
}
