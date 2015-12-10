using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryVatTax obj = new CountryVatTax(1, 20, false);
            CountryVatTax obj1 = new CountryVatTax(2, 10, true);
            List<CountryVatTax> countries = new List<CountryVatTax>() { obj, obj1 };
            Calculator calcObj = new Calculator(countries);
            calcObj.Calc(5);
            calcObj.Calc(5, 1);

            Product product = new Product(5, 1, "Хак", 5, 1, countries);
            Product product2 = new Product(10, 1, "България", 5, 2, countries);
            ShopInventory newShopInvertory = new ShopInventory(product);
            Console.WriteLine("If all products of that type are sold out, the profil you will gain is = {0}", newShopInvertory.Audit());

            Order firstOrder = new Order(1, 7);
            newShopInvertory.RequestOrder(firstOrder);
        }
    }
}
