using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Coins
    {
        private int coinAmount;

        public Coins(int coin)
        {
            this.CoinAmmount = coin;
        }

        public override string ToString()
        {
            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return string.Format("{0} " + ri.ISOCurrencySymbol + " Coins", this.coinAmount);
        }
        public int CoinAmmount
        {
            get { return this.coinAmount; }
            set { this.coinAmount = value; }
        }


    }
}
