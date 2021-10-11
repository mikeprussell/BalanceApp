using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = 5000;
            decimal bitcoin = 0;
            decimal ethereum = 0;
            decimal litecoin = 0;
            decimal bitcoinSpot = 7480;
            decimal ethereumSpot = 586.15m;
            decimal litecoinSpot = 119.04m;


            Console.WriteLine("Welcome back to C# Digital Bank!\n");
            Console.WriteLine("P)urchase digital currency using cash");
            Console.WriteLine("S)ell digital currency for cash");
            Console.WriteLine("V)iew all (4) account balances");
            Console.WriteLine("T)ransfer between digital currency types");

            ConsoleKey userChoice = Console.ReadKey(true).Key;

            do
            {
                switch (userChoice)
                {

                    case ConsoleKey.P:

                        do
                        {
                            Console.Clear();
                            Console.WriteLine($"You current cash balance is {cash}.");
                            Console.WriteLine("Press Y to contiue.");

                            Console.WriteLine("\nEnter one of the keys below to purchase a digital currency.");
                            Console.WriteLine("B)itcoin");
                            Console.WriteLine("E)thereum");
                            Console.WriteLine("L)itecoin");
                            Console.WriteLine("Escape to exit");

                        } while (true);

                        ConsoleKey userDigiPurchase = Console.ReadKey(true).Key;

                        switch (userDigiPurchase)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine("Enter quanity to purchase:");
                                decimal userBitRequest = Convert.ToDecimal(Console.ReadLine());
                                if (userBitRequest * bitcoinSpot > cash)
                                {
                                    Console.WriteLine("Insufficent Funds.");
                                }
                                else if (userBitRequest * bitcoinSpot <= cash)
                                {
                                    bitcoin += userBitRequest;
                                    Console.WriteLine($"\nYou have successfully purchased {userBitRequest} in bitcoin.");
                                    cash -= userBitRequest * bitcoinSpot;
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                }
                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("Enter quanity to purchase:");
                                decimal userEthereumRequest = Convert.ToDecimal(Console.ReadLine());
                                if (userEthereumRequest * ethereumSpot > cash)
                                {
                                    Console.WriteLine("Insufficent Funds.");
                                }
                                else if (userEthereumRequest * ethereumSpot <= cash)
                                {
                                    ethereum += userEthereumRequest;
                                    Console.WriteLine($"\nYou have successfully purchased {userEthereumRequest} in ethereum.");
                                    cash -= userEthereumRequest * ethereumSpot;
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                }
                                break;
                            case ConsoleKey.L:
                                Console.WriteLine("Enter quanity to purchase:");
                                decimal userLitecoinRequest = Convert.ToDecimal(Console.ReadLine());
                                if (userLitecoinRequest * litecoinSpot > cash)
                                {
                                    Console.WriteLine("Insufficent Funds.");
                                }
                                else if (userLitecoinRequest * litecoinSpot <= cash)
                                {
                                    litecoin += userLitecoinRequest;
                                    Console.WriteLine($"\nYou have successfully purchased {userLitecoinRequest} in litecoin.");
                                    cash -= userLitecoinRequest * litecoinSpot;
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.S:


                        break;
                    case ConsoleKey.V:


                        break;
                    case ConsoleKey.T:


                        break;

                    case ConsoleKey.Escape:

                    default:
                        Console.WriteLine("Invlaid input. Pleaes select P, S, V or T to continue. Press Escape to exit.");
                        break;
                }

            } while (true);


        }
    }
}
