using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchCoins: IEnumerable
    {
        private List<Coins> coinsValue = new List<Coins>();
        public BatchCoins(List<Coins> Coins)
        {
            this.coinsValue = Coins;
        }

        public List<Coins> CoinsValue
        { get { return coinsValue; } }

        public Coins this[int i]
        {
            get { return coinsValue[i]; }
            set { coinsValue[i] = value; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.CoinsValue.GetEnumerator();
        }
    }
}
