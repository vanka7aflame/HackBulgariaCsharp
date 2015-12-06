using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDesk
    {
        private Dictionary<int, int> desk = new Dictionary<int, int>();
        private Dictionary<int, int> coinDesk = new Dictionary<int, int>();
        public CashDesk() { }
        private bool CheckBills(Bill bill)
        {
            if (bill.Amount == 2 || bill.Amount == 5 || bill.Amount == 10 || bill.Amount == 20 || bill.Amount == 50 || bill.Amount == 100)
            {
                return true;
            }
            return false;
        }
        private bool CheckCoins(Coins coins)
        {
            if (coins.CoinAmmount == 1 || coins.CoinAmmount == 2 || coins.CoinAmmount == 5 || coins.CoinAmmount == 10
                || coins.CoinAmmount == 20 || coins.CoinAmmount == 50 || coins.CoinAmmount == 100)
            {
                return true;
            }
            return false;
        }
        public void TakeMoney(Bill bill)
        {
            if (CheckBills(bill))
            {
                if (desk.ContainsKey(bill.Amount))
                {
                    desk[bill.Amount] = desk[bill.Amount] + 1;
                }
                else
                {
                    desk.Add(bill.Amount, 1);
                }
            }
            else
            {
                Console.WriteLine("There is no such bill!");
            }
        }
        public void TakeMoney(BatchBill batch)
        {
            bool check = false;
            foreach (Bill bill in batch)
            {
                if (CheckBills(bill))
                {
                    check = true;   
                }
                else
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                foreach (Bill bill in batch)
                {
                    if (desk.ContainsKey(bill.Amount))
                    {
                        desk[bill.Amount] = desk[bill.Amount] + 1;
                    }
                    else
                    {
                        desk.Add(bill.Amount, 1);
                    }
                }
            }
        }
        public void TakeMoney(Coins coin)
        {
            if (CheckCoins(coin))
            {
                if (coinDesk.ContainsKey(coin.CoinAmmount))
                {
                    coinDesk[coin.CoinAmmount] += 1;
                }
                else
                {
                    coinDesk.Add(coin.CoinAmmount, 1);
                }
            }
        }
        public void TakeMoney(BatchCoins coinBatch)
        {
            bool check = false;
            foreach (Coins coin in coinBatch)
            {
                if (CheckCoins(coin))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            foreach (Coins coin in coinBatch)
            {
                if (check == true)
                {
                    if (coinDesk.ContainsKey(coin.CoinAmmount))
                    {
                        coinDesk[coin.CoinAmmount] += 1;
                    }
                    else
                    {
                        coinDesk.Add(coin.CoinAmmount, 1);
                    }
                }
            }
        }
        public void Inspect()
        {
            var coins = from pair in coinDesk orderby pair.Key ascending select pair;
            var bills = from pair in desk orderby pair.Key ascending select pair;
            foreach (var item in coins)
            {
                Console.WriteLine("{0} - {1}", new Coins(item.Key).ToString(), item.Value);
            }
            foreach (var item in bills)
            {
                Console.WriteLine("{0} - {1}", new Bill(item.Key).ToString(), item.Value);
            }
        }
        public void Total()
        {
            double total = 0;
            foreach (var item in coinDesk)
            {
                total += (item.Key * item.Value);
            }
            total = total / 100;
            foreach (var item in desk)
            {
                total += (item.Key * item.Value);
            }

            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            Console.WriteLine("Total = {0} " + ri.ISOCurrencySymbol + " ", total);
        }
    }
}
