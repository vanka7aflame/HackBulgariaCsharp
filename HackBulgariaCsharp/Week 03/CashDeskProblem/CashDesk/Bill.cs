using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill
    {
        private int amount;
        public Bill(int amount)
        {
            this.Amount = amount;
        }

        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public override string ToString()
        {
            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return string.Format("{0} " + ri.ISOCurrencySymbol + " Bill", this.amount);
        }
        public override bool Equals(object obj)
        {
            Bill bill = obj as Bill;
            if (bill is Bill)
            {
                if (this.amount == bill.amount)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator ==(Bill b1, Bill b2)
        {
            if (b1.amount == b2.amount)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Bill b1, Bill b2)
        {
            return !(b1 == b2);
        }
        public static explicit operator int (Bill bill)
        {
            return (int)bill;
        }
    }
}
