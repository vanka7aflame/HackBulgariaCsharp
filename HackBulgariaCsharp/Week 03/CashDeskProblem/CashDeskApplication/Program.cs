using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk;

namespace CashDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            CashDesk obj = new CashDesk();
            Console.WriteLine("Commandlist \ntakebill \ntakebillBatch \ntakecoins \ntakecoinBatch \ninspect \ntotal \nexit \n");
            while (true)
            {
                string wholeCommand = Console.ReadLine();
                string[] command = wholeCommand.Split(' ');
                switch (command[0])
                {
                    case "takebill":
                        if (command.Length > 2)
                        {
                            Console.WriteLine("takebill command takes only 1 argument!");
                            break;
                        }
                        else
                        {
                            obj.TakeMoney(new Bill(int.Parse(command[1])));
                            break;
                        }
                    case "takebillBatch":
                        if (command.Length > 2)
                        {
                            List<Bill> bills = new List<Bill>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                bills.Add(new Bill(int.Parse((command[i]))));
                            }
                            obj.TakeMoney(new BatchBill(bills));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("takebillBatch command takes more than 1 argument");
                            break;
                        }
                    case "takecoins":
                        if (command.Length > 2)
                        {
                            Console.WriteLine("takecoins command takes only 1 argument");
                            break;
                        }
                        else
                        {
                            obj.TakeMoney(new Coins(int.Parse(command[1])));
                            break;
                        }
                    case "takecoinBatch":
                        if (command.Length > 2)
                        {
                            List<Coins> coins = new List<Coins>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                coins.Add(new Coins(int.Parse(command[i])));
                            }
                            obj.TakeMoney(new BatchCoins(coins));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("takecoinBatch command takes more than 1 argument!");
                            break;
                        }
                    case "inspect":
                        obj.Inspect();
                        break;
                    case "total":
                        obj.Total();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option"); 
                        break;
                }
            }
        }
    }
}