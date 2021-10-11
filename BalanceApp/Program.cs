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
             
            bool mainRepeat = true;

            do
            {
            Console.WriteLine("Welcome back to C# Digital Bank!\n");
            Console.WriteLine("P)urchase digital currency using cash");
            Console.WriteLine("S)ell digital currency for cash");
            Console.WriteLine("V)iew all (4) account balances");
            Console.WriteLine("T)ransfer between digital currency types");

            ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                {

                    case ConsoleKey.P:
                        bool pRepeat = true;
                        while(pRepeat){
                                Console.Clear();
                                Console.WriteLine($"You current cash balance is {cash}.");
                                Console.WriteLine("\nEnter one of the keys below to purchase a digital currency.");
                                Console.WriteLine("B)itcoin");
                                Console.WriteLine("E)thereum");
                                Console.WriteLine("L)itecoin");

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
                                        pRepeat = false;
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
                                        pRepeat = false;
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
                                        pRepeat = false;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.S:
                        bool sRepeat = true;
                        while (sRepeat)
	                    {
                            Console.Clear();
                                Console.WriteLine($"You current cash balance is {cash}.");
                                Console.WriteLine("\nSelect which coin to sell");
                                Console.WriteLine("B)itcoin");
                                Console.WriteLine("E)thereum");
                                Console.WriteLine("L)itecoin");

                            ConsoleKey userDigiPurchase = Console.ReadKey(true).Key;

                            switch (userDigiPurchase)
                            {
                                case ConsoleKey.B:
                                    Console.WriteLine($"You sold {bitcoin} bitcoin.");
                                    cash += bitcoin * bitcoinSpot;
                                    sRepeat = false;
                                    break;
                                case ConsoleKey.E:
                                     Console.WriteLine($"You sold {ethereum} ethereum.");
                                    cash += ethereum * ethereumSpot;
                                    sRepeat = false;
                                    break;
                                case ConsoleKey.L:
                                     Console.WriteLine($"You sold {litecoin} litecoin.");
                                    cash += litecoin * litecoinSpot;
                                    sRepeat = false;
                                    break;
                                default:
                                    break;
                            }
	                    }

                        break;
                    case ConsoleKey.V:
                        Console.WriteLine("Current Balances:");
                        Console.WriteLine($"Cash: {cash}");
                        Console.WriteLine($"Bitcoin: {bitcoin}");
                        Console.WriteLine($"Etheruem: {ethereum}");
                        Console.WriteLine($"Litecoin: {litecoin}");
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.T:
                        //Starting Amount (Original Currency) / Ending Amount (New Currency) = Exchange Rate
                        //select which currency to start with
                        bool tRepeat = true;
                        while (tRepeat)
	                    {
                            Console.WriteLine("Which coin do you want to convert?\n\n");
                            Console.WriteLine("B)itcoin");
                            Console.WriteLine("E)thereum");
                            Console.WriteLine("L)itecoin");
                            ConsoleKey userConversion = Console.ReadKey(true).Key;
                            switch (userConversion)
	                        {
                                case ConsoleKey.B:
                                    Console.WriteLine("What would you like to convert to?");
                                    Console.WriteLine("E)thereum");
                                    Console.WriteLine("L)itecoin");
                                    ConsoleKey convChoice = Console.ReadKey(true).Key;
                                    switch (convChoice)
	                                {
                                        case ConsoleKey.E:
                                            decimal convAmount = bitcoinSpot / ethereumSpot;
                                            ethereum += convAmount * bitcoin;
                                            bitcoin = 0;
                                            tRepeat = false;
                                            break;
	                                	case ConsoleKey.L:
                                        default:
                                            decimal conversionAmount = bitcoinSpot / litecoinSpot;
                                            litecoin += conversionAmount * bitcoin;
                                            bitcoin = 0;
                                            tRepeat = false;
                                            break;
	                                }
                                    break;
	                        	default:
                                    break;
	                        }
	                    }
                        //seelct which currency to convert to
                        //do math things

                        break;

                    case ConsoleKey.Escape:
                        mainRepeat = false;
                        break;
                    default:
                        Console.WriteLine("Invlaid input. Pleaes select P, S, V or T to continue. Press Escape to exit.");
                        break;
                }

            } while (mainRepeat);


        }
    }
}
