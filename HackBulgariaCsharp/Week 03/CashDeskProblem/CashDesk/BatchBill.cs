using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill: IEnumerable
    {
        private List<Bill> batchValues = new List<Bill>();
        private int? _total = null;
        public BatchBill(List<Bill> Bills)
        {
            batchValues = Bills;
        }
        public int Total
        {
            get
            {
                if (!this._total.HasValue)
                {
                    this._total = 0;
                    foreach (Bill item in batchValues)
                    {
                        this._total += item.Amount;
                    }
                }
                return this._total.Value;
            }
        }
        public List<Bill> BatchValues
        {
            get { return batchValues; }
        }
        
        public Bill this[int i]
        {
            get { return batchValues[i]; }
            set { batchValues[i] = value; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.BatchValues.GetEnumerator();
        }
    }
}
