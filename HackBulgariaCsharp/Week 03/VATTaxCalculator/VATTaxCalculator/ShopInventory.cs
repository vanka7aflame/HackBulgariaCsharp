using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class ShopInventory
    {
        private Dictionary<Product, int> product = new Dictionary<Product, int>();

        public ShopInventory(Product newProduct)
        {
            if (product.ContainsKey(newProduct))
            {
                product[newProduct] += 1;
            }
            else
            {
                product.Add(newProduct, 1);
            }
        }
        public double Audit()
        {
            double total = 0;
            foreach (var item in product)
            {
                total += (item.Key.PrizeWithTax * item.Key.Quantity);
            }
            return total;
        }
        public void RequestOrder(Order order1)
        {
            foreach (var item in product)
            {
                if (item.Key.ID == order1.ProductID)
                {
                    if (item.Key.Quantity >= order1.Quantity)
                    {
                        double amount = 0;
                        amount = item.Key.PrizeWithTax * order1.Quantity;
                        Console.WriteLine("the order will cost you {0}", amount);
                    }
                    else
                    {
                        Console.WriteLine("We dont have that much quantity of that product");
                    }
                }
                else
                {
                    Console.WriteLine("We dont have such product in our inventory");
                }
            }
        }
    }
}
