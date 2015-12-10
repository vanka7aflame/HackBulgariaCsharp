using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class Order
    {
        private int productId;
        private int quantity;

        public Order(int productID, int quantity)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
        }
        public int ProductID
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
